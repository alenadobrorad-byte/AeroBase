using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AeroBase
{
    public partial class AddDroneForm : Form
    {
        public string DroneName { get; private set; }
        public string InventoryNumber { get; private set; }
        public string Dronetype { get; private set; }
        public string DroneStatus { get; private set; }

        public AddDroneForm()
        {
            InitializeComponent();

            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
        }
        public void SetDroneData(AeroBase.Models.Drone drone)
        {
            txtDroneName.Text = drone.Name;
            txtInventoryNumber.Text = drone.InventoryNumber;
            txtDroneType.Text = drone.Type;
            txtDroneStatus.Text = drone.Status;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDroneName.Text) ||
                string.IsNullOrWhiteSpace(txtInventoryNumber.Text) ||
                string.IsNullOrWhiteSpace(txtDroneType.Text) ||
                string.IsNullOrWhiteSpace(txtDroneStatus.Text))
            {
                MessageBox.Show(
                    "Заполните все поля!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }
            DroneName = txtDroneName.Text.Trim();
            InventoryNumber = txtInventoryNumber.Text.Trim();
            Dronetype = txtDroneType.Text.Trim();
            DroneStatus = txtDroneStatus.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
