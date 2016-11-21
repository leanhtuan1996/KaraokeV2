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
    public partial class frmXemChiTiet : MetroForm
    {
        public frmXemChiTiet()
        {
            InitializeComponent();
        }

        private bool CHECK = true;
        private string[] ARR = new string[36];
        private List<MetroLabel> List_lbl = new List<MetroLabel>();
        private List<MetroLabel> List_lbl_gb1 = new List<MetroLabel>();
        private List<MetroLabel> List_lbl_gb2 = new List<MetroLabel>();
        private MetroLabel Lable = new MetroLabel();
        private MetroComboBox combobox = new MetroComboBox();
        private MetroDateTime Dtp = new MetroDateTime();
        private List<string[]> LIST_position = new List<string[]>();

        public void Show_lable(string[] str)
        {
            lblMaNV.Text = "Mã NV: " + str[1];
            lblTK.Text = "Tên TK: " + str[12];
            lblMK.Text = "Mật Khẩu: " + str[13];
            lblFullName.Text = "Tên NV: " + str[2];
            lblGioiTinh.Text = "Giới Tính: " + str[5];
            lblNickName.Text = "Nick Name: " + str[3];
            lblNgaySinh.Text = "Ngày Sinh: " + str[4];
            lblTinhTrangHonNhan.Text = "Tình Trạng Hôn Nhân: " + str[6];
            lblCmnd.Text = "Cmnd: " + str[7];
            lblChucVu.Text = "Chức Vụ: " + str[11];
            lblTrangThai.Text = "Trạng Thái: " + str[9];
            lblSDT.Text = "Số Điện Thoại: " + str[10];

            lblNgayTao.Text = "Ngày tạo: " + str[15];
            lblLuongCoBan.Text = "Lương căn bản: " + str[17];
            lblPhuCap.Text = "Phụ cấp: " + str[18];
            lblLuongThuong.Text = "Lương thưởng: " + str [19];
            lblLuongCongThem.Text = "Lương cộng thêm: " + str[20];
            lblLyDo.Text = "Lý do: " + str[21];

            lblMaHD.Text = "Mã HD: " + str[23];
            lblTenHD.Text = "Tên HD: " + str[24];
            lblLoaiHD.Text = "Loại HD: " + str[25];
            lblNgayBatDau.Text = "Ngày bắt đầu: " + str[26];
            lblNgayKetThuc.Text = "Ngày kết thúc : " + str[27];

            lblMaBH.Text = "Mã BH: " + str[33];
            lblNoiCap.Text = "Nơi cấp: " + str[35];
            lblNgayLap.Text = "Ngày lập: " + str[34];

            lblNgayNghiPS.Text = "Ngày nghĩ: " + str[29];
            lblNgayTroLai.Text = "Ngày làm lại: " + str[30];
            lblTroCap.Text = "Trợ cấp: " + str[31];
        }
        public frmXemChiTiet(string[] arr, List<string[]> list_position) : this()
        {
            for (int i = 0; i < 14; ++i)
            {
                ARR[i] = arr[i];
            }

            string[] array = BUS_XemChiTiet.Instance.Arr_Info(arr[0]);

            for (int i = 14; i < ARR.Length;++i )
            {
                ARR[i] = array[i-14];
            }
            MessageBox.Show(ARR[17]);
            MessageBox.Show(ARR[18]);
            LIST_position = list_position;
        }

        public void LOAD_position()
        {
            LIST_position = BUS_qlnv.Instance.Load_Position();
        }

        public void ADD_lbl()
        {
            List_lbl.Add(lblTK);
            List_lbl.Add(lblMK);
            List_lbl.Add(lblFullName);
            List_lbl.Add(lblGioiTinh);
            List_lbl.Add(lblNickName);
            List_lbl.Add(lblNgaySinh);
            List_lbl.Add(lblTinhTrangHonNhan);
            List_lbl.Add(lblCmnd);
            List_lbl.Add(lblChucVu);
            List_lbl.Add(lblTrangThai);
            List_lbl.Add(lblSDT);
            List_lbl.Add(lblNgayTao);
            List_lbl.Add(lblLuongThuong);
            List_lbl.Add(lblLuongCongThem);
            List_lbl.Add(lblLyDo);

            foreach(MetroLabel lbl in List_lbl)
            {
                lbl.MouseMove += Lable_MouseMove;
                lbl.MouseLeave += Lable_MouseLeave;
                lbl.TextChanged += Text_Changed;
            }

            List_lbl_gb1.Add(lblMaHD);
            List_lbl_gb1.Add(lblTenHD);
            List_lbl_gb1.Add(lblLoaiHD);
            List_lbl_gb1.Add(lblNgayBatDau);
            List_lbl_gb1.Add(lblNgayKetThuc);

            foreach(MetroLabel lbl in List_lbl_gb1)
            {
                lbl.MouseMove += Lable_MouseMove_gb1;
                lbl.MouseLeave += Lable_MouseLeave;
                lbl.TextChanged += Text_Changed;
            }

            List_lbl_gb2.Add(lblMaBH);
            List_lbl_gb2.Add(lblNoiCap);
            List_lbl_gb2.Add(lblNgayLap);
            List_lbl_gb2.Add(lblNgayNghiPS);
            List_lbl_gb2.Add(lblNgayTroLai);
            List_lbl_gb2.Add(lblTroCap);

            foreach (MetroLabel lbl in List_lbl_gb2)
            {
                lbl.MouseMove += Lable_MouseMove_gb2;
                lbl.MouseLeave += Lable_MouseLeave;
                lbl.TextChanged += Text_Changed;
            }
        }
        public void Lable_MouseLeave(object sender, EventArgs e)
        {
            CHECK = true;
        }
        public void Lable_MouseMove(object sender, EventArgs e)
        {
            if (CHECK == true)
            {
                XXX(sender, btnform, 0);
            }
        }

        public void Lable_MouseMove_gb1(object sender, EventArgs e)
        {
            if (CHECK == true)
            {
                XXX(sender, btnhd, 1);
            }

        }

        public void Lable_MouseMove_gb2(object sender, EventArgs e)
        {
            if (CHECK == true)
            {
                XXX(sender, btnbhvats, 2);
            }

        }

        public void XXX(object sender, MetroButton mt_btn, int loai)
        {
            mt_btn.Visible = true;
            toolTipButton.SetToolTip(mt_btn, "Chỉnh Sửa");
            MetroLabel lbl = (MetroLabel)sender;
            Lable = lbl;

            if (loai == 0)
            {
                btnhd.Visible = false;
                btnbhvats.Visible = false;
                btnform.Location = new Point(lbl.Location.X + lbl.Size.Width + 20, lbl.Location.Y);
                mt_btn.Tag = 0;
            }
            else if (loai == 1)
            {
                btnform.Visible = false;
                btnbhvats.Visible = false;
                btnhd.Location = new Point(lbl.Location.X + lbl.Size.Width + 20, lbl.Location.Y);
                mt_btn.Tag = 1;
            }
            else
            {
                btnform.Visible = false;
                btnhd.Visible = false;
                btnbhvats.Location = new Point(lbl.Location.X + lbl.Size.Width + 20, lbl.Location.Y);
                mt_btn.Tag = 2;
            }
            mt_btn.Click += Edit;
            CHECK = false;
        }

        public void Edit(object sender, EventArgs e)
        {
            MetroButton mt_btn  = (MetroButton)sender;
            if (mt_btn.Tag.ToString().Contains("0") == true)
            {
                gbEdit.Location = new Point(Lable.Location.X, Lable.Location.Y);
            }
            else if (mt_btn.Tag.ToString().Contains("1") == true)
            {
                gbEdit.Location = new Point(6, 231);
            }
            else
            {
                gbEdit.Location = new Point(276, 236);
            }

            // text
            if (Lable.Tag.ToString().Contains("1") == true)
            {
                combobox.Visible = false;
                Dtp.Visible = false;
                txtEdit.Text = "";

                txtEdit.Visible = true;
            } // cbb
            else if (Lable.Tag.ToString().Contains("2") == true)
            {
                txtEdit.Visible = false;
                Dtp.Visible = false;
                combobox.Items.Clear();

                if (Lable.Name.Contains("GioiTinh") == true)
                {
                    combobox.Items.Add("Nam");
                    combobox.Items.Add("Nữ");
                }
                else if (Lable.Name.Contains("ChucVu") == true)
                {
                    foreach (string[] str in LIST_position)
                    {
                        combobox.Items.Add(str[0]);
                    }
                }
                else if (Lable.Name.Contains("HonNhan") == true)
                {
                    combobox.Items.Add("Có");
                    combobox.Items.Add("Không");
                }
                else if (Lable.Name.Contains("TrangThai") == true)
                {
                    combobox.Items.Add("ONLINE");
                    combobox.Items.Add("OFFLINE");
                    combobox.Items.Add("Nghĩ Phép");
                    combobox.Items.Add("Nghĩ Làm");
                    combobox.Items.Add("Nghĩ Thai Sản");
                }
                else if (Lable.Name.Contains("LoaiHD") == true)
                {
                    combobox.Items.Add("Kinh tế");
                    combobox.Items.Add("Lao Động");
                }
#region         
                else
                {
                    combobox.Items.Add("An Giang");
                    combobox.Items.Add("Bà Rịa - Vũng Tàu");
                    combobox.Items.Add("Bắc Giang");
                    combobox.Items.Add("Bắc Kạn");
                    combobox.Items.Add("Bạc Liêu");
                    combobox.Items.Add("Bắc Ninh");
                    combobox.Items.Add("Bến Tre");
                    combobox.Items.Add("Bình Định");
                    combobox.Items.Add("Bình Dương");
                    combobox.Items.Add("Bình Phước");
                    combobox.Items.Add("Bình Thuận");
                    combobox.Items.Add("Cà Mau");
                    combobox.Items.Add("Cao Bằng");
                    combobox.Items.Add("Cần Thơ");
                    combobox.Items.Add("Đà Nẵng");
                    combobox.Items.Add("Đắk Lắk");
                    combobox.Items.Add("Đắk Nông");
                    combobox.Items.Add("Điện Biên");
                    combobox.Items.Add("Đồng Nai");
                    combobox.Items.Add("Đồng Tháp");
                    combobox.Items.Add("Gia Lai");
                    combobox.Items.Add("Hà Nội");
                    combobox.Items.Add("Hải Phòng");
                    combobox.Items.Add("Hà Giang");
                    combobox.Items.Add("Hà Nam");
                    combobox.Items.Add("Hà Tĩnh");
                    combobox.Items.Add("Hải Dương");
                    combobox.Items.Add("Hậu Giang");
                    combobox.Items.Add("Hòa Bình");
                    combobox.Items.Add("Hưng Yên");
                    combobox.Items.Add("Khánh Hòa");
                    combobox.Items.Add("Kiên Giang");
                    combobox.Items.Add("Kon Tum");
                    combobox.Items.Add("Lai Châu");
                    combobox.Items.Add("Lâm Đồng");
                    combobox.Items.Add("Lạng Sơn");
                    combobox.Items.Add("Lào Cai");
                    combobox.Items.Add("Long An");
                    combobox.Items.Add("Nam Định");
                    combobox.Items.Add("Nghệ An");
                    combobox.Items.Add("Ninh Bình");
                    combobox.Items.Add("Ninh Thuận");
                    combobox.Items.Add("Phú Thọ");
                    combobox.Items.Add("Quảng Bình");
                    combobox.Items.Add("Quảng Nam");
                    combobox.Items.Add("Quảng Ngãi");
                    combobox.Items.Add("Quảng Ninh");
                    combobox.Items.Add("Quảng Trị");
                    combobox.Items.Add("Sóc Trăng");
                    combobox.Items.Add("Sơn La");
                    combobox.Items.Add("TP HCM");
                    combobox.Items.Add("Tây Ninh");
                    combobox.Items.Add("Thái Bình");
                    combobox.Items.Add("Thái Nguyên");
                    combobox.Items.Add("Thanh Hóa");
                    combobox.Items.Add("Thừa Thiên Huế");
                    combobox.Items.Add("Tiền Giang");
                    combobox.Items.Add("Trà Vinh");
                    combobox.Items.Add("Tuyên Quang");
                    combobox.Items.Add("Vĩnh Long");
                    combobox.Items.Add("Vĩnh Phúc");
                    combobox.Items.Add("Yên Bái");
                    combobox.Items.Add("Phú Yên");
                }
#endregion
                combobox.SelectedIndex = 0;
                combobox.Visible = true;
            } // DateTimePicker
            else
            {
                txtEdit.Visible = false;
                combobox.Visible = false;


                Dtp.Visible = true;
            }

            gbEdit.Visible = true;
        }
        public void LOAD()
        {
            btnform.Visible = false;
            btnform.BackgroundImageLayout = ImageLayout.Stretch;
            btnform.BackgroundImage = Properties.Resources.Edit;

            btnhd.Visible = false;
            btnhd.BackgroundImageLayout = ImageLayout.Stretch;
            btnhd.BackgroundImage = Properties.Resources.Edit;

            btnbhvats.Visible = false;
            btnbhvats.BackgroundImageLayout = ImageLayout.Stretch;
            btnbhvats.BackgroundImage = Properties.Resources.Edit;
            gbEdit.Visible = false;


            gbEdit.Controls.Add(combobox);
            combobox.Location = new Point(4, 25);
            combobox.Size = new Size(205, 30);


            gbEdit.Controls.Add(Dtp);
            Dtp.Location = new Point(7,25);
            Dtp.Format = DateTimePickerFormat.Short;

            ADD_lbl();
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
            Show_lable(ARR);
            btnSuavaLuu.Text = "Sửa";
        }

        private void frmXemChiTiet_Load(object sender, EventArgs e)
        {
            LOAD();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            gbEdit.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string temp = "";
            string First = Lable.Text.Substring(0,Lable.Text.IndexOf(':') + 2);
            string Late = Lable.Text.Substring(Lable.Text.IndexOf(':') + 2);
            if (txtEdit.Visible ==true)
            {
                if (string.IsNullOrEmpty(txtEdit.Text))
                {
                    MessageBox.Show("Dữ liệu không được rỗng. Vui lòng kiểm tra lại!");
                    return;
                }
                else
                {
                    temp = txtEdit.Text;
                }
            }
            else if (combobox.Visible ==true)
            {
                temp = combobox.SelectedItem.ToString();
            }
            else
            {
                temp = Dtp.Value.ToShortDateString();
            }

            for (int i = 0; i < ARR.Length; ++i)
            {
                if (Late.CompareTo(ARR[i]) == 0)
                {
                    Lable.Text = First + temp;
                    ARR[i] = temp;
                    break;
                }
            }
            gbEdit.Visible = false;
        }

        private void txtEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lblChucVu_TextChanged(object sender, EventArgs e)
        {
            Get_salary();
        }
        public void Get_salary()
        {
            string position = lblChucVu.Text.Substring(lblChucVu.Text.IndexOf(':') + 2);
            foreach (string[] arr in LIST_position)
            {
                if (arr[0].CompareTo(position) == 0)
                {
                    lblLuongCoBan.Text = "Lương cơ bản: " + arr[1];
                    lblPhuCap.Text = "Phụ cấp: " + arr[2];
                    break;
                }

            }
        }

        public void Text_Changed(object sender, EventArgs e)
        {
            btnSuavaLuu.Text = "Lưu";
        }

        private void btnSuavaLuu_Click(object sender, EventArgs e)
        {
            if (btnSuavaLuu.Text.CompareTo("Lưu") ==0)
            {
                // lưu
            }
            else
            {
                // sửa
            }
        }
    }
}
