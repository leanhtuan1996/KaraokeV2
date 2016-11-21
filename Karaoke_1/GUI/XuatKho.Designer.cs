namespace Karaoke_1.GUI
{
    partial class XuatKho
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
            this.lstSanPhamXuat = new System.Windows.Forms.ListView();
            this.name_product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonViTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenNCC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHuy = new MetroFramework.Controls.MetroButton();
            this.btnXuatKho = new MetroFramework.Controls.MetroButton();
            this.btnThem = new MetroFramework.Controls.MetroButton();
            this.txtSoluong = new MetroFramework.Controls.MetroTextBox();
            this.cmbTenSanPham = new System.Windows.Forms.ComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtMaXuat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.ctmChinhSuaList = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.dtpNgayXuat = new MetroFramework.Controls.MetroDateTime();
            this.ctmChinhSuaList.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSanPhamXuat
            // 
            this.lstSanPhamXuat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name_product,
            this.DonViTinh,
            this.soluong,
            this.TenNCC});
            this.lstSanPhamXuat.FullRowSelect = true;
            this.lstSanPhamXuat.GridLines = true;
            this.lstSanPhamXuat.Location = new System.Drawing.Point(23, 403);
            this.lstSanPhamXuat.Name = "lstSanPhamXuat";
            this.lstSanPhamXuat.Size = new System.Drawing.Size(385, 105);
            this.lstSanPhamXuat.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstSanPhamXuat.TabIndex = 33;
            this.lstSanPhamXuat.UseCompatibleStateImageBehavior = false;
            this.lstSanPhamXuat.View = System.Windows.Forms.View.Details;
            this.lstSanPhamXuat.Click += new System.EventHandler(this.lstSanPhamXuat_Click);
            this.lstSanPhamXuat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstSanPhamXuat_MouseClick);
            // 
            // name_product
            // 
            this.name_product.Text = "Tên sản phẩm";
            this.name_product.Width = 140;
            // 
            // DonViTinh
            // 
            this.DonViTinh.Text = "Đơn vị tính";
            this.DonViTinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DonViTinh.Width = 80;
            // 
            // soluong
            // 
            this.soluong.Text = "Số lượng";
            this.soluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TenNCC
            // 
            this.TenNCC.Text = "Tên NCC";
            this.TenNCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TenNCC.Width = 100;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHuy.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnHuy.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHuy.Location = new System.Drawing.Point(242, 523);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(154, 42);
            this.btnHuy.TabIndex = 32;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseCustomBackColor = true;
            this.btnHuy.UseCustomForeColor = true;
            this.btnHuy.UseSelectable = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXuatKho
            // 
            this.btnXuatKho.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXuatKho.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnXuatKho.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXuatKho.Location = new System.Drawing.Point(35, 523);
            this.btnXuatKho.Name = "btnXuatKho";
            this.btnXuatKho.Size = new System.Drawing.Size(154, 42);
            this.btnXuatKho.TabIndex = 31;
            this.btnXuatKho.Text = "Xuất";
            this.btnXuatKho.UseCustomBackColor = true;
            this.btnXuatKho.UseCustomForeColor = true;
            this.btnXuatKho.UseSelectable = true;
            this.btnXuatKho.Click += new System.EventHandler(this.btnXuatKho_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnThem.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThem.Location = new System.Drawing.Point(23, 344);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(385, 42);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm vào danh sách";
            this.btnThem.UseCustomBackColor = true;
            this.btnThem.UseCustomForeColor = true;
            this.btnThem.UseSelectable = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSoluong
            // 
            // 
            // 
            // 
            this.txtSoluong.CustomButton.Image = null;
            this.txtSoluong.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtSoluong.CustomButton.Name = "";
            this.txtSoluong.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSoluong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSoluong.CustomButton.TabIndex = 1;
            this.txtSoluong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSoluong.CustomButton.UseSelectable = true;
            this.txtSoluong.CustomButton.Visible = false;
            this.txtSoluong.Lines = new string[0];
            this.txtSoluong.Location = new System.Drawing.Point(159, 249);
            this.txtSoluong.MaxLength = 32767;
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.PasswordChar = '\0';
            this.txtSoluong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSoluong.SelectedText = "";
            this.txtSoluong.SelectionLength = 0;
            this.txtSoluong.SelectionStart = 0;
            this.txtSoluong.ShortcutsEnabled = true;
            this.txtSoluong.Size = new System.Drawing.Size(200, 23);
            this.txtSoluong.TabIndex = 26;
            this.txtSoluong.UseSelectable = true;
            this.txtSoluong.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSoluong.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSoluong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoluong_KeyDown);
            this.txtSoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoluong_KeyPress);
            // 
            // cmbTenSanPham
            // 
            this.cmbTenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbTenSanPham.FormattingEnabled = true;
            this.cmbTenSanPham.Location = new System.Drawing.Point(159, 164);
            this.cmbTenSanPham.Name = "cmbTenSanPham";
            this.cmbTenSanPham.Size = new System.Drawing.Size(200, 24);
            this.cmbTenSanPham.TabIndex = 25;
            this.cmbTenSanPham.SelectionChangeCommitted += new System.EventHandler(this.cmbTenSanPham_SelectionChangeCommitted);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(48, 249);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 19);
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "Số lượng";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(46, 77);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 23;
            this.metroLabel3.Text = "Ngày xuất";
            // 
            // txtMaXuat
            // 
            // 
            // 
            // 
            this.txtMaXuat.CustomButton.Image = null;
            this.txtMaXuat.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtMaXuat.CustomButton.Name = "";
            this.txtMaXuat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMaXuat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaXuat.CustomButton.TabIndex = 1;
            this.txtMaXuat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaXuat.CustomButton.UseSelectable = true;
            this.txtMaXuat.CustomButton.Visible = false;
            this.txtMaXuat.Lines = new string[0];
            this.txtMaXuat.Location = new System.Drawing.Point(159, 119);
            this.txtMaXuat.MaxLength = 32767;
            this.txtMaXuat.Name = "txtMaXuat";
            this.txtMaXuat.PasswordChar = '\0';
            this.txtMaXuat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaXuat.SelectedText = "";
            this.txtMaXuat.SelectionLength = 0;
            this.txtMaXuat.SelectionStart = 0;
            this.txtMaXuat.ShortcutsEnabled = true;
            this.txtMaXuat.Size = new System.Drawing.Size(200, 23);
            this.txtMaXuat.TabIndex = 18;
            this.txtMaXuat.UseSelectable = true;
            this.txtMaXuat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaXuat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(46, 164);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 19);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "Tên sản phẩm";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(45, 123);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Mã xuất";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(48, 207);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 19);
            this.metroLabel4.TabIndex = 36;
            this.metroLabel4.Text = "Đơn vị tính";
            // 
            // ctmChinhSuaList
            // 
            this.ctmChinhSuaList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem});
            this.ctmChinhSuaList.Name = "ctmChinhSuaList";
            this.ctmChinhSuaList.Size = new System.Drawing.Size(95, 26);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // cmbNhaCungCap
            // 
            this.cmbNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbNhaCungCap.FormattingEnabled = true;
            this.cmbNhaCungCap.Location = new System.Drawing.Point(159, 291);
            this.cmbNhaCungCap.Name = "cmbNhaCungCap";
            this.cmbNhaCungCap.Size = new System.Drawing.Size(200, 24);
            this.cmbNhaCungCap.TabIndex = 39;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(45, 291);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(90, 19);
            this.metroLabel6.TabIndex = 38;
            this.metroLabel6.Text = "Nhà cung cấp";
            // 
            // cmbUnit
            // 
            this.cmbUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(159, 207);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(200, 24);
            this.cmbUnit.TabIndex = 40;
            this.cmbUnit.SelectionChangeCommitted += new System.EventHandler(this.cmbUnit_SelectionChangeCommitted);
            // 
            // dtpNgayXuat
            // 
            this.dtpNgayXuat.Location = new System.Drawing.Point(159, 77);
            this.dtpNgayXuat.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpNgayXuat.Name = "dtpNgayXuat";
            this.dtpNgayXuat.Size = new System.Drawing.Size(200, 29);
            this.dtpNgayXuat.TabIndex = 41;
            // 
            // XuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 575);
            this.Controls.Add(this.dtpNgayXuat);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.cmbNhaCungCap);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.lstSanPhamXuat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXuatKho);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.cmbTenSanPham);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtMaXuat);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XuatKho";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Xuất kho";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.XuatKho_Load);
            this.ctmChinhSuaList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstSanPhamXuat;
        private MetroFramework.Controls.MetroButton btnHuy;
        private MetroFramework.Controls.MetroButton btnXuatKho;
        private MetroFramework.Controls.MetroButton btnThem;
        private MetroFramework.Controls.MetroTextBox txtSoluong;
        private System.Windows.Forms.ComboBox cmbTenSanPham;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtMaXuat;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ColumnHeader name_product;
        private System.Windows.Forms.ColumnHeader soluong;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroContextMenu ctmChinhSuaList;
        private System.Windows.Forms.ColumnHeader DonViTinh;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbNhaCungCap;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.ColumnHeader TenNCC;
        private System.Windows.Forms.ComboBox cmbUnit;
        private MetroFramework.Controls.MetroDateTime dtpNgayXuat;
    }
}