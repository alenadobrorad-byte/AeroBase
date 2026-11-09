namespace AeroBase
{
    partial class AddDroneForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblNumber = new Label();
            lblType = new Label();
            lblStatus = new Label();
            txtDroneName = new TextBox();
            txtInventoryNumber = new TextBox();
            txtDroneType = new TextBox();
            txtDroneStatus = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(11, 34);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Название";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(11, 64);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(122, 15);
            lblNumber.TabIndex = 1;
            lblNumber.Text = "Инвентарный номер";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(12, 93);
            lblType.Name = "lblType";
            lblType.Size = new Size(62, 15);
            lblType.TabIndex = 2;
            lblType.Text = "Тип БПЛА";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 122);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(66, 15);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Состояние";
            // 
            // txtDroneName
            // 
            txtDroneName.Location = new Point(139, 34);
            txtDroneName.Name = "txtDroneName";
            txtDroneName.Size = new Size(283, 23);
            txtDroneName.TabIndex = 4;
            // 
            // txtInventoryNumber
            // 
            txtInventoryNumber.Location = new Point(139, 64);
            txtInventoryNumber.Name = "txtInventoryNumber";
            txtInventoryNumber.Size = new Size(283, 23);
            txtInventoryNumber.TabIndex = 5;
            // 
            // txtDroneType
            // 
            txtDroneType.Location = new Point(139, 93);
            txtDroneType.Name = "txtDroneType";
            txtDroneType.Size = new Size(283, 23);
            txtDroneType.TabIndex = 6;
            // 
            // txtDroneStatus
            // 
            txtDroneStatus.Location = new Point(139, 122);
            txtDroneStatus.Name = "txtDroneStatus";
            txtDroneStatus.Size = new Size(283, 23);
            txtDroneStatus.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.RoyalBlue;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(71, 231);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 40);
            btnSave.TabIndex = 8;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += this.btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightGray;
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(280, 230);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 40);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // AddDroneForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(434, 361);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtDroneStatus);
            Controls.Add(txtDroneType);
            Controls.Add(txtInventoryNumber);
            Controls.Add(txtDroneName);
            Controls.Add(lblStatus);
            Controls.Add(lblType);
            Controls.Add(lblNumber);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddDroneForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление БПЛА";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblNumber;
        private Label lblType;
        private Label lblStatus;
        private TextBox txtDroneName;
        private TextBox txtInventoryNumber;
        private TextBox txtDroneType;
        private TextBox txtDroneStatus;
        private Button btnSave;
        private Button btnCancel;
    }
}