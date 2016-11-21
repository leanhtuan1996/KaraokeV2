using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using MetroFramework.Forms;
using MetroFramework;
using MetroFramework.Controls;
using Karaoke_1.BUS;
using Karaoke_1.GUI;

namespace Karaoke_1.GUI
{
    public partial class frmThongTinTaiKhoan : MetroForm
    {
        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
            Program.frm = this;
        }

        public void LOAD_Image()
        {
            // socket
        }

        private List<string[]> LIST = null;
        private List<string[]> List = null;
        private string[] Info = null;
        private List<string[]> List_position = new List<string[]>();

        public void Set_Location(int X)
        {
            ptbAnhDaiDien.Location = new Point(3,122);

            lblMaNV.Location = new Point(223, 111);
            lblFullName.Location = new Point(223 , 162);
            lblCmnd.Location = new Point(223 , 322);
            lblGioiTinh.Location = new Point(223 , 214);
            lblNgaySinh.Location = new Point(223 , 267);
            lblTrangThai.Location = new Point(223 , 377);

            lblTK.Location = new Point(486 + X, 111);
            lblMK.Location = new Point(486 + X, 162);
            lblNickName.Location = new Point(486 + X, 322);
            lblTinhTrangHonNhan.Location = new Point(486 + X, 267);
            lblChucVu.Location = new Point(486 + X, 214);
            lblSDT.Location = new Point(486 + X, 377);

            btnTaoMoi.Location = new Point(btnTaoMoi.Location.X+15+X,btnTaoMoi.Location.Y);
            btnChinhSua.Location = new Point(btnChinhSua.Location.X+15 + X, btnChinhSua.Location.Y);
            btnXoa.Location = new Point(btnXoa.Location.X+15 + X, btnXoa.Location.Y);
        }

        public void Show_lable(string[] str)
        {
            lblMaNV.Text = "Mã NV: " + str[1];
            lblTK.Text = "Tên TK: " + str[12];
            lblMK.Text = "Mật Khẩu: *****";
            lblFullName.Text = "Tên NV: " + str[2];
            lblGioiTinh.Text = "Giới Tính: " + str[5];
            lblNickName.Text = "Nick Name: " + str[3];
            lblNgaySinh.Text = "Ngày Sinh: " + str[4];
            lblTinhTrangHonNhan.Text = "Tình Trạng Hôn Nhân: " + str[6];
            lblCmnd.Text = "Cmnd: " + str[7];
            lblChucVu.Text = "Chức Vụ: " + str[11];
            lblTrangThai.Text = "Trạng Thái: " + str[9];
            lblSDT.Text = "Số Điện Thoại: " + str[10];
            Info = str;
        }
        public void LOAD_Info()
        {
            if (frmLogin.INDEX_User == 0)
            {
                lblMaNV.Text = "Mã NV: ";
                lblTK.Text = "Tên TK: ";
                lblMK.Text = "Mật Khẩu: *****";
                lblFullName.Text = "Tên NV: ";
                lblGioiTinh.Text = "Giới Tính: ";
                lblNickName.Text = "Nick Name: ";
                lblNgaySinh.Text = "Ngày Sinh: ";
                lblTinhTrangHonNhan.Text = "Tình Trạng Hôn Nhân: ";
                lblCmnd.Text = "Cmnd: ";
                lblChucVu.Text = "Chức Vụ: ";
                lblTrangThai.Text = "Trạng Thái: ";
                lblSDT.Text = "Số Điện Thoại: ";
            }
            else
            {
                Show_lable(BUS_qlnv.Instance.ARR);
            }
        }

        public void LOAD()
        {
            LIST = BUS_qlnv.Instance.Load_Info(frmLogin.INDEX_User);
            Set_Location(0);
            btnOpen.Visible = false;
            btnClose.Visible = true;
            panelView.Visible = true;
            cbbTimKiemTheo.Visible = true;
            txtTimKiem.Visible = false;
            btnTimKiem.Visible = false;
            cbbSelect.Visible = false;
            btnTimKiem.BackgroundImage = Properties.Resources.Search;
            btnTimKiem.BackgroundImageLayout = ImageLayout.Stretch;
            btnTaoMoi.Text = "Tạo mới";
            btnChinhSua.Text = "Chỉnh sửa";
            btnXoa.Text = "Xoá";

            #region Chọn Màu
            switch (frmLogin.FormStyle)
            {
                case 1:
                    {
                        this.Style = MetroColorStyle.Black;
                        metroTile1.Style = MetroColorStyle.Black;
                        break;
                    }
                case 2:
                    {
                        this.Style = MetroColorStyle.White;
                        metroTile1.Style = MetroColorStyle.White;
                        break;
                    }
                case 3:
                    {
                        this.Style = MetroColorStyle.Silver;
                        metroTile1.Style = MetroColorStyle.Silver;
                        break;
                    }
                case 4:
                    {
                        this.Style = MetroColorStyle.Blue;
                        metroTile1.Style = MetroColorStyle.Blue;
                        break;
                    }
                case 5:
                    {
                        this.Style = MetroColorStyle.Green;
                        metroTile1.Style = MetroColorStyle.Green;
                        break;
                    }
                case 6:
                    {
                        this.Style = MetroColorStyle.Lime;
                        metroTile1.Style = MetroColorStyle.Lime;
                        break;
                    }
                case 7:
                    {
                        this.Style = MetroColorStyle.Teal;
                        metroTile1.Style = MetroColorStyle.Teal;
                        break;
                    }
                case 8:
                    {
                        this.Style = MetroColorStyle.Orange;
                        metroTile1.Style = MetroColorStyle.Orange;
                        break;
                    }
                case 9:
                    {
                        this.Style = MetroColorStyle.Brown;
                        metroTile1.Style = MetroColorStyle.Brown;
                        break;
                    }
                case 10:
                    {
                        this.Style = MetroColorStyle.Pink;
                        metroTile1.Style = MetroColorStyle.Pink;
                        break;
                    }
                case 11:
                    {
                        this.Style = MetroColorStyle.Magenta;
                        metroTile1.Style = MetroColorStyle.Magenta;
                        break;
                    }
                case 12:
                    {
                        this.Style = MetroColorStyle.Purple;
                        metroTile1.Style = MetroColorStyle.Purple;
                        break;
                    }
                case 13:
                    {
                        this.Style = MetroColorStyle.Red;
                        metroTile1.Style = MetroColorStyle.Red;
                        break;
                    }
                case 14:
                    {
                        this.Style = MetroColorStyle.Yellow;
                        metroTile1.Style = MetroColorStyle.Yellow;
                        break;
                    }
            }
            #endregion
            LOAD_Image();
            LOAD_Info();
            List_position = BUS_qlnv.Instance.Load_Position();

            // load combobox
            cbbTimKiemTheo.Items.Add("Mã");
            cbbTimKiemTheo.Items.Add("Tên");
            cbbTimKiemTheo.Items.Add("Cmnd");
            cbbTimKiemTheo.Items.Add("Chức Vụ");
            cbbTimKiemTheo.Items.Add("Giới Tính");
            cbbTimKiemTheo.Items.Add("Số Điện Thoại");
        }

        
        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            LOAD();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Set_Location(-35);
            btnOpen.Visible = false;
            btnClose.Visible = true;
            panelView.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Set_Location(35);
            panelView.Visible = false;
            btnOpen.Visible = true;
            btnClose.Visible = false;
        }

        public void GetCombobox(List<string []> List)
        {
            foreach(string [] arr in List)
            {
                cbbSelect.Items.Add(arr[0]);
            }
        }

        private void cbbTimKiemTheo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Clear();
            txtTimKiem.Text = "";
            if (cbbTimKiemTheo.SelectedIndex == 3)
            {
                txtTimKiem.Visible = false;
                btnTimKiem.Visible = false;
                cbbSelect.Visible = true;

                cbbSelect.Items.Clear();
                cbbSelect.PromptText = "Chọn chức vụ...";
                GetCombobox(List_position);
            }
            else if (cbbTimKiemTheo.SelectedIndex == 4)
            {
                txtTimKiem.Visible = false;
                btnTimKiem.Visible = false;
                cbbSelect.Visible = true;

                cbbSelect.Items.Clear();
                cbbSelect.PromptText = "Chọn giới tính...";
                cbbSelect.Items.Add("Nam");
                cbbSelect.Items.Add("Nữ");
            }
            else
            {
                txtTimKiem.Visible = true;
                btnTimKiem.Visible = true;
                cbbSelect.Visible = false;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Clear();
            Search(txtTimKiem.Text);
        }

        public void Clear()
        {
            int Count = panelView.Controls.Count;
            for (int i = Count-1; i >=0; --i)
            {
                if (panelView.Controls[i].GetType() == typeof(MetroLabel))
                {
                    panelView.Controls.Remove(panelView.Controls[i]);
                }
                Count--;
            }
        }
        public void lbl_Click(object sender, EventArgs e)
        {
            MetroLabel lbl = (MetroLabel)sender;
            Show_lable(BUS_qlnv.Instance.Show(lbl.Tag.ToString(), List));
        }

        public void Search(string txtTK)
        {
            List = BUS_qlnv.Instance.GetList(cbbTimKiemTheo.SelectedIndex, txtTK, LIST);
            int Count = List.Count;
            int left = panelView.Padding.Left;
            int top = panelView.Padding.Top;

            panelView.VerticalScroll.Value = 0;

            for (int i = 0; i < Count; ++i)
            {
                MetroLabel lbl = new MetroLabel();
                lbl.Size = new Size(cbbTimKiemTheo.Size.Width, 20);
                lbl.Location = new Point(left + 3, top + 75 + (i * 25));
                lbl.Text = List[i][2];
                lbl.Tag = List[i][0];
                lbl.Click += lbl_Click;
                panelView.Controls.Add(lbl);
            }
        }

        private void cbbSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Clear();
            Search(cbbSelect.SelectedItem.ToString());
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            frmXemChiTiet frmXemCT = new frmXemChiTiet(Info, List_position);
            this.Visible = false;
            frmXemCT.ShowDialog();
            this.Visible = true;
        }
    }
}
