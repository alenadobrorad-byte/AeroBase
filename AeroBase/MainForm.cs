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
                    drones.Add(new Drone(
                     nextDroneId++,
                     form.DroneName,
                     form.DroneName,
                     form.InventoryNumber,
                     form.Dronetype,
                     form.DroneStatus
                     ));
                    ShowDrones();
                    UpdateStats();
                }
            }
        }
        private void InitData()
        {
            drones.Add(new Drone(1, "DJI Mavic 3", "DJI Mavic 3", "Квадрокоптер", "006", "Исправен"));
            drones.Add(new Drone(2, "DJI Mini 3", "DJI Mini 3", "Квадрокоптер", "007", "Исправен"));
            drones.Add(new Drone(3, "DJI Matrice 600 PRO", "DJI Matrice 600 PRO", "Гексакоптер", "008", "Исправен"));
            drones.Add(new Drone(4, "DJI Matrice 300 RTK", "DJI Matrice 300 RTK", "Квадрокоптер", "009", "На обслуживании"));
            drones.Add(new Drone(5, "Parrot DISCO", "Parrot DISCO", "Самолётный тип", "—", "На обслуживании"));

            ShowDrones();
        }


        private void ShowDrones()
        {
            dgvDrones.AutoGenerateColumns = false;
            dgvDrones.Columns[0].DataPropertyName = "id";
            dgvDrones.Columns[1].DataPropertyName = "Name";
            dgvDrones.Columns[2].DataPropertyName = "InventoryNumber";
            dgvDrones.Columns[3].DataPropertyName = "Type";
            dgvDrones.Columns[4].DataPropertyName = "Status";

            var bs = new BindingSource();
            bs.DataSource = drones;
            dgvDrones.DataSource = bs;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void btnChange2_Click(object sender, EventArgs e)
        {
            if (dgvDrones.CurrentRow == null)
            {
                MessageBox.Show("Выберите дрон для удаления!");
                return;
            }

            if (dgvDrones.CurrentRow.DataBoundItem is not Drone selectedDrone)
            {
                MessageBox.Show("Не удалось выбрать дрон");
                return;
            }
            DialogResult result = MessageBox.Show
                ("Удалить дрон" + selectedDrone.Name + "?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                drones.Remove(selectedDrone);
                ShowDrones();
                UpdateStats();

                MessageBox.Show("Дрон успешно удален!");
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dgvDrones.CurrentRow?.DataBoundItem is not Drone selectedDrone)
            {
                MessageBox.Show("Выберите дрон для изменения");
                return;
            }
            using (AddDroneForm form = new AddDroneForm())
            {
                form.SetDroneData(selectedDrone);


                if (form.ShowDialog() == DialogResult.OK)
                {
                    selectedDrone.Name = form.DroneName;
                    selectedDrone.Model = form.DroneName;
                    selectedDrone.InventoryNumber = form.InventoryNumber;
                    selectedDrone.Type = form.Dronetype;
                    selectedDrone.Status = form.DroneStatus;

                    ShowDrones();
                    UpdateStats();

                    MessageBox.Show("Дрон успешно изменен!");
                }
            }
        }
    }
}