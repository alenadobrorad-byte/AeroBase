namespace AeroBase
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSidebar = new Panel();
            textBox1 = new TextBox();
            button23 = new Button();
            button1 = new Button();
            btnReules = new Button();
            btnComponents = new Button();
            btnDRONES = new Button();
            lblTitle = new Label();
            dgvDrones = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            colDroneName = new DataGridViewTextBoxColumn();
            InventoryNumber = new DataGridViewTextBoxColumn();
            ВкщтуЕнзу = new DataGridViewTextBoxColumn();
            DroneStatus = new DataGridViewTextBoxColumn();
            btnAddDrone = new Button();
            panelStats = new Panel();
            lblTotalDrones = new Label();
            lbltotalTitle = new Label();
            panelReady = new Panel();
            lblreadyDrones = new Label();
            lblReady = new Label();
            panelMaintenance = new Panel();
            lblMaintenanceDrones = new Label();
            lblMaintainTitle = new Label();
            btnChange = new Button();
            btnChange2 = new Button();
            dgvParts = new DataGridView();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDrones).BeginInit();
            panelStats.SuspendLayout();
            panelReady.SuspendLayout();
            panelMaintenance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParts).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(24, 40, 64);
            panelSidebar.Controls.Add(textBox1);
            panelSidebar.Controls.Add(button23);
            panelSidebar.Controls.Add(button1);
            panelSidebar.Controls.Add(btnReules);
            panelSidebar.Controls.Add(btnComponents);
            panelSidebar.Controls.Add(btnDRONES);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(210, 711);
            panelSidebar.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(24, 40, 64);
            textBox1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(38, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 44);
            textBox1.TabIndex = 4;
            textBox1.Text = "AeroBase";
            // 
            // button23
            // 
            button23.BackColor = Color.FromArgb(40, 60, 90);
            button23.FlatStyle = FlatStyle.Flat;
            button23.ForeColor = Color.White;
            button23.Location = new Point(15, 310);
            button23.Name = "button23";
            button23.Size = new Size(180, 44);
            button23.TabIndex = 3;
            button23.Text = "Обслуживание";
            button23.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 60, 90);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(15, 260);
            button1.Name = "button1";
            button1.Size = new Size(180, 44);
            button1.TabIndex = 2;
            button1.Text = "Обзор";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnReules
            // 
            btnReules.BackColor = Color.FromArgb(40, 60, 90);
            btnReules.FlatStyle = FlatStyle.Flat;
            btnReules.ForeColor = Color.White;
            btnReules.Location = new Point(15, 210);
            btnReules.Name = "btnReules";
            btnReules.Size = new Size(180, 44);
            btnReules.TabIndex = 1;
            btnReules.Text = "Правила";
            btnReules.UseVisualStyleBackColor = false;
            // 
            // btnComponents
            // 
            btnComponents.BackColor = Color.FromArgb(40, 60, 90);
            btnComponents.FlatStyle = FlatStyle.Flat;
            btnComponents.ForeColor = Color.White;
            btnComponents.Location = new Point(15, 160);
            btnComponents.Name = "btnComponents";
            btnComponents.Size = new Size(180, 44);
            btnComponents.TabIndex = 1;
            btnComponents.Text = "Комплектующие";
            btnComponents.UseVisualStyleBackColor = false;
            // 
            // btnDRONES
            // 
            btnDRONES.BackColor = Color.FromArgb(40, 60, 90);
            btnDRONES.FlatStyle = FlatStyle.Flat;
            btnDRONES.ForeColor = Color.White;
            btnDRONES.Location = new Point(15, 110);
            btnDRONES.Name = "btnDRONES";
            btnDRONES.Size = new Size(180, 44);
            btnDRONES.TabIndex = 0;
            btnDRONES.Text = "БПЛА";
            btnDRONES.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 50, 80);
            lblTitle.Location = new Point(240, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(450, 50);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Система учета  БПЛА";
            // 
            // dgvDrones
            // 
            dgvDrones.AllowUserToAddRows = false;
            dgvDrones.AllowUserToDeleteRows = false;
            dgvDrones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDrones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrones.Columns.AddRange(new DataGridViewColumn[] { id, colDroneName, InventoryNumber, ВкщтуЕнзу, DroneStatus });
            dgvDrones.Location = new Point(240, 231);
            dgvDrones.Name = "dgvDrones";
            dgvDrones.ReadOnly = true;
            dgvDrones.RowHeadersVisible = false;
            dgvDrones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDrones.Size = new Size(700, 379);
            dgvDrones.TabIndex = 2;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // colDroneName
            // 
            colDroneName.HeaderText = "Название";
            colDroneName.Name = "colDroneName";
            colDroneName.ReadOnly = true;
            // 
            // InventoryNumber
            // 
            InventoryNumber.HeaderText = "Номер";
            InventoryNumber.Name = "InventoryNumber";
            InventoryNumber.ReadOnly = true;
            // 
            // ВкщтуЕнзу
            // 
            ВкщтуЕнзу.HeaderText = "Тип";
            ВкщтуЕнзу.Name = "ВкщтуЕнзу";
            ВкщтуЕнзу.ReadOnly = true;
            // 
            // DroneStatus
            // 
            DroneStatus.HeaderText = "Состояние";
            DroneStatus.Name = "DroneStatus";
            DroneStatus.ReadOnly = true;
            // 
            // btnAddDrone
            // 
            btnAddDrone.BackColor = Color.RoyalBlue;
            btnAddDrone.FlatStyle = FlatStyle.Flat;
            btnAddDrone.ForeColor = Color.White;
            btnAddDrone.Location = new Point(819, 25);
            btnAddDrone.Name = "btnAddDrone";
            btnAddDrone.Size = new Size(140, 40);
            btnAddDrone.TabIndex = 3;
            btnAddDrone.Text = "+Добавить БПЛА";
            btnAddDrone.UseVisualStyleBackColor = false;
            btnAddDrone.Click += btnAddDrone_Click;
            // 
            // panelStats
            // 
            panelStats.BackColor = Color.White;
            panelStats.BorderStyle = BorderStyle.FixedSingle;
            panelStats.Controls.Add(lblTotalDrones);
            panelStats.Controls.Add(lbltotalTitle);
            panelStats.Location = new Point(280, 92);
            panelStats.Name = "panelStats";
            panelStats.Size = new Size(160, 85);
            panelStats.TabIndex = 4;
            // 
            // lblTotalDrones
            // 
            lblTotalDrones.AutoSize = true;
            lblTotalDrones.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTotalDrones.Location = new Point(14, 37);
            lblTotalDrones.Name = "lblTotalDrones";
            lblTotalDrones.Size = new Size(28, 32);
            lblTotalDrones.TabIndex = 1;
            lblTotalDrones.Text = "5";
            // 
            // lbltotalTitle
            // 
            lbltotalTitle.AutoSize = true;
            lbltotalTitle.ForeColor = Color.Gray;
            lbltotalTitle.Location = new Point(3, 7);
            lbltotalTitle.Name = "lbltotalTitle";
            lbltotalTitle.Size = new Size(73, 15);
            lbltotalTitle.TabIndex = 0;
            lbltotalTitle.Text = "Всего БПЛА";
            lbltotalTitle.Click += lbltotalTitle_Click;
            // 
            // panelReady
            // 
            panelReady.BackColor = Color.White;
            panelReady.BorderStyle = BorderStyle.FixedSingle;
            panelReady.Controls.Add(lblreadyDrones);
            panelReady.Controls.Add(lblReady);
            panelReady.Location = new Point(482, 92);
            panelReady.Name = "panelReady";
            panelReady.Size = new Size(160, 85);
            panelReady.TabIndex = 5;
            // 
            // lblreadyDrones
            // 
            lblreadyDrones.AutoSize = true;
            lblreadyDrones.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblreadyDrones.ForeColor = Color.SeaGreen;
            lblreadyDrones.Location = new Point(13, 37);
            lblreadyDrones.Name = "lblreadyDrones";
            lblreadyDrones.Size = new Size(28, 32);
            lblreadyDrones.TabIndex = 1;
            lblreadyDrones.Text = "3";
            // 
            // lblReady
            // 
            lblReady.AutoSize = true;
            lblReady.BackColor = Color.White;
            lblReady.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblReady.ForeColor = Color.Gray;
            lblReady.Location = new Point(3, 7);
            lblReady.Name = "lblReady";
            lblReady.Size = new Size(70, 15);
            lblReady.TabIndex = 0;
            lblReady.Text = "Исправные";
            lblReady.Click += label1_Click;
            // 
            // panelMaintenance
            // 
            panelMaintenance.BackColor = Color.White;
            panelMaintenance.BorderStyle = BorderStyle.FixedSingle;
            panelMaintenance.Controls.Add(lblMaintenanceDrones);
            panelMaintenance.Controls.Add(lblMaintainTitle);
            panelMaintenance.Location = new Point(683, 92);
            panelMaintenance.Name = "panelMaintenance";
            panelMaintenance.Size = new Size(160, 85);
            panelMaintenance.TabIndex = 6;
            // 
            // lblMaintenanceDrones
            // 
            lblMaintenanceDrones.AutoSize = true;
            lblMaintenanceDrones.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblMaintenanceDrones.ForeColor = Color.DarkOrange;
            lblMaintenanceDrones.Location = new Point(13, 37);
            lblMaintenanceDrones.Name = "lblMaintenanceDrones";
            lblMaintenanceDrones.Size = new Size(28, 32);
            lblMaintenanceDrones.TabIndex = 1;
            lblMaintenanceDrones.Text = "2";
            // 
            // lblMaintainTitle
            // 
            lblMaintainTitle.AutoSize = true;
            lblMaintainTitle.BackColor = Color.White;
            lblMaintainTitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblMaintainTitle.ForeColor = Color.Gray;
            lblMaintainTitle.Location = new Point(3, 7);
            lblMaintainTitle.Name = "lblMaintainTitle";
            lblMaintainTitle.Size = new Size(107, 15);
            lblMaintainTitle.TabIndex = 0;
            lblMaintainTitle.Text = "На обслуживании";
            // 
            // btnChange
            // 
            btnChange.BackColor = SystemColors.ActiveCaption;
            btnChange.ForeColor = SystemColors.HighlightText;
            btnChange.Location = new Point(262, 639);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(100, 35);
            btnChange.TabIndex = 7;
            btnChange.Text = "Изменить";
            btnChange.UseVisualStyleBackColor = false;
            // 
            // btnChange2
            // 
            btnChange2.BackColor = Color.IndianRed;
            btnChange2.Location = new Point(399, 639);
            btnChange2.Name = "btnChange2";
            btnChange2.Size = new Size(100, 35);
            btnChange2.TabIndex = 8;
            btnChange2.Text = "Удалить";
            btnChange2.UseMnemonic = false;
            btnChange2.UseVisualStyleBackColor = false;
            // 
            // dgvParts
            // 
            dgvParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParts.Location = new Point(963, 260);
            dgvParts.Name = "dgvParts";
            dgvParts.Size = new Size(348, 350);
            dgvParts.TabIndex = 9;
            dgvParts.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 247, 251);
            ClientSize = new Size(1337, 711);
            Controls.Add(dgvParts);
            Controls.Add(btnChange2);
            Controls.Add(btnChange);
            Controls.Add(panelMaintenance);
            Controls.Add(panelReady);
            Controls.Add(panelStats);
            Controls.Add(btnAddDrone);
            Controls.Add(dgvDrones);
            Controls.Add(lblTitle);
            Controls.Add(panelSidebar);
            MinimumSize = new Size(1000, 650);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AeroBase - учет БПЛА";
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDrones).EndInit();
            panelStats.ResumeLayout(false);
            panelStats.PerformLayout();
            panelReady.ResumeLayout(false);
            panelReady.PerformLayout();
            panelMaintenance.ResumeLayout(false);
            panelMaintenance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Button btnDRONES;
        private Button btnComponents;
        private Button btnReules;
        private Label lblTitle;
        private DataGridView dgvDrones;
        private Button btnAddDrone;
        private Panel panelStats;
        private Label lblTotalDrones;
        private Panel panelReady;
        private Label lbltotalTitle;
        private Panel panelMaintenance;
        private Label lblreadyDrones;
        private Label lblReady;
        private Label lblMaintenanceDrones;
        private Label lblMaintainTitle;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn colDroneName;
        private DataGridViewTextBoxColumn InventoryNumber;
        private DataGridViewTextBoxColumn ВкщтуЕнзу;
        private DataGridViewTextBoxColumn DroneStatus;
        private Button btnChange2;
        private Button button23;
        private Button button1;

        private Button btnChange;
        private TextBox textBox1;
        private DataGridView dgvParts;
    }
}
