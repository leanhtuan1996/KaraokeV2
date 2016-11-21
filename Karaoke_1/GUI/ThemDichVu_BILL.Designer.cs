namespace Karaoke_1.GUI
{
    partial class Them_SuaDichVu_BILL
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbTenDVHienCo_BILL = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtSoLuongDV_BILL = new MetroFramework.Controls.MetroTextBox();
            this.btnThemDV_BILL = new System.Windows.Forms.Button();
            this.btnHuyDV_BILL = new System.Windows.Forms.Button();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblDVT = new MetroFramework.Controls.MetroLabel();
            this.txtDonGiaDV_BILL = new MetroFramework.Controls.MetroTextBox();
            this.cmbDonViTinh_ThemDV = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(119, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Tên dịch vụ hiện có";
            // 
            // cmbTenDVHienCo_BILL
            // 
            this.cmbTenDVHienCo_BILL.FormattingEnabled = true;
            this.cmbTenDVHienCo_BILL.ItemHeight = 23;
            this.cmbTenDVHienCo_BILL.Location = new System.Drawing.Point(151, 73);
            this.cmbTenDVHienCo_BILL.Name = "cmbTenDVHienCo_BILL";
            this.cmbTenDVHienCo_BILL.Size = new System.Drawing.Size(171, 29);
            this.cmbTenDVHienCo_BILL.TabIndex = 1;
            this.cmbTenDVHienCo_BILL.UseSelectable = true;
            this.cmbTenDVHienCo_BILL.SelectionChangeCommitted += new System.EventHandler(this.cmbTenDVHienCo_BILL_SelectionChangeCommitted);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(48, 196);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Số lượng";
            // 
            // txtSoLuongDV_BILL
            // 
            // 
            // 
            // 
            this.txtSoLuongDV_BILL.CustomButton.Image = null;
            this.txtSoLuongDV_BILL.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtSoLuongDV_BILL.CustomButton.Name = "";
            this.txtSoLuongDV_BILL.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSoLuongDV_BILL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSoLuongDV_BILL.CustomButton.TabIndex = 1;
            this.txtSoLuongDV_BILL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSoLuongDV_BILL.CustomButton.UseSelectable = true;
            this.txtSoLuongDV_BILL.CustomButton.Visible = false;
            this.txtSoLuongDV_BILL.Lines = new string[0];
            this.txtSoLuongDV_BILL.Location = new System.Drawing.Point(150, 197);
            this.txtSoLuongDV_BILL.MaxLength = 32767;
            this.txtSoLuongDV_BILL.Name = "txtSoLuongDV_BILL";
            this.txtSoLuongDV_BILL.PasswordChar = '\0';
            this.txtSoLuongDV_BILL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSoLuongDV_BILL.SelectedText = "";
            this.txtSoLuongDV_BILL.SelectionLength = 0;
            this.txtSoLuongDV_BILL.SelectionStart = 0;
            this.txtSoLuongDV_BILL.ShortcutsEnabled = true;
            this.txtSoLuongDV_BILL.Size = new System.Drawing.Size(171, 23);
            this.txtSoLuongDV_BILL.TabIndex = 3;
            this.txtSoLuongDV_BILL.UseSelectable = true;
            this.txtSoLuongDV_BILL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSoLuongDV_BILL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnThemDV_BILL
            // 
            this.btnThemDV_BILL.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThemDV_BILL.FlatAppearance.BorderSize = 0;
            this.btnThemDV_BILL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDV_BILL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDV_BILL.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThemDV_BILL.Location = new System.Drawing.Point(52, 256);
            this.btnThemDV_BILL.Name = "btnThemDV_BILL";
            this.btnThemDV_BILL.Size = new System.Drawing.Size(106, 40);
            this.btnThemDV_BILL.TabIndex = 4;
            this.btnThemDV_BILL.Text = "Thêm";
            this.btnThemDV_BILL.UseVisualStyleBackColor = false;
            this.btnThemDV_BILL.Click += new System.EventHandler(this.btnThemDV_BILL_Click);
            // 
            // btnHuyDV_BILL
            // 
            this.btnHuyDV_BILL.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHuyDV_BILL.FlatAppearance.BorderSize = 0;
            this.btnHuyDV_BILL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyDV_BILL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDV_BILL.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHuyDV_BILL.Location = new System.Drawing.Point(216, 256);
            this.btnHuyDV_BILL.Name = "btnHuyDV_BILL";
            this.btnHuyDV_BILL.Size = new System.Drawing.Size(106, 40);
            this.btnHuyDV_BILL.TabIndex = 4;
            this.btnHuyDV_BILL.Text = "Hủy ";
            this.btnHuyDV_BILL.UseVisualStyleBackColor = false;
            this.btnHuyDV_BILL.Click += new System.EventHandler(this.btnHuyDV_BILL_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(39, 119);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Đơn vị tính";
            // 
            // lblDVT
            // 
            this.lblDVT.AutoSize = true;
            this.lblDVT.Location = new System.Drawing.Point(55, 157);
            this.lblDVT.Name = "lblDVT";
            this.lblDVT.Size = new System.Drawing.Size(55, 19);
            this.lblDVT.TabIndex = 2;
            this.lblDVT.Text = "Đơn giá";
            // 
            // txtDonGiaDV_BILL
            // 
            // 
            // 
            // 
            this.txtDonGiaDV_BILL.CustomButton.Image = null;
            this.txtDonGiaDV_BILL.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtDonGiaDV_BILL.CustomButton.Name = "";
            this.txtDonGiaDV_BILL.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDonGiaDV_BILL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDonGiaDV_BILL.CustomButton.TabIndex = 1;
            this.txtDonGiaDV_BILL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDonGiaDV_BILL.CustomButton.UseSelectable = true;
            this.txtDonGiaDV_BILL.CustomButton.Visible = false;
            this.txtDonGiaDV_BILL.Lines = new string[0];
            this.txtDonGiaDV_BILL.Location = new System.Drawing.Point(151, 157);
            this.txtDonGiaDV_BILL.MaxLength = 32767;
            this.txtDonGiaDV_BILL.Name = "txtDonGiaDV_BILL";
            this.txtDonGiaDV_BILL.PasswordChar = '\0';
            this.txtDonGiaDV_BILL.ReadOnly = true;
            this.txtDonGiaDV_BILL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDonGiaDV_BILL.SelectedText = "";
            this.txtDonGiaDV_BILL.SelectionLength = 0;
            this.txtDonGiaDV_BILL.SelectionStart = 0;
            this.txtDonGiaDV_BILL.ShortcutsEnabled = true;
            this.txtDonGiaDV_BILL.Size = new System.Drawing.Size(171, 23);
            this.txtDonGiaDV_BILL.TabIndex = 3;
            this.txtDonGiaDV_BILL.UseSelectable = true;
            this.txtDonGiaDV_BILL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDonGiaDV_BILL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbDonViTinh_ThemDV
            // 
            this.cmbDonViTinh_ThemDV.FormattingEnabled = true;
            this.cmbDonViTinh_ThemDV.ItemHeight = 23;
            this.cmbDonViTinh_ThemDV.Location = new System.Drawing.Point(150, 119);
            this.cmbDonViTinh_ThemDV.Name = "cmbDonViTinh_ThemDV";
            this.cmbDonViTinh_ThemDV.Size = new System.Drawing.Size(171, 29);
            this.cmbDonViTinh_ThemDV.TabIndex = 1;
            this.cmbDonViTinh_ThemDV.UseSelectable = true;
            this.cmbDonViTinh_ThemDV.SelectionChangeCommitted += new System.EventHandler(this.cmbDonViTinh_ThemDV_SelectionChangeCommitted);
            // 
            // Them_SuaDichVu_BILL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 323);
            this.ControlBox = false;
            this.Controls.Add(this.btnHuyDV_BILL);
            this.Controls.Add(this.btnThemDV_BILL);
            this.Controls.Add(this.txtSoLuongDV_BILL);
            this.Controls.Add(this.txtDonGiaDV_BILL);
            this.Controls.Add(this.lblDVT);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cmbDonViTinh_ThemDV);
            this.Controls.Add(this.cmbTenDVHienCo_BILL);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Them_SuaDichVu_BILL";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Thêm Dịch Vụ";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Them_SuaDichVu_BILL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbTenDVHienCo_BILL;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtSoLuongDV_BILL;
        private System.Windows.Forms.Button btnThemDV_BILL;
        private System.Windows.Forms.Button btnHuyDV_BILL;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lblDVT;
        private MetroFramework.Controls.MetroTextBox txtDonGiaDV_BILL;
        private MetroFramework.Controls.MetroComboBox cmbDonViTinh_ThemDV;
    }
}