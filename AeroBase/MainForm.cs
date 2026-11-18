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
        
private List<Part> parts = new List<Part>()
{
    new Part(1, "Пропеллеры DJI Mavic 3", "Пропеллеры", 8, "Склад А-1"),
    new Part(2, "Аккумулятор DJI Mini 3", "Аккумуляторы", 4, "Склад А-2"),
    new Part(3, "Камера DJI Matrice", "Камеры", 2, "Склад Б-1"),
    new Part(4, "GPS-модуль", "Электроника", 6, "Склад Б-2"),
    new Part(5, "Электродвигатель", "Двигатели", 3, "Склад В-1")
};


        private int nextDroneId = 1;
        private DataGridView? dgvParts; private TextBox? txtSearchDrone;
        private Button? btnAddPart;
private Button? btnEditPart;
private Button? btnDeletePart;

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

        btnComponents.Click += BtnComponents_Click;
btnDRONES.Click += (s, e) => ShowDronesPage();
        CreatePartsTable();
        CreateDroneSearch();
    }

        

private void CreateDroneSearch()
{
    txtSearchDrone = new TextBox();

    txtSearchDrone.Location = new System.Drawing.Point(240, 190);
    txtSearchDrone.Size = new System.Drawing.Size(300, 30);
    txtSearchDrone.PlaceholderText = "Поиск БПЛА по названию...";
    txtSearchDrone.Name = "txtSearchDrone";

    

txtSearchDrone.TextChanged += (s, e) =>
{
    ShowDrones();
};


    Controls.Add(txtSearchDrone);
}


private void CreatePartsTable()
{
    dgvParts = new DataGridView();

    dgvParts.Location = new System.Drawing.Point(240, 180);
    dgvParts.Size = new System.Drawing.Size(700, 430);
    dgvParts.Anchor = dgvDrones.Anchor;

    dgvParts.BackgroundColor = System.Drawing.Color.White;
    dgvParts.ReadOnly = true;
    dgvParts.AllowUserToAddRows = false;
    dgvParts.AllowUserToDeleteRows = false;
    dgvParts.RowHeadersVisible = false;
    dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    dgvParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

    dgvParts.Columns.Add("Id", "ID");
    dgvParts.Columns.Add("Name", "Название");
    dgvParts.Columns.Add("Category", "Категория");
    dgvParts.Columns.Add("Quantity", "Количество");
    dgvParts.Columns.Add("Storage", "Место хранения");

    foreach (Part part in parts)
    {
        dgvParts.Rows.Add(
            part.Id,
            part.Name,
            part.Category,
            part.Quantity,
            part.StorageLocation
        );
    }

    Controls.Add(dgvParts);
    dgvParts.Visible = false;

btnAddPart = new Button();
btnAddPart.Text = "+ Добавить";
btnAddPart.Location = new System.Drawing.Point(800, 140);
btnAddPart.Size = new System.Drawing.Size(140, 35);
btnAddPart.BackColor = System.Drawing.Color.RoyalBlue;
btnAddPart.ForeColor = System.Drawing.Color.White;
btnAddPart.FlatStyle = FlatStyle.Flat;
Controls.Add(btnAddPart);
btnAddPart.Visible = false;
btnAddPart.Click += BtnAddPart_Click;

btnEditPart = new Button();
btnEditPart.Text = "Изменить";
btnEditPart.Location = new System.Drawing.Point(257, 616);
btnEditPart.Size = new System.Drawing.Size(122, 35);
btnEditPart.BackColor = System.Drawing.SystemColors.ActiveCaption;
btnEditPart.ForeColor = System.Drawing.Color.White;
Controls.Add(btnEditPart);
btnEditPart.Visible = false;
btnEditPart.Click += BtnEditPart_Click;

btnDeletePart = new Button();
btnDeletePart.Text = "Удалить";
btnDeletePart.Location = new System.Drawing.Point(393, 616);
btnDeletePart.Size = new System.Drawing.Size(122, 35);
btnDeletePart.BackColor = System.Drawing.Color.IndianRed;
Controls.Add(btnDeletePart);
btnDeletePart.Visible = false;
btnDeletePart.Click += BtnDeletePart_Click;

}

private void BtnComponents_Click(object sender, EventArgs e)
{
    if (txtSearchDrone != null)
    txtSearchDrone.Visible = false;
    
    if (dgvParts == null) return;

    dgvDrones.Visible = false;
    dgvParts.Visible = true;
    dgvParts.BringToFront();

    lblTitle.Text = "Комплектующие БПЛА";

    panelStats.Visible = false;
    panelReady.Visible = false;
    panelMaintenance.Visible = false;

    btnAddDrone.Visible = false;
    btnChange.Visible = false;
    btnChange2.Visible = false;
    btnAddPart!.Visible = true;
btnEditPart!.Visible = true;
btnDeletePart!.Visible = true;
}


private void BtnAddPart_Click(object? sender, EventArgs e)
{
    using Form form = new Form();

    form.Text = "Добавление комплектующего";
    form.Size = new System.Drawing.Size(430, 380);
    form.StartPosition = FormStartPosition.CenterParent;
    form.FormBorderStyle = FormBorderStyle.FixedDialog;
    form.MaximizeBox = false;

    string[] labels =
    {
        "Название",
        "Категория",
        "Количество",
        "Место хранения"
    };

    TextBox[] inputs = new TextBox[4];

    for (int i = 0; i < 4; i++)
    {
        Label label = new Label();
        label.Text = labels[i];
        label.Location = new System.Drawing.Point(20, 25 + i * 55);
        label.Size = new System.Drawing.Size(120, 25);
        form.Controls.Add(label);

        inputs[i] = new TextBox();
        inputs[i].Location = new System.Drawing.Point(150, 22 + i * 55);
        inputs[i].Size = new System.Drawing.Size(230, 25);
        form.Controls.Add(inputs[i]);
    }

    Button save = new Button();
    save.Text = "Сохранить";
    save.Location = new System.Drawing.Point(150, 265);
    save.Size = new System.Drawing.Size(110, 35);
    save.BackColor = System.Drawing.Color.RoyalBlue;
    save.ForeColor = System.Drawing.Color.White;

    save.Click += (s, args) =>
    {
        string name = inputs[0].Text.Trim();
        string category = inputs[1].Text.Trim();
        string storage = inputs[3].Text.Trim();

        if (string.IsNullOrWhiteSpace(name) ||
            string.IsNullOrWhiteSpace(category) ||
            string.IsNullOrWhiteSpace(storage))
        {
            MessageBox.Show("Заполните все поля!");
            return;
        }

        if (!int.TryParse(inputs[2].Text, out int quantity) ||
            quantity < 0)
        {
            MessageBox.Show("Введите корректное количество!");
            return;
        }

        int newId = parts.Count == 0
            ? 1
            : parts.Max(p => p.Id) + 1;

        Part newPart = new Part(
            newId,
            name,
            category,
            quantity,
            storage
        );

        parts.Add(newPart);

        dgvParts!.Rows.Add(
            newPart.Id,
            newPart.Name,
            newPart.Category,
            newPart.Quantity,
            newPart.StorageLocation
        );

        form.DialogResult = DialogResult.OK;
        form.Close();
    };

    form.Controls.Add(save);
    form.ShowDialog(this);
}


private void BtnEditPart_Click(object? sender, EventArgs e)
{
    if (dgvParts?.CurrentRow == null)
    {
        MessageBox.Show("Выберите комплектующее!");
        return;
    }

    DataGridViewRow row = dgvParts.CurrentRow;

    if (!int.TryParse(row.Cells["Id"].Value?.ToString(), out int id))
    {
        MessageBox.Show("Не удалось определить комплектующее!");
        return;
    }

    Part? part = parts.FirstOrDefault(p => p.Id == id);

    if (part == null)
        return;

    using Form form = new Form();

    form.Text = "Редактирование комплектующего";
    form.Size = new System.Drawing.Size(430, 380);
    form.StartPosition = FormStartPosition.CenterParent;
    form.FormBorderStyle = FormBorderStyle.FixedDialog;
    form.MaximizeBox = false;

    string[] labels =
    {
        "Название",
        "Категория",
        "Количество",
        "Место хранения"
    };

    string[] values =
    {
        part.Name,
        part.Category,
        part.Quantity.ToString(),
        part.StorageLocation
    };

    TextBox[] inputs = new TextBox[4];

    for (int i = 0; i < 4; i++)
    {
        Label label = new Label();
        label.Text = labels[i];
        label.Location = new System.Drawing.Point(20, 25 + i * 55);
        label.Size = new System.Drawing.Size(120, 25);
        form.Controls.Add(label);

        inputs[i] = new TextBox();
        inputs[i].Location = new System.Drawing.Point(150, 22 + i * 55);
        inputs[i].Size = new System.Drawing.Size(230, 25);
        inputs[i].Text = values[i];
        form.Controls.Add(inputs[i]);
    }

    Button save = new Button();
    save.Text = "Сохранить";
    save.Location = new System.Drawing.Point(150, 265);
    save.Size = new System.Drawing.Size(110, 35);
    save.BackColor = System.Drawing.Color.RoyalBlue;
    save.ForeColor = System.Drawing.Color.White;

    save.Click += (s, args) =>
    {
        string name = inputs[0].Text.Trim();
        string category = inputs[1].Text.Trim();
        string storage = inputs[3].Text.Trim();

        if (string.IsNullOrWhiteSpace(name) ||
            string.IsNullOrWhiteSpace(category) ||
            string.IsNullOrWhiteSpace(storage))
        {
            MessageBox.Show("Заполните все поля!");
            return;
        }

        if (!int.TryParse(inputs[2].Text, out int quantity) ||
            quantity < 0)
        {
            MessageBox.Show("Введите корректное количество!");
            return;
        }

        part.Name = name;
        part.Category = category;
        part.Quantity = quantity;
        part.StorageLocation = storage;

        row.Cells["Name"].Value = part.Name;
        row.Cells["Category"].Value = part.Category;
        row.Cells["Quantity"].Value = part.Quantity;
        row.Cells["Storage"].Value = part.StorageLocation;

        form.DialogResult = DialogResult.OK;
        form.Close();
    };

    form.Controls.Add(save);
    form.ShowDialog(this);
}


private void BtnDeletePart_Click(object? sender, EventArgs e)
{
    if (dgvParts?.CurrentRow == null)
    {
        MessageBox.Show("Выберите комплектующее!");
        return;
    }

    if (!int.TryParse(
        dgvParts.CurrentRow.Cells["Id"].Value?.ToString(),
        out int partId))
    {
        MessageBox.Show("Не удалось определить комплектующее!");
        return;
    }

    Part? selectedPart = parts.FirstOrDefault(p => p.Id == partId);

    if (selectedPart == null)
        return;

    DialogResult result = MessageBox.Show(
        "Удалить комплектующее: " + selectedPart.Name + "?",
        "Подтверждение удаления",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

    if (result != DialogResult.Yes)
        return;

    parts.Remove(selectedPart);
    dgvParts.Rows.Remove(dgvParts.CurrentRow);

    MessageBox.Show("Комплектующее успешно удалено!");
}

private void ShowDronesPage()
{
    if (txtSearchDrone != null)
    txtSearchDrone.Visible = true;
    
    if (dgvParts != null)
        dgvParts.Visible = false;

    dgvDrones.Visible = true;
    dgvDrones.BringToFront();

    lblTitle.Text = "Система учета БПЛА";

    panelStats.Visible = true;
    panelReady.Visible = true;
    panelMaintenance.Visible = true;

    btnAddDrone.Visible = true;
    btnChange.Visible = true;
    btnChange2.Visible = true;

    if (btnAddPart != null) btnAddPart.Visible = false;
if (btnEditPart != null) btnEditPart.Visible = false;
if (btnDeletePart != null) btnDeletePart.Visible = false;
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

    dgvDrones.Columns[0].DataPropertyName = "Id";
    dgvDrones.Columns[1].DataPropertyName = "Name";
    dgvDrones.Columns[2].DataPropertyName = "InventoryNumber";
    dgvDrones.Columns[3].DataPropertyName = "Type";
    dgvDrones.Columns[4].DataPropertyName = "Status";

    string search = txtSearchDrone?.Text.Trim() ?? "";

    var filtered = drones
        .Where(d => d.Name.Contains(
            search,
            StringComparison.OrdinalIgnoreCase))
        .ToList();

    dgvDrones.DataSource = null;
    dgvDrones.DataSource = filtered;

    dgvDrones.Columns[0].Visible = false;
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