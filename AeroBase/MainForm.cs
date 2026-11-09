using System;
using System.Linq;
using System.Windows.Forms;

namespace AeroBase
{
    public partial class MainForm : Form
    {

        private int nextDroneId = 1;

        public MainForm()
        {
            InitializeComponent();

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
    }
}