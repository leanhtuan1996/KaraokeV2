using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using HPTCMessageBox;
using HPTCNotification;

using Karaoke_1.DAO;
using Karaoke_1.DTO;
using Karaoke_1.BUS;
using System.Data.SqlClient;
using System.Globalization;
using DTORoom;

namespace Karaoke_1.GUI
{
    public partial class MainRooms : MetroForm
    {
        #region Constructor
        public MainRooms()
        {
            InitializeComponent();
            MSBox.BackgroundColor = Color.WhiteSmoke; // Màu nền
            MSBox.OutlineColor = Color.Tomato; // Viền
            MSBox.TextColor = Color.Black; // Màu chữ

        }
        #endregion

        #region Global variable

        public static List<DTO_Room> lstRoom;

        public static List<DTO_KhachHang> lstCustomer;

        static List<DTO_RoomColor> lstRoomcolor;

        public static List<Button> lstButton;

        public static ListViewItem lsvItemBILL;

        public static List<DTO_RoomType> lstRoomtype;

        public static List<DTO_Product> LstProducts;

        string screenWidth;
        string screenHeight;

        int flag = 0;
        #endregion

        #region Event Form Main

        private void MainRooms_Load(object sender, EventArgs e)
        {
            screenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();
            screenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();
            screenWidth = "1366";
            screenHeight = "768";
            this.Size = new Size(int.Parse(screenWidth), int.Parse(screenHeight));
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.Resizable = false;
            this.Movable = false;
            if (screenWidth == "1366" && screenHeight == "768")
            {
                int sWidthButton = 140;
                int SHeightButton = 90;
                tabPhongHat.Size = new Size(1220, 700);
                tabPhongHat.Location = new Point(148, 29);
                btnDatetime.Size = new Size(1245, 23);
                lstPhong.Size = new Size(869, 700);
                lblTitle.Location = new Point(600, 27);
                grbThongTinPhong.Location = new Point(20, 6);
                grbThongTinPhong.Size = new System.Drawing.Size(309, 662);
                grbxSearchRoom.Location = new Point(29, 6);
                grbxGhiChu.Location = new Point(40, 290);
                btnPhong.Size = new Size(sWidthButton, SHeightButton);
                btnPhong.Location = new Point(9, 30);

                btnKho.Size = new Size(sWidthButton, SHeightButton);
                btnKho.Location = new Point(9, 130);

                btnMenu.Size = new Size(sWidthButton, SHeightButton);
                btnMenu.Location = new Point(9, 230);

                btnNhanSu.Size = new Size(sWidthButton, SHeightButton);
                btnNhanSu.Location = new Point(9, 330);

                btnThongKe.Size = new Size(sWidthButton, SHeightButton);
                btnThongKe.Location = new Point(9, 430);

                btnSetting.Size = new Size(sWidthButton, SHeightButton);
                btnSetting.Location = new Point(9, 530);

                btnLogOut.Size = new Size(sWidthButton, SHeightButton);
                btnLogOut.Location = new Point(9, 630);
                //9, 132

                //Resize KHO
                grbChucNang_QLKho.Location = new Point(999, 13);
                grbChucNang_QLKho.Size = new Size(166, 630);
                grbChiTiet_QLKho.Size = new Size(950, 630);
                dgvKho.Columns[0].Width = 150;
                dgvKho.Columns[1].Width = 250;
                dgvKho.Columns[2].Width = 150;
                dgvKho.Columns[3].Width = 265;

            }
            lstButton = new List<Button>();
            lstRoom = new List<DTO_Room>();
            lstRoomcolor = new List<DTO_RoomColor>();
            lstCustomer = new List<DTO_KhachHang>();
            lstRoomtype = new List<DTO_RoomType>();
            LstProducts = new List<DTO_Product>();
            ReloadColor();
            ReloadRoom();
            grbThongTinDatPhong.Visible = false;
            grbThongTinPhong.Visible = false;
            rdbCoKhu.Checked = true;
            txtTongTienDV.Text = "0";
            btnDatetime.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm");
            //  BUS_Room.Instance.LoadInfoCustomer(lstCustomer);
        }

        private void MainRooms_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            MSBox ms = new MSBox("Thông báo", "Bạn có muốn thoát không?", "Hủy bỏ;Chấp nhận", MSBox.MSBoxIcon.Question);
            DialogResult result = ms.ShowOnScreen();
            if (result != DialogResult.Cancel) return;
            e.Cancel = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            btnDatetime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
            //Hủy đơn đặt phòng sau 30p sau khi bắt đầu thời gian checkin
            if (lstCustomer == null) return;

            foreach (var item in lstCustomer)
            {

                double thoigian = DateTime.Parse(btnDatetime.Text).Subtract(DateTime.Parse(item.TimeCheckin.ToString(CultureInfo.InvariantCulture))).TotalMinutes;

                MessageBox.Show(thoigian.ToString());

                if (Math.Abs(thoigian) == 20)
                {
                    string noti = "Phòng " + item.IdRoom + " sẽ tự động hủy đơn đặt sau 10 phút";
                    Notification nf = new Notification(noti, "Đóng", Notification.NotificationIcon.Infomation, false, 10);
                    nf.ShowOnScreen();
                }
                if (!(Math.Abs(thoigian) > 30)) continue;
                string id_room = item.IdRoom;
                var index = lstCustomer.FindIndex(a => a.IdRoom == id_room);
                lstCustomer.RemoveAt(index);
                foreach (var room in lstRoom.Where(a => a.Name == id_room))
                {
                    room.Status = 1;
                    room.Tiendatphong = 0;
                    break;
                }

                foreach (var button in lstButton.Where(a => a.Name == id_room))
                {
                    button.BackColor = btnPhongtrong_color.BackColor;
                    break;
                }
                BUS_Room.TuDongHuyDatPhong(id_room);
                string noti_huy = "Phòng " + item.IdRoom + " đã tự động hủy đơn đặt";
                Notification nf_huy = new Notification(noti_huy, "Đóng", Notification.NotificationIcon.Infomation, false, 10);
                nf_huy.ShowOnScreen();
                break;
            }

        }

        #endregion

        #region ToolTip
        private void SetToolTip(Button btn)
        {
            tooltipInfoRoom.SetToolTip(btn, "Mã Phòng: " + btn.Name);
            tooltipInfoRoom.Active = true;
            tooltipInfoRoom.IsBalloon = true;
            tooltipInfoRoom.ShowAlways = true;
            lstCustomer.Clear();
            BUS_Room.Instance.LoadInfoCustomer(lstCustomer);

            //int index_room = BUS_Room.Instance.GetIndex_ID(lstRoom, btn.Name);
            int index_room = lstRoom.FindIndex(item => item.Name == btn.Name);

            int index_customer = BUS_Room.Instance.GetIndexCustomer_ID(lstCustomer, btn.Name);
            // int index_customer = lstCustomer.FindIndex(item => item.NameCustomer == btn.Name);
            int status = lstRoom[index_room].Status;

            switch (status)
            {
                case 1:
                    tooltipInfoRoom.SetToolTip(btn, tooltipInfoRoom.GetToolTip(btn) + "\nPhòng trống" + "\nLoại phòng: " + ((lstRoom[index_room].Type == 0) ? "Thường" : "VIP") + "\nSức chứa: " + lstRoom[index_room].Amount);
                    break;
                case 2:
                    tooltipInfoRoom.SetToolTip(btn, tooltipInfoRoom.GetToolTip(btn) + "\nPhòng đang sử dụng" + "\nLoại phòng: " + ((lstRoom[index_room].Type == 0) ? "Thường" : "VIP") + "\nGiờ vào: " + lstRoom[index_room].StartTime);
                    break;
                case 3:
                    tooltipInfoRoom.SetToolTip(btn, tooltipInfoRoom.GetToolTip(btn) + "\nPhòng đã đặt" + "\nTên khách: " + lstCustomer[index_customer].NameCustomer + "\nSĐT: " + lstCustomer[index_customer].PhoneNumber + "\nGiờ đặt: " + lstCustomer[index_customer].TimeCheckin);
                    break;
            }
        }
        #endregion

        #region ToolStripMenuItem

        static void EditMainMenuToolTrip(ContextMenuStrip menu, int status = 0)
        {
            ToolStripMenuItem mnuChonPhong = menu.Items[1] as ToolStripMenuItem;
            ToolStripMenuItem mnuDatPhong = menu.Items[0] as ToolStripMenuItem;
            ToolStripMenuItem mnuChuyenPhong = menu.Items[3] as ToolStripMenuItem;
            ToolStripMenuItem mnuTinhTien = menu.Items[2] as ToolStripMenuItem;

            mnuChonPhong.Visible = true;
            mnuChuyenPhong.Visible = true;
            mnuDatPhong.Visible = true;
            mnuTinhTien.Visible = true;


            if (status == 1)
            {
                mnuTinhTien.Visible = false;
                mnuChuyenPhong.Visible = false;
            }
            else if (status == 2)
            {
                mnuChonPhong.Visible = false;
                mnuDatPhong.Visible = false;
            }
            else if (status == 3)
            {
                mnuChuyenPhong.Visible = false;
                mnuTinhTien.Visible = false;
                mnuDatPhong.Visible = false;
            }

        }
        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTenKhachhang.Text = "";
            txtSDTKhachHang.Text = "";
            txtTienDatCoc.Text = "";
            btnDatPhong.Text = "Đặt phòng";
            btnHuy.Text = "Hủy";
            grbxSearchRoom.Visible = false;
            grbThongTinDatPhong.Visible = true;

            Control ct = MainMenuToolTrip.SourceControl;
            txtTenPhong.Text = ct.Name;
            txtThoiGianVao.Value = DateTime.Now;

        }

        private void chọnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control ct = MainMenuToolTrip.SourceControl;

            foreach (var item in lstRoom.Where(item => item.Name == ct.Name))
            {
                item.Status = 2;
                item.StartTime = DateTime.Now;
                ct.BackColor = btnPhongdangsudung_color.BackColor;
            }
            if (txtTienDatCoc.Text == "")
            {
                txtTienDatCoc.Text = "0";
            }

            BUS_Room.Instance.ChonPhong(ct.Name, int.Parse(txtTienDatCoc.Text));

            foreach (var item in lstRoom.Where(id_room => id_room.Name == ct.Name))
            {
                item.Status = 2;
                item.Tiendatphong = int.Parse(txtTienDatCoc.Text);
            }

            BUS_Room.Instance.GetStatus_ID(ct.Name);

            SetToolTip((Button)ct);

            grbThongTinDatPhong.Visible = false;
            grbxSearchRoom.Visible = true;

            foreach (var item in lstButton.Where(button => button.Name == ct.Name))
            {
                item.BackColor = btnPhongdangsudung_color.BackColor;
            }
            //ReloadRoom();
            //rdbCoKhu_CheckedChanged(sender, e);

        }

        private void tínhTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtpThoiGianRa.ResetText();
            dtpThoiGianVao.ResetText();
            dtpThoiGianRa.Value = DateTime.Now;
            grbThongTinPhong.Visible = true;
            grbxSearchRoom.Visible = false;

            Control ct = MainMenuToolTrip.SourceControl;
            string id_room = ct.Name;

            TinhTien(id_room);
        }

        private void chuyểnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tooltipInfoRoom.RemoveAll();

            Control control = MainMenuToolTrip.SourceControl;

            ChuyenPhong cn = new ChuyenPhong();

            ChuyenPhong.Nameroom = control.Name;

            cn.ShowDialog();


            //ReloadColor();
            // ReloadRoom();

            //rdbCoKhu.Checked = true;
            //rdbCoKhu_CheckedChanged(sender, e);

        }

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstTenDichVu.Items.Count <= 0) return;
            int idx = lstTenDichVu.Items.IndexOf(lstTenDichVu.SelectedItems[0]);
            if (idx < 0) return;
            ThemSuaDichVu sua = new ThemSuaDichVu();
            ThemSuaDichVu.Check = false;
            ThemSuaDichVu.Names = lstTenDichVu.Items[idx].SubItems[0].Text;
            ThemSuaDichVu.Unit = lstTenDichVu.Items[idx].SubItems[1].Text;
            ThemSuaDichVu.Price = int.Parse(lstTenDichVu.Items[idx].SubItems[2].Text);
            ThemSuaDichVu.Description = lstTenDichVu.Items[idx].SubItems[3].Text;
            sua.Text = "Sửa dịch vụ";
            sua.TextAlign = MetroFormTextAlign.Center;
            sua.ShowDialog();

            Menu_Click(sender, e);
        }

        private void xoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idx = lstTenDichVu.Items.IndexOf(lstTenDichVu.SelectedItems[0]);
            if (BUS_Menu.Instance.sp_XoaDichVu(lstTenDichVu.Items[idx].SubItems[0].Text) != 0)
            {
                MessageBox.Show("Xóa thành công");
                lstTenDichVu.Items.RemoveAt(idx);
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void chỉnhSửaToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            int idx = lsvChiTietDV_BILL.Items.IndexOf(lsvChiTietDV_BILL.SelectedItems[0]);

            //THÊM
            lsvChiTietDV_BILL.Items.RemoveAt(idx);

            int tongtiendv = 0;
            if (lsvChiTietDV_BILL.Items.Count > 0)
            {
                tongtiendv += lsvChiTietDV_BILL.Items.Cast<ListViewItem>().Sum(item => int.Parse(item.SubItems[1].Text) * int.Parse(item.SubItems[2].Text));

                //foreach (ListViewItem item in lsvChiTietDV_BILL.Items)
                //{
                //    tongtiendv += int.Parse(item.SubItems[1].Text) * int.Parse(item.SubItems[2].Text);
                //}

            }
            txtTongTienDV.Text = tongtiendv.ToString();
            txtTongTien.Text = (tongtiendv + int.Parse(txtTongTienGio.Text)).ToString();
        }

        #endregion

        #region PHÒNG
        #region Tìm kiếm phòng
        int roomhientai = 0;
        private int flag_animation = 0;

        private async void btnTimKiem_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(txtSucChua.Text) == true)
            {
                txtSucChua.Text = "0";
            }


            int i;
            if (cmbLoaiPhong.SelectedIndex != flag)
            {
                roomhientai = 0;
                flag = cmbLoaiPhong.SelectedIndex;
            }
            i = roomhientai;
            int flag_available = 0;
            for (i = roomhientai; i < lstButton.Count; i++)
            {
                //Xoa cai sai di
                if (lstRoom[i].Status == 1 && lstRoom[i].Type == flag && lstRoom[i].Amount >= int.Parse(txtSucChua.Text))
                {
                    CreateAnimation(lstButton[i]);
                    roomhientai = i + 1;
                    flag_available = 1;
                    break;
                }
            }

            //Nếu chạy tới cuối danh sách rồi thì resset để chạy lại từ đầu
            if (flag_available == 0)
            {
                roomhientai = 0;
            }
        }

        private async void btnTimKiemTatCa_Click(object sender, EventArgs e)
        {
            int timedelay = 500;

            if (String.IsNullOrEmpty(txtSucChua.Text) == true)
            {
                txtSucChua.Text = "0";
            }

            flag = cmbLoaiPhong.SelectedIndex;

            FontStyle ft = FontStyle.Regular;
            float size = 20;
            bool Timthayphong = false;
            for (int t = 0; t < 2; t++)
            {
                for (int i = 0; i < lstButton.Count; i++)
                {
                    if (lstRoom[i].Status == 1 && lstRoom[i].Type == flag && lstRoom[i].Amount >= int.Parse(txtSucChua.Text))
                    {
                        Button btn = lstButton[i];
                        ft = btn.Font.Style;
                        size = btn.Font.Size;
                        btn.Font = new Font(btn.Font.FontFamily, size + 4, FontStyle.Bold);
                        btn.BackColor = Color.YellowGreen;
                        Timthayphong = true;
                    }
                }
                if (Timthayphong == false)
                {
                    return;
                }
                await Task.Delay(timedelay);

                for (int i = 0; i < lstButton.Count; i++)
                {
                    if (lstRoom[i].Status == 1 && lstRoom[i].Type == flag && lstRoom[i].Amount >= int.Parse(txtSucChua.Text))
                    {
                        Button btn = lstButton[i];
                        btn.Font = new Font(btn.Font.FontFamily, size, ft);
                        btn.BackColor = btnPhongtrong_color.BackColor;
                    }
                }
                await Task.Delay(timedelay);
            }
        }

        #endregion

        #region Create Room & Border & Layer & CreateAnimation
        private void CreateBorder(int x, int y)
        {
            Label lbl = new Label
            {
                Location = new Point(x, y),
                AutoSize = false,
                BackColor = Color.Black,
                Height = 5,
                Width = panel2.Width - 30
            };
            panel2.Controls.Add(lbl);
        }

        private void CreateLayer(string name, int x, int y)
        {
            Label lbl = new Label();
            lbl.Text = name;
            lbl.Location = new Point(x, y);
            lbl.Font = new Font(lbl.Font.FontFamily, 12f, FontStyle.Bold);
            lbl.Width = 64;
            lbl.Height = 20;

            panel2.Controls.Add(lbl);
        }

        private void CreateRoom(string name, int x, int y, int status, int type)
        {
            Button btn = new Button { Location = new Point(x, y), Name = name, Size = new Size(115, 80), Text = name };
            btn.Font = new Font("Times New Roman", btn.Font.Size);
            if (type == 0)
            {
                btn.Font = new Font(btn.Font.FontFamily, 18f, FontStyle.Regular);
            }
            else
            {
                btn.Font = new Font(btn.Font.FontFamily, 18f, FontStyle.Underline);
            }

            btn.BackColor = Color.FromArgb(lstRoomcolor[status - 1].CodeColor);
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.MouseMove += btn_MouseMove;
            btn.MouseDown += btn_MouseDown;
            btn.MouseLeave += btn_MouseLeave;
            btn.Click += btn_Click;

            if (status == 4)
            {
                btn.Enabled = false;
            }

            lstButton.Add(btn);
            panel2.Controls.Add(btn);

        }

        private static async void CreateAnimation(Button btn)
        {
            btn.Focus();
            int timedelay = 200;
            float size = btn.Font.Size;
            int mau = btn.BackColor.ToArgb();
            FontStyle ft = btn.Font.Style;
            btn.Font = new Font(btn.Font.FontFamily, size + 4, FontStyle.Bold);
            btn.BackColor = Color.YellowGreen;
            await Task.Delay(timedelay);
            btn.Font = new Font(btn.Font.FontFamily, size, ft);
            btn.BackColor = Color.FromArgb(mau);
            await Task.Delay(timedelay);
            btn.Font = new Font(btn.Font.FontFamily, size + 4, FontStyle.Bold);
            btn.BackColor = Color.YellowGreen;
            await Task.Delay(timedelay);
            btn.Font = new Font(btn.Font.FontFamily, size, ft);
            btn.BackColor = Color.FromArgb(mau);
        }



        private void rdbCoKhu_CheckedChanged(object sender, EventArgs e)
        {
            //cmbKhu.Enabled = true;
            panel2.Controls.Clear();
            lstButton.Clear();
            if (lstRoom.Count == 0)
            {
                return;
            }

            int x = 15;
            int sophongtren1dong = 5;
            if (screenWidth == "1366" && screenHeight == "768")
            {
                x = 5;
                sophongtren1dong = 7;
            }

            int y = 20;

            //Tọa độ LBL KHU
            int lblLayerX = panel2.Width - 100;
            int lblLayerY = 5;

            //Tọa độ 2 cạnh biên trên dưới
            int lblBorderX = 3;
            int lblBorderYTop = 28;
            int lblBorderYBottom = 0;
            int hang = 5 + 60 + 2 * y;
            int dem = 0;
            string tang = lstRoom[0].Name[1].ToString();
            for (int i = 0; i < lstRoom.Count; i++)
            {
                string tang_toi = lstRoom[i].Name[1].ToString();
                if (string.Compare(tang_toi, tang) > 0)
                {
                    lblBorderYBottom = lblBorderYTop + (y) + hang - 10;
                    CreateBorder(lblBorderX, lblBorderYBottom);
                    lblLayerY = lblBorderYBottom + 22;
                    lblBorderYTop = lblBorderYBottom + 47;

                    dem = 0;
                    y = 20;
                    tang = tang_toi;
                }
                if (dem == 0)
                {
                    CreateLayer("Khu " + tang.ToString(), lblLayerX, lblLayerY);
                }


                CreateBorder(lblBorderX, lblBorderYTop);
                if (dem % sophongtren1dong == 0 && dem != 0)
                {
                    y += 85;
                }
                CreateRoom(lstRoom[i].Name, x + ((dem % sophongtren1dong) * 120), y + lblBorderYTop, lstRoom[i].Status, lstRoom[i].Type);
                dem++;
            }
            lblBorderYBottom = lblBorderYTop + (y) + hang - 10;
            CreateBorder(lblBorderX, lblBorderYBottom);
            if (screenWidth == "1366" && screenHeight == "768")
                CreateBorder(lblBorderX, lblBorderYBottom + 50);
        }
        private void rdbKhongKhu_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            lstButton.Clear();
            int x = 15;
            int y = 20;
            int sophongtren1dong = 5;
            if (screenWidth == "1366" && screenHeight == "768")
            {
                x = 5;
                sophongtren1dong = 7;
            }

            for (var i = 0; i < lstRoom.Count; i++)
            {
                if (i % sophongtren1dong == 0 && i != 0)
                {
                    y += 85;
                }
                CreateRoom(lstRoom[i].Name, x + ((i % sophongtren1dong) * 120), y, lstRoom[i].Status, lstRoom[i].Type);
            }
        }

        #endregion

        #region Event Button Room

        static void btn_Click(object sender, EventArgs e)
        {
        }

        void btn_MouseMove(object sender, MouseEventArgs e)
        {
            //tooltrip.Active = true;
            if (flag_animation == 1) return;
            Control ct = (Button)sender;
            SetToolTip((Button)ct);

            ct.Size = new Size(125, 90);
            ct.Location = new Point(ct.Location.X - 5, ct.Location.Y - 5);
            ct.Font = new Font(ct.Font.FontFamily, ct.Font.Size + 4, ct.Font.Style);
            flag_animation = 1;
        }

        void btn_MouseLeave(object sender, EventArgs e)
        {
            Control ct = (Button)sender;
            if (flag_animation == 1)
            {
                ct.Size = new System.Drawing.Size(115, 80);
                ct.Location = new Point(ct.Location.X + 5, ct.Location.Y + 5);
                ct.Font = new System.Drawing.Font(ct.Font.FontFamily, ct.Font.Size - 4, ct.Font.Style);
                flag_animation = 0;
            }
            tooltipInfoRoom.InitialDelay = 0;
            tooltipInfoRoom.IsBalloon = false;
        }

        void btn_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            string name = btn.Name;
            int status = BUS_Room.Instance.GetStatus_ID(name);

            if (name != txtTenPhong_TienTien.Text)
            {
                lsvChiTietDV_BILL.Items.Clear();
            }

            switch (e.Button)
            {
                case MouseButtons.Right:
                    tooltipInfoRoom.Active = false;
                    grbThongTinPhong.Visible = false;
                    grbxSearchRoom.Visible = true;
                    grbxGhiChu.Visible = true;
                    //tooltrip.Active = false;
                    //tooltrip.RemoveAll();
                    btn.ContextMenuStrip = MainMenuToolTrip;
                    EditMainMenuToolTrip(MainMenuToolTrip, status);
                    if (status == 3) //show thông tin đặt phòng
                    {
                        foreach (var item in lstCustomer.Where(item => item.IdRoom == btn.Name))
                        {
                            txtTienDatCoc.Text = item.Deposits.ToString();
                            txtTenKhachhang.Text = item.NameCustomer;
                            txtThoiGianVao.Text = item.TimeCheckin.ToString(CultureInfo.InvariantCulture);
                            txtSDTKhachHang.Text = item.PhoneNumber;
                            txtTenPhong.Text = item.IdRoom;
                        }

                        btnDatPhong.Text = "Chỉnh sửa";
                        btnHuy.Text = "Hủy đặt phòng";
                        grbThongTinDatPhong.Visible = true;
                        grbxSearchRoom.Visible = false;
                        grbThongTinPhong.Visible = false;
                    }
                    break;
                case MouseButtons.Left:
                    if (status == 2) //Tính tiền
                    {
                        tooltipInfoRoom.Active = true;
                        dtpThoiGianRa.ResetText();
                        dtpThoiGianVao.ResetText();
                        dtpThoiGianRa.Value = DateTime.Now;
                        grbThongTinPhong.Visible = true;
                        grbxSearchRoom.Visible = false;
                        TinhTien(name);

                        //-----------------------------------------------

                        txtPhuThu.Text = "";
                        txtLyDoPhuThu.Text = "";
                        txtTongTien.Text = "0";
                        txtTongTienDV.Text = "0";
                        txtGiamGia.Text = "0";

                        DateTime temp = dtpThoiGianVao.Value;
                        while (temp <= dtpThoiGianRa.Value)
                        {
                            SqlDataReader rd = BUS_HoaDon.Instance.GetDatePhuThu();
                            while (rd.Read())
                            {
                                if (temp.Date != Convert.ToDateTime(rd[0]).Date) continue;
                                txtPhuThu.Text += rd[1].ToString() + "%   ";
                                txtLyDoPhuThu.Text += rd[2].ToString() + "   ";
                            }
                            rd.Close();
                            DataProvider.Instance.ConnectionClose();
                            temp = temp.AddDays(1);
                        }

                        txtTongTien.Text = ((int.Parse(txtTongTienGio.Text) + int.Parse(txtTongTienDV.Text)) - int.Parse(txtTienDatPhong.Text)).ToString();
                    }
                    else if (status == 3) //show thông tin đặt phòng
                    {
                        foreach (var item in lstCustomer.Where(item => item.IdRoom == btn.Name))
                        {
                            txtTienDatCoc.Text = item.Deposits.ToString();
                            txtTenKhachhang.Text = item.NameCustomer;
                            txtThoiGianVao.Text = item.TimeCheckin.ToString(CultureInfo.InvariantCulture);
                            txtSDTKhachHang.Text = item.PhoneNumber;
                            txtTenPhong.Text = item.IdRoom;
                        }

                        btnDatPhong.Text = "Chỉnh sửa";
                        btnHuy.Text = "Hủy đặt phòng";
                        grbThongTinDatPhong.Visible = true;
                        grbxSearchRoom.Visible = false;
                        grbThongTinPhong.Visible = false;
                    }
                    else
                    {
                        grbThongTinDatPhong.Visible = false;
                        grbThongTinPhong.Visible = false;
                        grbxSearchRoom.Visible = true;
                        grbxGhiChu.Visible = true;

                    }
                    break;
                default:
                    tooltipInfoRoom.Active = true;
                    break;
            }
        }

        private void TinhTien(string name)
        {
            DateTime thoigianvao = DateTime.Now;

            int loaiphong = 1;

            foreach (DTO_Room room in lstRoom.Where(room => room.Name == name))
            {
                loaiphong = room.Type;

                thoigianvao = room.StartTime;

                txtTienDatPhong.Text = room.Tiendatphong.ToString();

                break;
            }

            txtTenPhong_TienTien.Text = name;
            txtLoaiphong_TinhTien.Text = cmbLoaiPhong.Items[loaiphong].ToString();

            dtpThoiGianVao.Value = Convert.ToDateTime(thoigianvao.ToString("yyyy-MM-dd HH:mm:ss"));

            DateTime VAO = DateTime.Parse(dtpThoiGianVao.Text);
            DateTime RA = DateTime.Parse(dtpThoiGianRa.Text);


            int tongthoigian = 0;

            double tien = 0;

            //tien = BUS_TinhTien.Instance.TinhTien2(phutvao, phutra, arr, loaiphong, ref tongthoigian);

            //tien = BUS_TinhTien.Instance.LamTron(tien);

            List<DTO_TienGio> arrTienGio = new List<DTO_TienGio>();
            tien = BUS_TinhTien.Instance.PhuThu(VAO, RA, loaiphong, ref tongthoigian, arrTienGio);

            //for (int i = 0; i < arr_TienGio.Count; i++ )
            //{
            //    MessageBox.Show(arr_TienGio[i].TIMESLOT + " - " + arr_TienGio[i].TIEN.ToString());
            //}

            txtTongThoiGian.Text = tongthoigian.ToString() + " phút";
            txtTongTienGio.Text = tien.ToString();
        }
        #endregion

        #region Reload Room & Color

        private void ReloadColor()
        {
            lstRoomcolor.Clear();

            BUS_Room.Instance.LoadColor(lstRoomcolor);

            btnPhongtrong_color.BackColor = Color.FromArgb(lstRoomcolor[0].CodeColor);
            btnPhongtrong_color.FlatStyle = FlatStyle.Flat;
            btnPhongtrong_color.FlatAppearance.BorderColor = Color.FromArgb(lstRoomcolor[0].CodeColor);
            btnPhongtrong_color.FlatAppearance.BorderSize = 0;
            btnPhongtrong_color.FlatAppearance.MouseDownBackColor = Color.FromArgb(lstRoomcolor[0].CodeColor);
            btnPhongtrong_color.FlatAppearance.MouseOverBackColor = Color.FromArgb(lstRoomcolor[0].CodeColor);

            btnPhongdangsudung_color.BackColor = Color.FromArgb(lstRoomcolor[1].CodeColor);
            btnPhongdangsudung_color.FlatStyle = FlatStyle.Flat;
            btnPhongdangsudung_color.FlatAppearance.BorderColor = Color.FromArgb(lstRoomcolor[1].CodeColor);
            btnPhongdangsudung_color.FlatAppearance.BorderSize = 0;
            btnPhongdangsudung_color.FlatAppearance.MouseDownBackColor = Color.FromArgb(lstRoomcolor[1].CodeColor);
            btnPhongdangsudung_color.FlatAppearance.MouseOverBackColor = Color.FromArgb(lstRoomcolor[1].CodeColor);

            btnPhongdadat_color.BackColor = Color.FromArgb(lstRoomcolor[2].CodeColor);
            btnPhongdadat_color.FlatStyle = FlatStyle.Flat;
            btnPhongdadat_color.FlatAppearance.BorderColor = Color.FromArgb(lstRoomcolor[2].CodeColor);
            btnPhongdadat_color.FlatAppearance.BorderSize = 0;
            btnPhongdadat_color.FlatAppearance.MouseDownBackColor = Color.FromArgb(lstRoomcolor[2].CodeColor);
            btnPhongdadat_color.FlatAppearance.MouseOverBackColor = Color.FromArgb(lstRoomcolor[2].CodeColor);

            btnPhongdangbaotri_color.BackColor = Color.FromArgb(lstRoomcolor[3].CodeColor);
            btnPhongdangbaotri_color.FlatStyle = FlatStyle.Flat;
            btnPhongdangbaotri_color.FlatAppearance.BorderColor = Color.FromArgb(lstRoomcolor[3].CodeColor);
            btnPhongdangbaotri_color.FlatAppearance.BorderSize = 0;
            btnPhongdangbaotri_color.FlatAppearance.MouseDownBackColor = Color.FromArgb(lstRoomcolor[3].CodeColor);
            btnPhongdangbaotri_color.FlatAppearance.MouseOverBackColor = Color.FromArgb(lstRoomcolor[3].CodeColor);
        }

        private void ReloadRoomType()
        {
            lstRoomtype.Clear();
            BUS_Room.Instance.LoadTypeRoom(lstRoomtype);
            if (lstRoomtype.Count == 0)
            {
                MSBox box = new MSBox("Thông Báo",
                    "Hiện tại chưa có dữ liệu của Loại Phòng. Mời bạn THÊM loại phòng để sử dụng các chức năng!",
                    "Đồng ý",
                    MSBox.MSBoxIcon.Infomation) { StartPosition = FormStartPosition.CenterScreen };

                box.ShowDialog();
            }
            else
            {
                cmbLoaiPhong.Items.Clear();
                for (int i = 0; i < lstRoomtype.Count; i++)
                {
                    cmbLoaiPhong.Items.Add(lstRoomtype[i].Decription);
                }
                cmbLoaiPhong.SelectedIndex = 0;
            }
        }
        private void ReloadRoom()
        {
            panel2.Controls.Clear();

            lstRoom.Clear();
            lstButton.Clear();

            ReloadRoomType();

            BUS_Room.Instance.LoadInFoRoom(lstRoom);

            if (lstRoom.Count == 0)
            {
                MSBox box = new MSBox("Thông Báo",
                    "Hiện tại chưa có dữ liệu của Phòng. Mời bạn THÊM phòng để sử dụng các chức năng!", "Đồng ý",
                    MSBox.MSBoxIcon.Infomation) { StartPosition = FormStartPosition.CenterScreen };

                box.ShowOnScreen();
                return;
            }

            BUS_Room.Instance.SapXepPhongTangDan(lstRoom);
        }

        #endregion
        private void btnPhong_Click(object sender, EventArgs e)
        {
            tabPhongHat.SelectedTab = tabPhongHat.TabPages[0];
            txtTongTienDV.Text = "0";
            lblTitle.Text = "QUẢN LÝ PHÒNG HÁT";
        }
        private void btnKho_Click(object sender, EventArgs e)
        {
            tabPhongHat.SelectedTab = tabPhongHat.TabPages[1];
            lblTitle.Text = "QUẢN LÝ KHO";

            //Clear list
            LstProducts.Clear();

            //Get KHO to datagridview
            DataTable dt = BUS_SanPham.Instance.GetInFoKho();
            dgvKho.DataSource = dt;

            //Load info product to List
            BUS_NhapXuatKho.Instance.GetInfoProduct(LstProducts);
        }
        private void txtSucChua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSucChua.Text.Length > 1)
            {
                e.Handled = true;
            }

            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            e.Handled = true;
            return;
        }
        private void txtSucChua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back || txtSucChua.Text.Length == 0) return;
            txtSucChua.Text = txtSucChua.Text.Remove(txtSucChua.Text.Length - 1);
            txtSucChua.Select(txtSucChua.Text.Length, 1);
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            string name_customer = txtTenKhachhang.Text;
            string sodienthoai = txtSDTKhachHang.Text;
            DateTime time_checkin = DateTime.Parse(txtThoiGianVao.Text);
            int tiendatcoc = int.Parse(txtTienDatCoc.Text);
            string id_room = txtTenPhong.Text;
            if (btnDatPhong.Text == "Chỉnh sửa")
            {
                if (BUS_Room.Instance.sp_ThayDoiDatPhong_ID(id_room, name_customer, sodienthoai, time_checkin,
                    tiendatcoc) != 0)
                {
                    MSBox ms = new MSBox("Thông báo", "Chỉnh sửa thành công", "Đồng ý", MSBox.MSBoxIcon.Infomation);
                    ms.ShowOnScreen();
                    //ReloadRoom();
                    //rdbCoKhu_CheckedChanged(sender, e);
                }
                else
                {
                    MSBox ms = new MSBox("Thông báo", "Chỉnh sửa thất bại", "Đồng ý", MSBox.MSBoxIcon.Infomation);
                    ms.ShowOnScreen();
                }
            }
            else
            {
                grbThongTinDatPhong.Visible = false;
                grbxSearchRoom.Visible = true;

                int checkdatphong = BUS_Room.Instance.DatPhong(txtTenPhong.Text, name_customer, sodienthoai, time_checkin, tiendatcoc);

                if (checkdatphong != 0)
                {
                    MSBox ms = new MSBox("Thông báo", "Đặt phòng thành công!", "Đồng ý", MSBox.MSBoxIcon.Infomation);
                    ms.ShowOnScreen();
                    //ReloadRoom();
                    //rdbCoKhu_CheckedChanged(sender, e);
                }
                else
                {
                    MSBox ms = new MSBox("Thông báo", "Đặt phòng thất bại", "Đồng ý", MSBox.MSBoxIcon.Infomation);
                    ms.ShowOnScreen();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (btnHuy.Text == "Hủy đặt phòng")
            {
                if (BUS_Room.sp_HuyDatPhong(txtTenPhong.Text) != 0)
                {
                    MSBox ms = new MSBox("Thông báo", "Hủy đặt phòng thành công!", "Đồng ý", MSBox.MSBoxIcon.Infomation);
                    ms.ShowOnScreen();

                    //ReloadRoom();
                    // rdbCoKhu_CheckedChanged(sender, e);
                }
                else
                {
                    MSBox ms = new MSBox("Thông báo", "Hủy đặt phòng thất bại", "Đồng ý", MSBox.MSBoxIcon.Infomation);
                    ms.ShowOnScreen();
                }
            }
            grbThongTinDatPhong.Visible = false;
            grbxSearchRoom.Visible = true;
        }

        private void txtTienDatCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            e.Handled = true;
            return;
        }

        private void txtTienDatCoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back || txtTienDatCoc.Text.Length == 0) return;
            txtTienDatCoc.Text = txtTienDatCoc.Text.Remove(txtTienDatCoc.Text.Length - 1);
            txtTienDatCoc.Select(txtTienDatCoc.Text.Length, 1);
        }

        private void btnHuyTinhTien_Click(object sender, EventArgs e)
        {
            grbxSearchRoom.Visible = true;
            grbxGhiChu.Visible = true;
            grbThongTinPhong.Visible = false;
        }

        #endregion

        #region KHO

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            NhapKho nk = new NhapKho();
            nk.ShowDialog();
            btnKho_Click(sender, e);
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            Them_SuaSanPham them = new Them_SuaSanPham();
            Them_SuaSanPham.check = true;
            them.Text = "Thêm sản phẩm";
            them.ShowDialog();
            btnKho_Click(sender,e);
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.ShowDialog();
            btnKho_Click(sender, e);
        }

        private void btnXuatKho_Click(object sender, EventArgs e)
        {
            XuatKho frmXuatKho = new XuatKho();
            frmXuatKho.ShowDialog();
            btnKho_Click(sender,e);
        }

        private void SuaSanPham_Click(object sender, EventArgs e)
        {
            Them_SuaSanPham them = new Them_SuaSanPham();
            Them_SuaSanPham.check = false;
            if (dgvKho.Rows.Count <= 0) return;
            if (dgvKho.CurrentRow != null)
            {
                Them_SuaSanPham.id_sp = dgvKho.CurrentRow.Cells["id"].Value.ToString();
                Them_SuaSanPham.name = dgvKho.CurrentRow.Cells["name_product"].Value.ToString();
                Them_SuaSanPham.unit = dgvKho.CurrentRow.Cells["unit"].Value.ToString();
                Them_SuaSanPham.index = dgvKho.CurrentRow.Cells["index"].Value.ToString();
            }
            them.Text = "Sửa sản phẩm";
            them.ShowDialog();
            btnKho_Click(sender, e);
        }

        private void XoaSanPham_Click(object sender, EventArgs e)
        {
            if (dgvKho.Rows.Count <= 0) return;
            if (dgvKho.CurrentRow == null) return;
            //Xóa sản phẩm thì lấy index của dòng đó rồi xóa => tránh đc xóa nhiều sản phẩm
            string id = dgvKho.CurrentRow.Cells["index"].Value.ToString();
            if (BUS_SanPham.Instance.XoaSanPham(id) != 0)
            {
                MessageBox.Show("Xóa thành công");
                btnKho_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        #endregion

        #region MENU
        private void Menu_Click(object sender, EventArgs e)
        {
            tabPhongHat.SelectedTab = tabPhongHat.TabPages[2];

            DataTable dt = BUS_Menu.Instance.sp_GetMenu();

            lstTenDichVu.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var dr = dt.Rows[i];
                var item = new ListViewItem(dr["name"].ToString());
                item.SubItems.Add(dr["unit"].ToString());
                item.SubItems.Add(dr["price"].ToString());
                item.SubItems.Add(dr["description"].ToString());
                lstTenDichVu.Items.Add(item);
            }
        }
        private void lstTenDichVu_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            if (lstTenDichVu.FocusedItem.Bounds.Contains(e.Location) == true)
            {
                cmtXoaList.Show(Cursor.Position);
            }
        }

        private void btnThemDichVu_Menu_Click(object sender, EventArgs e)
        {
            ThemSuaDichVu them = new ThemSuaDichVu();
            ThemSuaDichVu.Check = true;
            them.Name = "Thêm dịch vụ";
            them.TextAlign = MetroFormTextAlign.Center;
            them.ShowDialog();
            Menu_Click(sender, e);
        }

        #endregion

        #region NHÂN SỰ
        private void btnNhanSu_Click(object sender, EventArgs e)
        {
            tabPhongHat.SelectedTab = tabPhongHat.TabPages[3];
        }
        #endregion

        #region THỐNG KÊ
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            tabPhongHat.SelectedTab = tabPhongHat.TabPages[4];

            cbbLoaiThongKe.Items.Clear();
            cbbLoaiThongKe.Items.Add("Theo ngày");
            cbbLoaiThongKe.Items.Add("Theo tháng");
            cbbLoaiThongKe.Items.Add("Theo năm");

            cbbLoaiThongKe.SelectedIndex = 0;

        }
        #endregion

        #region THIẾT LẬP
        private void btnSetting_Click(object sender, EventArgs e)
        {
            CreateRooms cr = new CreateRooms();
            cr.ShowDialog();
            ReloadColor();
            ReloadRoom();

            rdbCoKhu.Checked = true;
            rdbCoKhu_CheckedChanged(sender, e);
            // tabControl1.SelectedTab = tabControl1.TabPages[5];
        }
        #endregion

        #region ĐĂNG XUẤT
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Restart();
        }
        #endregion

        #region BILL

        public static bool CHECK_HUY = false;

        private void btnThemDichVu_TinhTien_Click(object sender, EventArgs e)
        {
            Them_SuaDichVu_BILL dv = new Them_SuaDichVu_BILL();

            dv.ShowDialog();
            if (CHECK_HUY != true)
            {
                lsvChiTietDV_BILL.Items.Add(lsvItemBILL);

                //THÊM
                txtTongTien.Text = (int.Parse(txtTongTien.Text) + int.Parse(lsvItemBILL.SubItems[1].Text) * int.Parse(lsvItemBILL.SubItems[2].Text)).ToString();
            }
            int tongtiendv = 0;

            if (lsvChiTietDV_BILL.Items.Count > 0)
            {
                //tongtiendv += lsvChiTietDV_BILL.Items.Cast<ListViewItem>().Sum(item => int.Parse(item.SubItems[1].Text)*int.Parse(item.SubItems[2].Text));

                tongtiendv += lsvChiTietDV_BILL.Items.Cast<ListViewItem>().Sum(item => int.Parse(item.SubItems[1].Text) * int.Parse(item.SubItems[2].Text));

                //foreach (ListViewItem item in lsvChiTietDV_BILL.Items)
                //{
                //    tongtiendv += int.Parse(item.SubItems[1].Text) * int.Parse(item.SubItems[2].Text);

                //}
            }

            txtTongTienDV.Text = tongtiendv.ToString();

        }

        private void lsvChiTietDV_BILL_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            if (lsvChiTietDV_BILL.FocusedItem.Bounds.Contains(e.Location) == true)
            {
                cmtChinhSuaDV_BILL.Show(Cursor.Position);
            }
        }



        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            var mahoadon = MaHoaDon();

            int kq = BUS_HoaDon.Instance.Insert_Bill(mahoadon, DateTime.Now, txtTenPhong_TienTien.Text, "NV01", dtpThoiGianVao.Value, int.Parse(txtTongTienGio.Text), int.Parse(txtTongTienDV.Text), int.Parse(txtGiamGia.Text), txtPhuThu.Text, int.Parse(txtTongTien.Text));

            if (kq != 0)
            {
                MessageBox.Show("Thêm hóa đơn thành công");
                foreach (ListViewItem item in lsvChiTietDV_BILL.Items)
                {
                    BUS_HoaDon.Instance.Insert_BillDetail(mahoadon, item.SubItems[0].Text, int.Parse(item.SubItems[1].Text), int.Parse(item.SubItems[2].Text));
                }
                LapBill("PHIẾU THANH TOÁN");
                //ReloadColor();
                //ReloadRoom();
                foreach (var item in lstRoom.Where(a => a.Name == txtTenPhong_TienTien.Text))
                {
                    item.Status = 1;
                }

                //Đổi màu lại trong ListButton về trống
                foreach (var item in lstButton.Where(b => b.Name == txtTenPhong_TienTien.Text))
                {
                    item.BackColor = Color.FromArgb(-32576);
                }

                //rdbCoKhu_CheckedChanged(sender, e);
            }
            else
            {
                MessageBox.Show("Thao tác thất bại!");
            }
        }

        static string MaHoaDon()
        {
            string mahoadon = BUS_HoaDon.Instance.GetMaHoaDon();


            mahoadon = mahoadon ?? "HD0";
            //mahoadon = mahoadon == null ? "HD0" : mahoadon;

            int number = int.Parse(mahoadon.Substring(2));

            number += 1;

            mahoadon = "HD" + number.ToString();

            return mahoadon;
        }

        private void btnTamTinh_Click(object sender, EventArgs e)
        {
            LapBill("PHIẾU TẠM TÍNH");
        }

        private void LapBill(string name)
        {
            var dt = new DataTable();

            dt.Columns.Add("TenDichVu", typeof(string));
            dt.Columns.Add("DonGia", typeof(string));
            dt.Columns.Add("SoLuong", typeof(string));
            dt.Columns.Add("ThanhTien", typeof(string));

            for (var i = 0; i < lsvChiTietDV_BILL.Items.Count; i++)
            {
                dt.Rows.Add(lsvChiTietDV_BILL.Items[i].SubItems[0].Text, lsvChiTietDV_BILL.Items[i].SubItems[1].Text,
                    lsvChiTietDV_BILL.Items[i].SubItems[2].Text, lsvChiTietDV_BILL.Items[i].SubItems[3].Text);
            }

            rptBill.RegisterData(dt, "FullView");
            rptBill.GetDataSource("FullView");

            rptBill.SetParameterValue(("PHIEU"), name);
            rptBill.SetParameterValue("NAME", "Karaoke Ninh Kiều");
            rptBill.SetParameterValue("ADDRESS", "54/2 Nguyễn Văn Cừ");
            rptBill.SetParameterValue("PHONENUMBER", "(777)-45119251");
            rptBill.SetParameterValue("WEBSITE", "www.karaokeninhkieu.vn");
            rptBill.SetParameterValue("PHONG", txtTenPhong_TienTien.Text);
            rptBill.SetParameterValue("TONGTIENDICHVU", txtTongTienDV.Text);
            rptBill.SetParameterValue("THOIGIANTHUEPHONG", txtTongThoiGian.Text);
            rptBill.SetParameterValue("GIOVAO", dtpThoiGianVao.Text);
            rptBill.SetParameterValue("GIORA", dtpThoiGianRa.Text);
            rptBill.SetParameterValue("NGAYLAPPHIEU", btnDatetime.Text);
            rptBill.SetParameterValue("IDNHANVIEN", "Tuấn");
            rptBill.SetParameterValue("TIENHAT", txtTongTienGio.Text);
            rptBill.SetParameterValue("GIAMGIA", txtGiamGia.Text);
            rptBill.SetParameterValue("TIENDATTRUOC", txtTienDatPhong.Text);
            rptBill.SetParameterValue("PHUTHU", txtPhuThu.Text);
            rptBill.SetParameterValue("LYDOPHUTHU", "Không có");
            rptBill.SetParameterValue("TONGTIEN", txtTongTien.Text);

            if (rptBill.Prepare())
            {
                rptBill.ShowPrepared();
            }
            dt.Dispose();
        }

        private void txtKhauTru_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtKhauTru_KeyUp(object sender, KeyEventArgs e)
        {
            //double tien = 0;
            //int discount = 0;

            //if (e.KeyCode != Keys.Back)
            //{
            //    txtTongTien.Text = BUS_TinhTien.Instance.LamTron(int.Parse(txtTongTien.Text) + tien).ToString();
            //    discount = discount > int.Parse(txtKhauTru.Text) ? discount - int.Parse(txtKhauTru.Text) : int.Parse(txtKhauTru.Text) - discount;
            //    tien = int.Parse(txtTongTien.Text) * (discount / 100.0);
            //    txtTongTien.Text = BUS_TinhTien.Instance.LamTron(int.Parse(txtTongTien.Text) - tien).ToString();
            //}

            //if (e.KeyCode == Keys.Back)
            //{
            //    txtTongTien.Text = BUS_TinhTien.Instance.LamTron(int.Parse(txtTongTien.Text) + tien).ToString();
            //}
            //else if (txtKhauTru.Text == "")
            //{

            //}


            //if(txtKhauTru.Text == "")
            //{

            //}

            //if(e.KeyCode != Keys.Back)
            //{
            //    int tien = int.Parse(txtTongTien.Text);
            //    txtTongTien.Text = (BUS_TinhTien.Instance.LamTron(tien - (tien * (int.Parse(txtKhauTru.Text) / 100.0)))).ToString();
            //}
            //else


        }
        #endregion

        private void lstTenDichVu_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            MessageBox.Show(e.Item.SubItems[0].Text);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if(dtpNgay_From.Value > dtpNgay_To.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!");
                return;
            }

            lsvDoanhThu.Items.Clear();

            if (dtpNgay_From.Value.Date > dtpNgay_To.Value.Date)
            {
                MessageBox.Show("Ngày không hợp lệ!");
                return;
            }

            txtTongThu.Text = "0";
            txtTongChi.Text = "0";
            txtLoiNhuan.Text = "0";

            DateTime date_temp;

            int index = cbbLoaiThongKe.SelectedIndex;

            int i = 0;
            while (true)
            {
                decimal nhapkho, hoadon, chiphikhac, luong;

                nhapkho = hoadon = chiphikhac = luong = 0;

                ListViewItem item = new ListViewItem((i + 1).ToString());

                if (index == 0)//ngày
                {
                    date_temp = dtpNgay_From.Value.AddDays(i);
                    BUS_DoanhThu.Instance.XemThongKe(cbbLoaiThongKe.SelectedIndex, date_temp, ref nhapkho, ref hoadon, ref chiphikhac, ref luong);
                    item.SubItems.Add(dtpNgay_From.Value.AddDays(i).ToShortDateString());
                }
                else if (index == 1)
                {
                    date_temp = dtpNgay_From.Value.AddMonths(i);
                    BUS_DoanhThu.Instance.XemThongKe(cbbLoaiThongKe.SelectedIndex, date_temp, ref nhapkho, ref hoadon, ref chiphikhac, ref luong);
                    item.SubItems.Add(date_temp.Month.ToString() + '/' + date_temp.Year.ToString());
                }
                else
                {
                    date_temp = dtpNgay_From.Value.AddYears(i);
                    BUS_DoanhThu.Instance.XemThongKe(cbbLoaiThongKe.SelectedIndex, date_temp, ref nhapkho, ref hoadon, ref chiphikhac, ref luong);
                    item.SubItems.Add(date_temp.Year.ToString());
                }





                item.SubItems.Add(String.Format("{0:0,0}", nhapkho));

                item.SubItems.Add(String.Format("{0:0,0}", chiphikhac));

                item.SubItems.Add(String.Format("{0:0,0}", luong));

                item.SubItems.Add(String.Format("{0:0,0}", hoadon));

                lsvDoanhThu.Items.Add(item);

                txtTongChi.Text = String.Format("{0:0,0}", (Convert.ToDecimal(txtTongChi.Text) + nhapkho + chiphikhac + luong));
                txtTongThu.Text = String.Format("{0:0,0}", (Convert.ToDecimal(txtTongThu.Text) + hoadon));

                if (Convert.ToDecimal(txtTongThu.Text) - Convert.ToDecimal(txtTongChi.Text) > 0)
                    txtLoiNhuan.Text = String.Format("{0:0,0}", (Convert.ToDecimal(txtTongThu.Text) - Convert.ToDecimal(txtTongChi.Text)));
                else
                    txtLoiNhuan.Text = "---";
                if (index == 0)
                {
                    if (dtpNgay_From.Value.AddDays(i).ToShortDateString() == dtpNgay_To.Value.ToShortDateString())
                        break;
                }
                else if (index == 1)
                {
                    if (date_temp.Month == dtpNgay_To.Value.Month && date_temp.Year == dtpNgay_To.Value.Year)
                        break;
                }
                else
                {
                    if (date_temp.Year == dtpNgay_To.Value.Year)
                        break;
                }

                i++;

            }

        }

        int column_idx = -1;
        private void lsvDoanhThu_MouseClick(object sender, MouseEventArgs e)
        {
            //if (e.Button != MouseButtons.Right)
            //    return;

            //if (lsvDoanhThu.FocusedItem.Bounds.Contains(e.Location) == true)
            //{

            //    Point mouse_position = lsvDoanhThu.PointToClient(Control.MousePosition);

            //    ListViewHitTestInfo info = lsvDoanhThu.HitTest(mouse_position);

            //    column_idx = info.Item.SubItems.IndexOf(info.SubItem);

            //    if (column_idx != 0 && column_idx != 1)
            //        cmtThongKe.Show(Cursor.Position);

            //}


            if (e.Button != MouseButtons.Right)
                return;

            if (lsvDoanhThu.FocusedItem.Bounds.Contains(e.Location) == true)
            {
                if (column_idx != 0 && column_idx != 1)
                    cmtThongKe.Show(Cursor.Position);
            }

        }

        private void xemChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int row = lsvDoanhThu.FocusedItem.Index;


            //if (column_idx == 2) //nhập kho
            //{
            //    //frmThongKeKho TKKho = new frmThongKeKho();
            //    //TKKho.Show();
            //}

            //else if(column_idx == 3) //chi phi khác
            //{
            //    frmThongKeThuChi.type_load = 3;
            //    frmThongKeThuChi.type = cbbLoaiThongKe.SelectedIndex;
            //    frmThongKeThuChi.ngayfrom = dtpNgay_From.Value;
            //    frmThongKeThuChi.ngayto = dtpNgay_To.Value;
            //    frmThongKeThuChi TKThuChi = new frmThongKeThuChi();
            //    TKThuChi.Show();
            //}

            //else if (column_idx == 5) //hóa đơn
            //{
            //    frmThongKeThuChi.type_load = 5;
            //    frmThongKeThuChi.type = cbbLoaiThongKe.SelectedIndex;
            //    frmThongKeThuChi.ngayfrom = dtpNgay_From.Value;
            //    frmThongKeThuChi.ngayto = dtpNgay_To.Value;
            //    frmThongKeThuChi TKThuChi = new frmThongKeThuChi();
            //    TKThuChi.Show();
            //}


            int row = lsvDoanhThu.FocusedItem.Index;

            frmThongKeThuChi.ngayfrom = dtpNgay_From.Value;
            frmThongKeThuChi.ngayto = dtpNgay_To.Value;
            frmThongKeThuChi.type = cbbLoaiThongKe.SelectedIndex;

            frmThongKeThuChi ThongKe = new frmThongKeThuChi();
            ThongKe.Show();

        }

        private void btnPhuThu_Click(object sender, EventArgs e)
        {
            frmPhuThu PhuThu = new frmPhuThu();
            PhuThu.Show();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dtpNgay_From.Value > dtpNgay_To.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!");
                return;
            }

            frmThongKeThuChi.ngayfrom = dtpNgay_From.Value;
            frmThongKeThuChi.ngayto = dtpNgay_To.Value;
            frmThongKeThuChi.type = cbbLoaiThongKe.SelectedIndex;

            frmThongKeThuChi ThongKe = new frmThongKeThuChi();
            ThongKe.Show();
        }


    }
}
