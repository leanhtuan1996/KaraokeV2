namespace Karaoke_1.GUI
{
    partial class frmThongKeThuChi
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
            this.tabThuChi = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lsvHoaDon = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GioVao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GioRa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TienDatCoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TienHat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TienDV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GiamGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhuThu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TongTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lsvCPK = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ngay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTipHoaDon = new System.Windows.Forms.ToolTip(this.components);
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.dtpNgay_To = new MetroFramework.Controls.MetroDateTime();
            this.cbbLoaiThongKe = new System.Windows.Forms.ComboBox();
            this.dtpNgay_From = new MetroFramework.Controls.MetroDateTime();
            this.btnCPK = new System.Windows.Forms.Button();
            this.btnLuongNV = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabThuChi.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabThuChi
            // 
            this.tabThuChi.Controls.Add(this.tabPage1);
            this.tabThuChi.Controls.Add(this.tabPage2);
            this.tabThuChi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabThuChi.Location = new System.Drawing.Point(20, 212);
            this.tabThuChi.Name = "tabThuChi";
            this.tabThuChi.SelectedIndex = 0;
            this.tabThuChi.Size = new System.Drawing.Size(1006, 272);
            this.tabThuChi.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lsvHoaDon);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(998, 246);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lsvHoaDon
            // 
            this.lsvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.MaHD,
            this.MaNV,
            this.MaPhong,
            this.GioVao,
            this.GioRa,
            this.TienDatCoc,
            this.TienHat,
            this.TienDV,
            this.GiamGia,
            this.PhuThu,
            this.TongTien});
            this.lsvHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvHoaDon.FullRowSelect = true;
            this.lsvHoaDon.GridLines = true;
            this.lsvHoaDon.Location = new System.Drawing.Point(3, 42);
            this.lsvHoaDon.Name = "lsvHoaDon";
            this.lsvHoaDon.Size = new System.Drawing.Size(992, 201);
            this.lsvHoaDon.TabIndex = 0;
            this.lsvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lsvHoaDon.View = System.Windows.Forms.View.Details;
            this.lsvHoaDon.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.lsvHoaDon_ItemMouseHover);
            this.lsvHoaDon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsvHoaDon_MouseClick);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 40;
            // 
            // MaHD
            // 
            this.MaHD.Text = "Mã HĐ";
            this.MaHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaHD.Width = 70;
            // 
            // MaNV
            // 
            this.MaNV.Text = "Mã NV";
            this.MaNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MaPhong
            // 
            this.MaPhong.Text = "Mã Phòng";
            this.MaPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaPhong.Width = 70;
            // 
            // GioVao
            // 
            this.GioVao.Text = "Giờ Vào";
            this.GioVao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GioVao.Width = 120;
            // 
            // GioRa
            // 
            this.GioRa.Text = "Giờ Ra";
            this.GioRa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GioRa.Width = 120;
            // 
            // TienDatCoc
            // 
            this.TienDatCoc.Text = "Tiền Đặt Cọc";
            this.TienDatCoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TienDatCoc.Width = 90;
            // 
            // TienHat
            // 
            this.TienHat.Text = "Tiền Hát";
            this.TienHat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TienHat.Width = 90;
            // 
            // TienDV
            // 
            this.TienDV.Text = "Tiền DV";
            this.TienDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TienDV.Width = 90;
            // 
            // GiamGia
            // 
            this.GiamGia.Text = "Giảm Giá";
            this.GiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GiamGia.Width = 80;
            // 
            // PhuThu
            // 
            this.PhuThu.Text = "Phụ Thu";
            this.PhuThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TongTien
            // 
            this.TongTien.Text = "Tổng Tiền";
            this.TongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TongTien.Width = 90;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lsvCPK);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(998, 246);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lsvCPK
            // 
            this.lsvCPK.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Ngay,
            this.Description,
            this.Price});
            this.lsvCPK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvCPK.FullRowSelect = true;
            this.lsvCPK.GridLines = true;
            this.lsvCPK.Location = new System.Drawing.Point(3, 42);
            this.lsvCPK.Name = "lsvCPK";
            this.lsvCPK.Size = new System.Drawing.Size(992, 201);
            this.lsvCPK.TabIndex = 1;
            this.lsvCPK.UseCompatibleStateImageBehavior = false;
            this.lsvCPK.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 40;
            // 
            // Ngay
            // 
            this.Ngay.Text = "Ngày";
            this.Ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ngay.Width = 130;
            // 
            // Description
            // 
            this.Description.Text = "Mô tả";
            this.Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Description.Width = 400;
            // 
            // Price
            // 
            this.Price.Text = "Giá Tiền";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Width = 120;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Location = new System.Drawing.Point(24, 21);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(102, 23);
            this.btnHoaDon.TabIndex = 1;
            this.btnHoaDon.Text = "Hóa Đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(101, 118);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(27, 19);
            this.metroLabel5.TabIndex = 78;
            this.metroLabel5.Text = "Từ:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(328, 118);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(35, 19);
            this.metroLabel6.TabIndex = 79;
            this.metroLabel6.Text = "Đến:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(22, 80);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(123, 19);
            this.metroLabel7.TabIndex = 77;
            this.metroLabel7.Text = "Chọn loại thống kê:";
            // 
            // dtpNgay_To
            // 
            this.dtpNgay_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay_To.Location = new System.Drawing.Point(383, 118);
            this.dtpNgay_To.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpNgay_To.Name = "dtpNgay_To";
            this.dtpNgay_To.Size = new System.Drawing.Size(120, 29);
            this.dtpNgay_To.TabIndex = 75;
            // 
            // cbbLoaiThongKe
            // 
            this.cbbLoaiThongKe.FormattingEnabled = true;
            this.cbbLoaiThongKe.Location = new System.Drawing.Point(162, 80);
            this.cbbLoaiThongKe.Name = "cbbLoaiThongKe";
            this.cbbLoaiThongKe.Size = new System.Drawing.Size(120, 21);
            this.cbbLoaiThongKe.TabIndex = 74;
            // 
            // dtpNgay_From
            // 
            this.dtpNgay_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay_From.Location = new System.Drawing.Point(162, 118);
            this.dtpNgay_From.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpNgay_From.Name = "dtpNgay_From";
            this.dtpNgay_From.Size = new System.Drawing.Size(120, 29);
            this.dtpNgay_From.TabIndex = 76;
            // 
            // btnCPK
            // 
            this.btnCPK.Location = new System.Drawing.Point(132, 21);
            this.btnCPK.Name = "btnCPK";
            this.btnCPK.Size = new System.Drawing.Size(98, 23);
            this.btnCPK.TabIndex = 80;
            this.btnCPK.Text = "Chi Phí Khác";
            this.btnCPK.UseVisualStyleBackColor = true;
            this.btnCPK.Click += new System.EventHandler(this.btnCPK_Click);
            // 
            // btnLuongNV
            // 
            this.btnLuongNV.Location = new System.Drawing.Point(247, 21);
            this.btnLuongNV.Name = "btnLuongNV";
            this.btnLuongNV.Size = new System.Drawing.Size(98, 23);
            this.btnLuongNV.TabIndex = 81;
            this.btnLuongNV.Text = "Lương NV";
            this.btnLuongNV.UseVisualStyleBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(20, 212);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(999, 19);
            this.metroLabel1.TabIndex = 82;
            this.metroLabel1.Text = "XEM CHI TIẾT HÓA ĐƠN";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmThongKeThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 504);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnLuongNV);
            this.Controls.Add(this.btnCPK);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.dtpNgay_To);
            this.Controls.Add(this.cbbLoaiThongKe);
            this.Controls.Add(this.dtpNgay_From);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.tabThuChi);
            this.Name = "frmThongKeThuChi";
            this.Load += new System.EventHandler(this.ThongKeThuChi_Load);
            this.tabThuChi.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabThuChi;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lsvHoaDon;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader MaHD;
        private System.Windows.Forms.ColumnHeader MaNV;
        private System.Windows.Forms.ColumnHeader MaPhong;
        private System.Windows.Forms.ColumnHeader GioVao;
        private System.Windows.Forms.ColumnHeader GioRa;
        private System.Windows.Forms.ColumnHeader TienDatCoc;
        private System.Windows.Forms.ColumnHeader TienHat;
        private System.Windows.Forms.ColumnHeader TienDV;
        private System.Windows.Forms.ColumnHeader GiamGia;
        private System.Windows.Forms.ColumnHeader PhuThu;
        private System.Windows.Forms.ColumnHeader TongTien;
        private System.Windows.Forms.ToolTip toolTipHoaDon;
        private System.Windows.Forms.Button btnHoaDon;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroDateTime dtpNgay_To;
        private System.Windows.Forms.ComboBox cbbLoaiThongKe;
        private MetroFramework.Controls.MetroDateTime dtpNgay_From;
        private System.Windows.Forms.ListView lsvCPK;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Ngay;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Button btnCPK;
        private System.Windows.Forms.Button btnLuongNV;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}