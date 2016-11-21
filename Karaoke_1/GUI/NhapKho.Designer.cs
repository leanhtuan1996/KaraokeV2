namespace Karaoke_1.GUI
{
    partial class NhapKho
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
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtMaNhap = new MetroFramework.Controls.MetroTextBox();
            this.txtSoluong = new MetroFramework.Controls.MetroTextBox();
            this.cmbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmbTenSanPham = new System.Windows.Forms.ComboBox();
            this.btnThemvaoList = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtGianhap = new MetroFramework.Controls.MetroTextBox();
            this.btnNhap = new MetroFramework.Controls.MetroButton();
            this.btnHuy = new MetroFramework.Controls.MetroButton();
            this.dtpNgayNhap = new MetroFramework.Controls.MetroDateTime();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstSP = new System.Windows.Forms.ListView();
            this.tensp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gianhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nhacungcap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThemNhaCungCap = new MetroFramework.Controls.MetroButton();
            this.ctmChinhSuaList = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.chỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.ctmChinhSuaList.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(100, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Mã nhập";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(100, 115);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Tên sản phẩm";
            // 
            // txtMaNhap
            // 
            // 
            // 
            // 
            this.txtMaNhap.CustomButton.Image = null;
            this.txtMaNhap.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtMaNhap.CustomButton.Name = "";
            this.txtMaNhap.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMaNhap.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaNhap.CustomButton.TabIndex = 1;
            this.txtMaNhap.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaNhap.CustomButton.UseSelectable = true;
            this.txtMaNhap.CustomButton.Visible = false;
            this.txtMaNhap.Lines = new string[0];
            this.txtMaNhap.Location = new System.Drawing.Point(206, 78);
            this.txtMaNhap.MaxLength = 32767;
            this.txtMaNhap.Name = "txtMaNhap";
            this.txtMaNhap.PasswordChar = '\0';
            this.txtMaNhap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaNhap.SelectedText = "";
            this.txtMaNhap.SelectionLength = 0;
            this.txtMaNhap.SelectionStart = 0;
            this.txtMaNhap.ShortcutsEnabled = true;
            this.txtMaNhap.Size = new System.Drawing.Size(216, 23);
            this.txtMaNhap.TabIndex = 2;
            this.txtMaNhap.UseSelectable = true;
            this.txtMaNhap.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaNhap.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSoluong
            // 
            // 
            // 
            // 
            this.txtSoluong.CustomButton.Image = null;
            this.txtSoluong.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtSoluong.CustomButton.Name = "";
            this.txtSoluong.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSoluong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSoluong.CustomButton.TabIndex = 1;
            this.txtSoluong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSoluong.CustomButton.UseSelectable = true;
            this.txtSoluong.CustomButton.Visible = false;
            this.txtSoluong.Lines = new string[0];
            this.txtSoluong.Location = new System.Drawing.Point(206, 236);
            this.txtSoluong.MaxLength = 32767;
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.PasswordChar = '\0';
            this.txtSoluong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSoluong.SelectedText = "";
            this.txtSoluong.SelectionLength = 0;
            this.txtSoluong.SelectionStart = 0;
            this.txtSoluong.ShortcutsEnabled = true;
            this.txtSoluong.Size = new System.Drawing.Size(216, 23);
            this.txtSoluong.TabIndex = 10;
            this.txtSoluong.UseSelectable = true;
            this.txtSoluong.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSoluong.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbNhaCungCap
            // 
            this.cmbNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbNhaCungCap.FormattingEnabled = true;
            this.cmbNhaCungCap.Location = new System.Drawing.Point(206, 311);
            this.cmbNhaCungCap.Name = "cmbNhaCungCap";
            this.cmbNhaCungCap.Size = new System.Drawing.Size(216, 24);
            this.cmbNhaCungCap.TabIndex = 9;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(99, 316);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(90, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Nhà cung cấp";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(111, 236);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Số lượng";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(102, 197);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Đơn vị tính";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(104, 157);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(73, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Ngày nhập";
            // 
            // cmbTenSanPham
            // 
            this.cmbTenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbTenSanPham.FormattingEnabled = true;
            this.cmbTenSanPham.Location = new System.Drawing.Point(206, 115);
            this.cmbTenSanPham.Name = "cmbTenSanPham";
            this.cmbTenSanPham.Size = new System.Drawing.Size(216, 24);
            this.cmbTenSanPham.TabIndex = 9;
            this.cmbTenSanPham.SelectionChangeCommitted += new System.EventHandler(this.cmbTenSanPham_SelectionChangeCommitted);
            // 
            // btnThemvaoList
            // 
            this.btnThemvaoList.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThemvaoList.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnThemvaoList.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThemvaoList.Location = new System.Drawing.Point(44, 357);
            this.btnThemvaoList.Name = "btnThemvaoList";
            this.btnThemvaoList.Size = new System.Drawing.Size(498, 54);
            this.btnThemvaoList.Style = MetroFramework.MetroColorStyle.White;
            this.btnThemvaoList.TabIndex = 13;
            this.btnThemvaoList.Text = "Thêm vào danh sách";
            this.btnThemvaoList.UseCustomBackColor = true;
            this.btnThemvaoList.UseCustomForeColor = true;
            this.btnThemvaoList.UseSelectable = true;
            this.btnThemvaoList.Click += new System.EventHandler(this.btnThemvaoList_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(99, 279);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(88, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Đơn giá nhập";
            // 
            // txtGianhap
            // 
            // 
            // 
            // 
            this.txtGianhap.CustomButton.Image = null;
            this.txtGianhap.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtGianhap.CustomButton.Name = "";
            this.txtGianhap.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGianhap.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGianhap.CustomButton.TabIndex = 1;
            this.txtGianhap.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGianhap.CustomButton.UseSelectable = true;
            this.txtGianhap.CustomButton.Visible = false;
            this.txtGianhap.Lines = new string[0];
            this.txtGianhap.Location = new System.Drawing.Point(206, 275);
            this.txtGianhap.MaxLength = 32767;
            this.txtGianhap.Name = "txtGianhap";
            this.txtGianhap.PasswordChar = '\0';
            this.txtGianhap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGianhap.SelectedText = "";
            this.txtGianhap.SelectionLength = 0;
            this.txtGianhap.SelectionStart = 0;
            this.txtGianhap.ShortcutsEnabled = true;
            this.txtGianhap.Size = new System.Drawing.Size(216, 23);
            this.txtGianhap.TabIndex = 10;
            this.txtGianhap.UseSelectable = true;
            this.txtGianhap.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGianhap.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnNhap
            // 
            this.btnNhap.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNhap.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnNhap.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNhap.Location = new System.Drawing.Point(76, 578);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(154, 42);
            this.btnNhap.Style = MetroFramework.MetroColorStyle.White;
            this.btnNhap.TabIndex = 13;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseCustomBackColor = true;
            this.btnNhap.UseCustomForeColor = true;
            this.btnNhap.UseSelectable = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHuy.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnHuy.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHuy.Location = new System.Drawing.Point(348, 578);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(154, 42);
            this.btnHuy.Style = MetroFramework.MetroColorStyle.White;
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseCustomBackColor = true;
            this.btnHuy.UseCustomForeColor = true;
            this.btnHuy.UseSelectable = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Location = new System.Drawing.Point(206, 157);
            this.dtpNgayNhap.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(216, 29);
            this.dtpNgayNhap.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstSP);
            this.groupBox1.Location = new System.Drawing.Point(23, 417);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 142);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm sắp được thêm";
            // 
            // lstSP
            // 
            this.lstSP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tensp,
            this.unit,
            this.soluong,
            this.gianhap,
            this.nhacungcap});
            this.lstSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSP.FullRowSelect = true;
            this.lstSP.GridLines = true;
            this.lstSP.Location = new System.Drawing.Point(3, 16);
            this.lstSP.MultiSelect = false;
            this.lstSP.Name = "lstSP";
            this.lstSP.Size = new System.Drawing.Size(535, 123);
            this.lstSP.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lstSP.TabIndex = 0;
            this.lstSP.UseCompatibleStateImageBehavior = false;
            this.lstSP.View = System.Windows.Forms.View.Details;
            this.lstSP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstSP_MouseClick);
            // 
            // tensp
            // 
            this.tensp.Text = "Tên sản phẩm";
            this.tensp.Width = 100;
            // 
            // unit
            // 
            this.unit.Text = "Đơn vị tính";
            this.unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.unit.Width = 70;
            // 
            // soluong
            // 
            this.soluong.Text = "Số lượng";
            this.soluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gianhap
            // 
            this.gianhap.Text = "Giá nhập";
            this.gianhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gianhap.Width = 100;
            // 
            // nhacungcap
            // 
            this.nhacungcap.Text = "Nhà cung cấp";
            this.nhacungcap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nhacungcap.Width = 200;
            // 
            // btnThemNhaCungCap
            // 
            this.btnThemNhaCungCap.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThemNhaCungCap.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnThemNhaCungCap.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThemNhaCungCap.Location = new System.Drawing.Point(431, 312);
            this.btnThemNhaCungCap.Name = "btnThemNhaCungCap";
            this.btnThemNhaCungCap.Size = new System.Drawing.Size(130, 23);
            this.btnThemNhaCungCap.Style = MetroFramework.MetroColorStyle.White;
            this.btnThemNhaCungCap.TabIndex = 18;
            this.btnThemNhaCungCap.Text = "Thêm nhà cung cấp";
            this.btnThemNhaCungCap.UseCustomBackColor = true;
            this.btnThemNhaCungCap.UseCustomForeColor = true;
            this.btnThemNhaCungCap.UseSelectable = true;
            this.btnThemNhaCungCap.Click += new System.EventHandler(this.btnThemNhaCungCap_Click);
            // 
            // ctmChinhSuaList
            // 
            this.ctmChinhSuaList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chỉnhSửaToolStripMenuItem});
            this.ctmChinhSuaList.Name = "ctmChinhSuaList";
            this.ctmChinhSuaList.Size = new System.Drawing.Size(95, 26);
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            this.chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            this.chỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.chỉnhSửaToolStripMenuItem.Text = "Xóa";
            this.chỉnhSửaToolStripMenuItem.Click += new System.EventHandler(this.chỉnhSửaToolStripMenuItem_Click);
            // 
            // cmbUnit
            // 
            this.cmbUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(206, 197);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(216, 24);
            this.cmbUnit.TabIndex = 9;
            // 
            // NhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 627);
            this.Controls.Add(this.btnThemNhaCungCap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.btnThemvaoList);
            this.Controls.Add(this.txtGianhap);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.cmbTenSanPham);
            this.Controls.Add(this.cmbNhaCungCap);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtMaNhap);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(579, 627);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(579, 627);
            this.Name = "NhapKho";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Nhập Kho";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.NhapKho_Load);
            this.groupBox1.ResumeLayout(false);
            this.ctmChinhSuaList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtMaNhap;
        private MetroFramework.Controls.MetroTextBox txtSoluong;
        private System.Windows.Forms.ComboBox cmbNhaCungCap;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ComboBox cmbTenSanPham;
        private MetroFramework.Controls.MetroButton btnThemvaoList;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtGianhap;
        private MetroFramework.Controls.MetroButton btnNhap;
        private MetroFramework.Controls.MetroButton btnHuy;
        private MetroFramework.Controls.MetroDateTime dtpNgayNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstSP;
        private System.Windows.Forms.ColumnHeader tensp;
        private System.Windows.Forms.ColumnHeader unit;
        private System.Windows.Forms.ColumnHeader soluong;
        private System.Windows.Forms.ColumnHeader gianhap;
        private System.Windows.Forms.ColumnHeader nhacungcap;
        private MetroFramework.Controls.MetroButton btnThemNhaCungCap;
        private MetroFramework.Controls.MetroContextMenu ctmChinhSuaList;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbUnit;
    }
}