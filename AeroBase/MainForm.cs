using AeroBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace AeroBase
{
    public partial class MainForm : Form
    {
        private List<Drone> drones = new List<Drone>();
        private List<Part> parts = new List<Part>();

        private int nextDroneId = 1;

        public MainForm()
        {
            InitializeComponent();
            InitData();

            dgvDrones.AllowUserToAddRows = false;

            if (dgvDrones.Columns.Count >= 5)
                dgvDrones.Columns[0].Visible = false;

            dgvDrones.RowsAdded += (s, e) => UpdateStats();
            dgvDrones.RowsRemoved += (s, e) => UpdateStats();
            dgvDrones.CellValueChanged += (s, e) => UpdateStats();

            UpdateStats();
        }

        private void UpdateStats()
        {
            int total = 0;
            int working = 0;
            int maintenance = 0;

            foreach (DataGridViewRow row in dgvDrones.Rows)
            {
                if (row.IsNewRow) continue;

                total++;

                string status = Convert.ToString(
                row.Cells[4].Value
                )?.Trim() ?? "";

                if (status.Equals("Исправен",
                StringComparison.OrdinalIgnoreCase))
                    working++;

                if (status.Equals("На обслуживании",
                StringComparison.OrdinalIgnoreCase))
                    maintenance++;
            }
            lblTotalDrones.Text = total.ToString();
            lblreadyDrones.Text = working.ToString();
            lblMaintenanceDrones.Text = maintenance.ToString();

        }

        private void lbltotalTitle_Click(
        object sender, EventArgs e)
        {
        }

        private void label1_Click(
        object sender, EventArgs e)
        {
        }

        private void btnAddDrone_Click(
        object sender, EventArgs e)
        {
            using (AddDroneForm form = new AddDroneForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    dgvDrones.Rows.Add(
                    nextDroneId++,
                    form.DroneName,
                    form.InventoryNumber,
                    form.Dronetype,
                    form.DroneStatus
                    );

                    UpdateStats();
                }
            }
        }
        private void InitData()
        {
            for (int i = 1; i <= 5; i++)
                drones.Add(new Drone(i, $"БПЛА-{i}", "Model-A", "Мультикоптер", $"INV-{i}", "New"));

            for (int i = 1; i <= 10; i++)
                parts.Add(new Part(i, $"Деталь-{i}", "Электроника", i * 5, "Склад-1"));


            drones.Add(new Drone(1, "DJI Mavic 3", "DJI Mavic 3", "Квадрокоптер", "006", "Исправен"));
            drones.Add(new Drone(2, "DJI Mini 3", "DJI Mini 3", "Квадрокоптер", "007", "Исправен"));
            drones.Add(new Drone(3, "DJI Matrice 600 PRO", "DJI Matrice 600 PRO", "Гексакоптер", "008", "Исправен"));
            drones.Add(new Drone(4, "DJI Matrice 300 RTK", "DJI Matrice 300 RTK", "Квадрокоптер", "009", "На обслуживании"));
            drones.Add(new Drone(5, "Parrot DISCO", "Parrot DISCO", "Самолётный тип", "—", "На обслуживании")); 

            parts.Add(new Part(1, "АКБ для DJI Mavic 3", "Питание", 3, "Шкаф А - DJI Mavic 3"));
            parts.Add(new Part(2, "Пропеллеры Mavic 3 (комплект)", "Винты", 4, "Шкаф А - DJI Mavic 3"));
            parts.Add(new Part(3, "Кабель USB-C", "Подключение", 6, "Ящик 1 - Универсальный"));
            parts.Add(new Part(4, "Зарядное устройство", "Питание", 2, "Шкаф Б - Совместимые АКБ"));
            parts.Add(new Part(5, "Карта microSD 128 ГБ", "Память", 5, "Ящик 2 - Совместимые БПЛА"));
            parts.Add(new Part(6, "Посадочная площадка", "Аксессуары", 2, "Стеллаж - Универсальная"));
            parts.Add(new Part(7, "Сумка для транспортировки", "Хранение", 3, "Стеллаж - По модели"));
            parts.Add(new Part(8, "Запасные крепления", "Корпус", 8, "Ящик 3 - По модели"));

            ShowDrones();
            ShowParts();
        }


        private void ShowDrones()
        {
            var bs = new BindingSource();
            bs.DataSource = drones;
            dgvDrones.DataSource = bs;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ShowParts()
        {
            var bs = new BindingSource();
            bs.DataSource = parts;
            dgvParts.DataSource = bs;
        }


    }



}