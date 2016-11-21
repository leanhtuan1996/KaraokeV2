namespace Karaoke_1.GUI
{
    partial class frmThongKeKho
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
            this.tabKho = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnNhapKho = new System.Windows.Forms.Button();
            this.lsvThongKe = new System.Windows.Forms.ListView();
            this.txtTongTienNhapKho = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgayNhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DVT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXem = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSoLuong = new System.Windows.Forms.Button();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.dtpNgay_To = new MetroFramework.Controls.MetroDateTime();
            this.cbbLoaiThongKe = new System.Windows.Forms.ComboBox();
            this.dtpNgay_From = new MetroFramework.Controls.MetroDateTime();
            this.MaPhieuXuat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaPhieuNhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenNCC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabKho.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabKho
            // 
            this.tabKho.Controls.Add(this.tabPage1);
            this.tabKho.Controls.Add(this.tabPage2);
            this.tabKho.Controls.Add(this.tabPage3);
            this.tabKho.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabKho.Location = new System.Drawing.Point(20, 234);
            this.tabKho.Name = "tabKho";
            this.tabKho.SelectedIndex = 0;
            this.tabKho.Size = new System.Drawing.Size(795, 356);
            this.tabKho.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.metroLabel4);
            this.tabPage1.Controls.Add(this.txtTongTienNhapKho);
            this.tabPage1.Controls.Add(this.lsvThongKe);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(787, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.Location = new System.Drawing.Point(24, 63);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(75, 23);
            this.btnNhapKho.TabIndex = 0;
            this.btnNhapKho.Text = "Nhập kho";
            this.btnNhapKho.UseVisualStyleBackColor = true;
            this.btnNhapKho.Click += new System.EventHandler(this.btnNhapKho_Click);
            // 
            // lsvThongKe
            // 
            this.lsvThongKe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.NgayNhap,
            this.MaPhieuNhap,
            this.TenSP,
            this.DVT,
            this.SoLuong,
            this.DonGia,
            this.TenNCC});
            this.lsvThongKe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvThongKe.FullRowSelect = true;
            this.lsvThongKe.GridLines = true;
            this.lsvThongKe.Location = new System.Drawing.Point(3, 73);
            this.lsvThongKe.Name = "lsvThongKe";
            this.lsvThongKe.Size = new System.Drawing.Size(781, 254);
            this.lsvThongKe.TabIndex = 56;
            this.lsvThongKe.UseCompatibleStateImageBehavior = false;
            this.lsvThongKe.View = System.Windows.Forms.View.Details;
            // 
            // txtTongTienNhapKho
            // 
            // 
            // 
            // 
            this.txtTongTienNhapKho.CustomButton.Image = null;
            this.txtTongTienNhapKho.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.txtTongTienNhapKho.CustomButton.Name = "";
            this.txtTongTienNhapKho.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTongTienNhapKho.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTongTienNhapKho.CustomButton.TabIndex = 1;
            this.txtTongTienNhapKho.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTongTienNhapKho.CustomButton.UseSelectable = true;
            this.txtTongTienNhapKho.CustomButton.Visible = false;
            this.txtTongTienNhapKho.Lines = new string[] {
        "0"};
            this.txtTongTienNhapKho.Location = new System.Drawing.Point(604, 34);
            this.txtTongTienNhapKho.MaxLength = 32767;
            this.txtTongTienNhapKho.Name = "txtTongTienNhapKho";
            this.txtTongTienNhapKho.PasswordChar = '\0';
            this.txtTongTienNhapKho.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTongTienNhapKho.SelectedText = "";
            this.txtTongTienNhapKho.SelectionLength = 0;
            this.txtTongTienNhapKho.SelectionStart = 0;
            this.txtTongTienNhapKho.ShortcutsEnabled = true;
            this.txtTongTienNhapKho.Size = new System.Drawing.Size(167, 23);
            this.txtTongTienNhapKho.TabIndex = 60;
            this.txtTongTienNhapKho.Text = "0";
            this.txtTongTienNhapKho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTongTienNhapKho.UseSelectable = true;
            this.txtTongTienNhapKho.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTongTienNhapKho.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(416, 38);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(125, 19);
            this.metroLabel4.TabIndex = 61;
            this.metroLabel4.Text = "Tổng tiền nhập kho:";
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 50;
            // 
            // NgayNhap
            // 
            this.NgayNhap.Text = "Ngày nhập";
            this.NgayNhap.Width = 100;
            // 
            // TenSP
            // 
            this.TenSP.Text = "Tên sản phẩm";
            this.TenSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TenSP.Width = 150;
            // 
            // DVT
            // 
            this.DVT.Text = "ĐVT";
            this.DVT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DVT.Width = 80;
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "Số lượng";
            this.SoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SoLuong.Width = 80;
            // 
            // DonGia
            // 
            this.DonGia.Text = "Đơn giá";
            this.DonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DonGia.Width = 107;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(283, 197);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(120, 31);
            this.btnXem.TabIndex = 60;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.MaPhieuXuat,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 73);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(781, 254);
            this.listView1.TabIndex = 67;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 47;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày xuất";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên sản phẩm";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ĐVT";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số lượng";
            this.columnHeader5.Width = 80;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(787, 330);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Xuất kho";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSoLuong
            // 
            this.btnSoLuong.Location = new System.Drawing.Point(208, 63);
            this.btnSoLuong.Name = "btnSoLuong";
            this.btnSoLuong.Size = new System.Drawing.Size(75, 23);
            this.btnSoLuong.TabIndex = 2;
            this.btnSoLuong.Text = "abc";
            this.btnSoLuong.UseVisualStyleBackColor = true;
            this.btnSoLuong.Click += new System.EventHandler(this.btnSoLuong_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(102, 134);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(27, 19);
            this.metroLabel5.TabIndex = 71;
            this.metroLabel5.Text = "Từ:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(329, 134);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(35, 19);
            this.metroLabel6.TabIndex = 72;
            this.metroLabel6.Text = "Đến:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(23, 96);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(123, 19);
            this.metroLabel7.TabIndex = 70;
            this.metroLabel7.Text = "Chọn loại thống kê:";
            // 
            // dtpNgay_To
            // 
            this.dtpNgay_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay_To.Location = new System.Drawing.Point(379, 134);
            this.dtpNgay_To.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpNgay_To.Name = "dtpNgay_To";
            this.dtpNgay_To.Size = new System.Drawing.Size(120, 29);
            this.dtpNgay_To.TabIndex = 68;
            // 
            // cbbLoaiThongKe
            // 
            this.cbbLoaiThongKe.FormattingEnabled = true;
            this.cbbLoaiThongKe.Location = new System.Drawing.Point(163, 96);
            this.cbbLoaiThongKe.Name = "cbbLoaiThongKe";
            this.cbbLoaiThongKe.Size = new System.Drawing.Size(120, 21);
            this.cbbLoaiThongKe.TabIndex = 67;
            // 
            // dtpNgay_From
            // 
            this.dtpNgay_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay_From.Location = new System.Drawing.Point(163, 134);
            this.dtpNgay_From.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpNgay_From.Name = "dtpNgay_From";
            this.dtpNgay_From.Size = new System.Drawing.Size(120, 29);
            this.dtpNgay_From.TabIndex = 69;
            // 
            // MaPhieuXuat
            // 
            this.MaPhieuXuat.Text = "Mã phiếu xuất";
            this.MaPhieuXuat.Width = 80;
            // 
            // MaPhieuNhap
            // 
            this.MaPhieuNhap.Text = "Mã phiếu nhập";
            this.MaPhieuNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaPhieuNhap.Width = 90;
            // 
            // TenNCC
            // 
            this.TenNCC.Text = "Tên Nhà Cung Cấp";
            this.TenNCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TenNCC.Width = 120;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(3, 73);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(781, 254);
            this.listView2.TabIndex = 68;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "STT";
            this.columnHeader6.Width = 47;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tên dịch vụ";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Số lượng";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 80;
            // 
            // frmThongKeKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 610);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.dtpNgay_To);
            this.Controls.Add(this.cbbLoaiThongKe);
            this.Controls.Add(this.dtpNgay_From);
            this.Controls.Add(this.btnSoLuong);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNhapKho);
            this.Controls.Add(this.tabKho);
            this.Name = "frmThongKeKho";
            this.Text = "Thống kê kho";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.tabKho.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabKho;
        private System.Windows.Forms.TabPage tabPage1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtTongTienNhapKho;
        private System.Windows.Forms.ListView lsvThongKe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnNhapKho;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader NgayNhap;
        private System.Windows.Forms.ColumnHeader TenSP;
        private System.Windows.Forms.ColumnHeader DVT;
        private System.Windows.Forms.ColumnHeader SoLuong;
        private System.Windows.Forms.ColumnHeader DonGia;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSoLuong;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroDateTime dtpNgay_To;
        private System.Windows.Forms.ComboBox cbbLoaiThongKe;
        private MetroFramework.Controls.MetroDateTime dtpNgay_From;
        private System.Windows.Forms.ColumnHeader MaPhieuXuat;
        private System.Windows.Forms.ColumnHeader MaPhieuNhap;
        private System.Windows.Forms.ColumnHeader TenNCC;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;

    }
}