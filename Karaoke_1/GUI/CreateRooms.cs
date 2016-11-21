using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MetroFramework.Forms;
using HPTCMessageBox;
using Karaoke_1.DTO;
using Karaoke_1.BUS;
using MetroFramework;
using MetroFramework.Controls;

using DTORoom;
using FastReport.DevComponents.DotNetBar;
using ContentAlignment = System.Drawing.ContentAlignment;

namespace Karaoke_1.GUI
{

    public partial class CreateRooms : MetroForm
    {

        public CreateRooms()
        {
            InitializeComponent();
            MSBox.BackgroundColor = Color.WhiteSmoke; // Màu nền
            MSBox.OutlineColor = Color.Tomato; // Viền
            MSBox.TextColor = Color.Black; // Màu chữ

            txtSoluong.KeyUp += txtSoluong_KeyUp;
            txtSoluong.KeyPress +=txtSoluong_KeyPress;
            txtSucChua.KeyPress +=txtSucChua_KeyPress;
            txtSucchua_edit.KeyPress += txtSucchua_edit_KeyPress;
        }

        void txtSucchua_edit_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckIsDigitOrControl(sender, e);
        }

        List<DTO_Room> lstRoom;
        List<DTO_RoomColor> lstRoomcolor = new List<DTO_RoomColor>();
        List<DTO_RoomType> lstRoomtype = new List<DTO_RoomType>();
        List<DTO_RoomTimeSlot> lstRoomtimeslot = new List<DTO_RoomTimeSlot>();
        List<List<int>> lstIntTime = new List<List<int>>();

        private void CreateRooms_Load(object sender, EventArgs e)
        {
            grbEditRoom.Visible = false;

            grbLPTG.Visible = false;

            txtTenPhong.Text = "P0";
            lstRoom = new List<DTO_Room>();

            ReloadRoom();

            rdbCoKhu.Checked = true;

            cmbKhu.SelectedIndex = 0;

            //loại phòng
            ReloadRoomType();

            //màu sắc

            BUS_Room.Instance.LoadColor(lstRoomcolor);


            btnPhongTrong.BackColor = Color.FromArgb(lstRoomcolor[0].CodeColor);
            btnPhongDangSuDung.BackColor = Color.FromArgb(lstRoomcolor[1].CodeColor);
            btnPhongDaDat.BackColor = Color.FromArgb(lstRoomcolor[2].CodeColor);
            btnPhongDangBaoTri.BackColor = Color.FromArgb(lstRoomcolor[3].CodeColor);

        }

        private void ReloadTimeSlot()
        {
            //load lên giờ theo thứ tự 0 -> 23 trong SQL
            lstRoomtimeslot.Clear();
            BUS_Room.Instance.LoadRoomTimeSlot(lstRoomtimeslot);

            //chỉnh lại cho đúng với GUI (bắt đầu từ start + 1)
            lstIntTime.Clear();
            lstIntTime = new List<List<int>>(lstRoomtimeslot.Count);

            for (int i = 0; i < lstRoomtimeslot.Count; i++)
            {
                int startime = lstRoomtimeslot[i].StartTime;
                List<int> t = new List<int>(24);
                lstIntTime.Add(t);
                for (int j = 0; j < 24; j++)
                {
                    lstIntTime[i].Add((startime + j + 1) % 24);
                }
            }
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
                cmbLoaiPhong_Edit.Items.Clear();
                foreach (DTO_RoomType t in lstRoomtype)
                {
                    cmbLoaiPhong.Items.Add(t.Decription);
                    cmbLoaiPhong_Edit.Items.Add(t.Decription);
                }
                cmbLoaiPhong.SelectedIndex = 0;
            }
        }
        private void ReloadRoom()
        {
            panel2.Controls.Clear();

            lstRoom.Clear();
            ReloadRoomType();
            ReloadTimeSlot();
            

            BUS_Room.Instance.LoadInFoRoom(lstRoom);

            if (lstRoom.Count == 0)
            {
                //MSBox box = new MSBox("Thông Báo", "Hiện tại chưa có dữ liệu của Phòng. Mời bạn THÊM phòng để sử dụng các chức năng!", "Đồng ý", MSBox.MSBoxIcon.Infomation);

                //box.StartPosition = FormStartPosition.CenterScreen;
                //box.ShowOnScreen();
                return;
            }

            BUS_Room.Instance.SapXepPhongTangDan(lstRoom);
        }


        void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            grbxOptionRoom.Visible = false;

            grbEditRoom.Visible = true;

            grbxChonMau.Visible = true;

            foreach (DTO_Room t in lstRoom.Where(t => t.Name == btn.Name))
            {
                cmbLoaiPhong_Edit.SelectedIndex = t.Type;

                txtSucchua_edit.Text = t.Amount.ToString();

                txtMaPhong_edit.Text = t.Name;

                txtMaPhong_edit.Enabled = false;

                cmbStatus_edit.SelectedIndex = t.Status == 1 ? 0 : 1;
            }
        }

        private void CreateBorder(int x, int y)
        {
            Label lbl = new Label
            {
                Location = new Point(x, y),
                AutoSize = false,
                BackColor = Color.Coral,
                Height = 5,
                Width = panel2.Width - 40
            };
            panel2.Controls.Add(lbl);

        }
        private void CreateLayer(string name, int x, int y)
        {
            Label lbl = new Label
            {
                Text = name, 
                Location = new Point(x, y)
            };
            lbl.Font = new Font(lbl.Font.FontFamily, 12f, FontStyle.Bold);
            lbl.Width = 64;
            lbl.Height = 20;

            panel2.Controls.Add(lbl);
        }
        private void CreateRoom(string name, int x, int y)
        {
            Button btn = new Button
            {
                UseVisualStyleBackColor = true,
                Location = new Point(x, y),
                Name = name,
                Size = new Size(115, 80),
                Text = name,
                BackColor = Color.DarkOliveGreen,
                Font = new Font("Times New Roman", 12f, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter
            };

            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Click += new EventHandler(this.Button_Click);

            panel2.Controls.Add(btn);

        }

        private void rdbCoKhu_CheckedChanged(object sender, EventArgs e)
        {
            cmbKhu.Enabled = true;
            panel2.Controls.Clear();
            if (lstRoom.Count == 0)
            {
                return;
            }
            int x = 15;
            int y = 20;



            int lblLayerX = 540;
            int lblLayerY = 5;

            int lblBorderX = 3;
            int lblBorderYTop = 28;
            int lblBorderYBottom = 0;
            int hang = 5 + 60 + 2 * y;
            int dem = 0;
            string tang = lstRoom[0].Name[1].ToString();
            foreach (DTO_Room t in lstRoom)
            {
                string tang_toi = t.Name[1].ToString();
                if (String.CompareOrdinal(tang_toi, tang) > 0)
                {
                    lblBorderYBottom = lblBorderYTop + (y) + hang - 10;
                    CreateBorder(lblBorderX, lblBorderYBottom);
                    lblLayerY = lblBorderYBottom + 22;
                    lblBorderYTop = lblBorderYBottom + 47;
                    //lblBorderYBottom += lblBorderYTop;
                    dem = 0;
                    y = 20;
                    tang = tang_toi;
                }
                if (dem == 0)
                {
                    CreateLayer("Khu " + tang.ToString(), lblLayerX, lblLayerY);
                }

                CreateBorder(lblBorderX, lblBorderYTop);
                if (dem % 5 == 0 && dem != 0)
                {
                    y += 85;
                }
                CreateRoom(t.Name, x + ((dem % 5) * 120), y + lblBorderYTop);
                dem++;
            }
            lblBorderYBottom = lblBorderYTop + (y) + hang - 10;
            CreateBorder(lblBorderX, lblBorderYBottom);
        }
        private void rdbKhongKhu_CheckedChanged(object sender, EventArgs e)
        {
            cmbKhu.SelectedItem = 0;

            cmbKhu.Enabled = false;

            panel2.Controls.Clear();
            int x = 15;
            int y = 20;
            for (int i = 0; i < lstRoom.Count; i++)
            {
                if (i % 5 == 0 && i != 0)
                {
                    y += 85;
                }
                CreateRoom(lstRoom[i].Name, x + ((i % 5) * 120), y);
            }
        }

        private void btnThemPhong_Click_1(object sender, EventArgs e)
        {
            
            MSBox ms;
            int maxphong = 50;

            //Kiểm tra sức chứa

            if (lstRoomtype.Count == 0)
            {
                ms = new MSBox("Thông báo",
                    "Hiện tại chưa có loại phòng nào nên Bạn chưa thể thực hiện thao tác thêm phòng. Bạn hãy bấm vào Tùy chỉnh phòng trước để thêm loại phòng rồi mới thêm phòng được!",
                    "Chấp nhận", MSBox.MSBoxIcon.Error);
                ms.ShowOnScreen();
                return;
            }
            
            if (String.IsNullOrEmpty(txtSucChua.Text))
            {
                ms = new MSBox("Thông báo", "Bạn chưa nhập vào sức chứa!", "Chấp nhận", MSBox.MSBoxIcon.Error);
                ms.ShowOnScreen();
                txtSucChua.Focus();
                return;
            }
            int succhua = Convert.ToInt32(txtSucChua.Text);

            //Kiểm tra số lượng
            
            if (String.IsNullOrEmpty(txtSoluong.Text))
            {
                ms = new MSBox("Thông báo", "Bạn chưa nhập vào số lượng!", "Chấp nhận", MSBox.MSBoxIcon.Error);
                ms.ShowOnScreen();
                txtSoluong.Focus();
                return;
            }
            int soluong = Convert.ToInt32(txtSoluong.Text);
            

            

            string sokhu = cmbKhu.Text[cmbKhu.Text.Length - 1].ToString();
            int loaiphong = cmbLoaiPhong.SelectedIndex;

            int Phongmaxkhu = BUS_Room.Instance.PhongMaxKhu(cmbKhu.SelectedItem.ToString()[cmbKhu.Text.Length - 1].ToString(), lstRoom); 
            //Phongmaxkhu = PhongMaxKhu(sokhu);
            if (Phongmaxkhu +  soluong > maxphong)
            {
                ms = new MSBox("Thông báo", "Số phòng thêm vào vượt mức quy định là "+maxphong+"!. \nVui lòng kiểm tra lại!", "Đồng ý",
                    MSBox.MSBoxIcon.Error);
                ms.ShowOnScreen();
                txtSoluong.Focus();
                return;
            }
            int check = BUS_Room.Instance.ThemPhong(soluong, sokhu, loaiphong, succhua, Phongmaxkhu, lstRoom);

            if (check != 0)
            {
                ms = new MSBox("Thông báo", "Thêm thành công!", "Đồng ý", MSBox.MSBoxIcon.Done);
                ms.ShowOnScreen();
                ReloadRoom();
                if (String.CompareOrdinal(sokhu, "0") > 0)
                {
                    rdbCoKhu.Checked = true;
                    rdbKhongKhu.Checked = false;
                    rdbCoKhu_CheckedChanged(sender, e);
                }
                else
                {
                    rdbCoKhu.Checked = false;
                    rdbKhongKhu.Checked = true;
                    rdbKhongKhu_CheckedChanged(sender, e);
                }

            }
            else
            {
                ms = new MSBox("Thông báo", "Thêm thất bại!", "Đồng ý", MSBox.MSBoxIcon.Warning);
                ms.ShowOnScreen();
            }
            cmbKhu_SelectionChangeCommitted(sender, e);
        }

        private void btnsuaphong_Click(object sender, EventArgs e)
        {
            string name = txtMaPhong_edit.Text;

            //if (lstRoom.Where(item => item.Name == name).Any(item => item.Status == 2 || item.Status == 3))
            //{
            //    MSBox ms = new MSBox("Thông báo", "Phòng đã đặt hoặc đang sử dụng không được chỉnh sửa", "Đồng ý", MSBox.MSBoxIcon.Warning);
            //    ms.ShowOnScreen();
            //    return;
            //}
            MSBox ms;
            if (lstRoom.Where(item => item.Name == name).Any(item => item.Status == 2 || item.Status == 3))
            {
                ms = new MSBox("Thông báo", "Phòng đã đặt hoặc đang sử dụng không được chỉnh sửa", "Đồng ý", MSBox.MSBoxIcon.Warning);
                ms.ShowOnScreen();
                return;
            }

            int type = (int)cmbLoaiPhong_Edit.SelectedIndex;
            int status = cmbStatus_edit.SelectedIndex == 0 ? 1 : 4;
            
            int amount;
            if (String.IsNullOrEmpty(txtSucchua_edit.Text))
            {
                ms = new MSBox("Thông báo", "Bạn chưa nhập vào sức chứa!", "Chấp nhận", MSBox.MSBoxIcon.Error);
                ms.ShowOnScreen();
                txtSucchua_edit.Focus();
                return;
            }
            if (int.TryParse(txtSucchua_edit.Text, out amount) == false)
            {
                ms = new MSBox("Thông báo", "Bạn nhập sức chứa quá lớn!. \nVui lòng kiểm tra lại!", "Đồng ý",
                    MSBox.MSBoxIcon.Error);
                ms.ShowOnScreen();
                txtSucchua_edit.Focus();
                return;
            }
            int kq = BUS_Room.Instance.UpdateInfoRoom(name, type, amount, status);
            if (kq != 0)
            {
                ms = new MSBox("Thông báo", "Đã cập nhật thành công", "Đồng ý", MSBox.MSBoxIcon.Infomation);
                ms.ShowOnScreen();
                grbxOptionRoom.Visible = true;
                grbEditRoom.Visible = false;
                CreateRooms_Load(sender, e);
                rdbCoKhu_CheckedChanged(sender, e);
            }
            else
            {
                ms = new MSBox("Thông báo", "Cập nhật thất bại", "Đồng ý", MSBox.MSBoxIcon.Error);
                ms.ShowOnScreen();
            }
        }

        private void txtSucChua_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckIsDigitOrControl(sender, e);
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckIsDigitOrControl(sender, e);
        }      

        private void cmbKhu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbKhu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (txtSoluong.Text.Length == 0)
            {
                txtTenPhong.Text = "P" + cmbKhu.SelectedItem.ToString()[cmbKhu.Text.Length - 1].ToString();
                return;
            }
            int maxkhu = BUS.BUS_Room.Instance.PhongMaxKhu(cmbKhu.SelectedItem.ToString()[cmbKhu.Text.Length - 1].ToString(), lstRoom);
            txtTenPhong.Text = "P" + cmbKhu.SelectedItem.ToString()[cmbKhu.Text.Length - 1].ToString() + (maxkhu + 1).ToString("000") + "..." + "P" + cmbKhu.SelectedItem.ToString()[cmbKhu.Text.Length - 1].ToString() + (maxkhu + int.Parse(txtSoluong.Text)).ToString("000");
        }

        private void txtSoluong_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSoluong.Text.Length == 0)
            {
                txtTenPhong.Text = "P" + cmbKhu.Text[cmbKhu.Text.Length - 1].ToString();
                return;
            }
            int soluong;
            if(int.TryParse(txtSoluong.Text, out soluong) == false)
            {
                return;
            }
            int maxkhu = BUS.BUS_Room.Instance.PhongMaxKhu(cmbKhu.SelectedItem.ToString()[cmbKhu.Text.Length - 1].ToString(), lstRoom);
            txtTenPhong.Text = "P" + cmbKhu.SelectedItem.ToString()[cmbKhu.Text.Length - 1].ToString() + (maxkhu + 1).ToString("000") + "..." + "P" + cmbKhu.SelectedItem.ToString()[cmbKhu.Text.Length - 1].ToString() + (maxkhu + soluong).ToString("000");
        }

        private void btnPhongTrong_Click(object sender, EventArgs e)
        {
            if (MyColor.ShowDialog() == DialogResult.OK)
            {
                btnPhongTrong.BackColor = MyColor.Color;

            }

        }

        private void btnPhongDangSuDung_Click(object sender, EventArgs e)
        {
            if (MyColor.ShowDialog() == DialogResult.OK)
            {
                btnPhongDangSuDung.BackColor = MyColor.Color;

            }

        }

        private void btnPhongDaDat_Click(object sender, EventArgs e)
        {
            if (MyColor.ShowDialog() == DialogResult.OK)
            {
                btnPhongDaDat.BackColor = MyColor.Color;

            }

        }

        private void btnPhongDangBaoTri_Click(object sender, EventArgs e)
        {
            if (MyColor.ShowDialog() == DialogResult.OK)
            {
                btnPhongDangBaoTri.BackColor = MyColor.Color;

            }

        }

        private void CreateRooms_FormClosing(object sender, FormClosingEventArgs e)
        {
            lstRoomcolor.Clear();
            DTO_RoomColor color = new DTO_RoomColor(1, btnPhongTrong.BackColor.ToArgb());

            lstRoomcolor.Add(color);

            DTO_RoomColor color1 = new DTO_RoomColor(2, btnPhongDangSuDung.BackColor.ToArgb());

            lstRoomcolor.Add(color1);

            DTO_RoomColor color2 = new DTO_RoomColor(3, btnPhongDaDat.BackColor.ToArgb());

            lstRoomcolor.Add(color2);

            DTO_RoomColor color3 = new DTO_RoomColor(4, btnPhongDangBaoTri.BackColor.ToArgb());

            lstRoomcolor.Add(color3);

            //In case windows is trying to shut down, don't hold the process up
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (this.DialogResult != DialogResult.Cancel) return;
            // Assume that X has been clicked and act accordingly.
            // Confirm user wants to close
            MSBox ms = new MSBox("Thông báo", "Bạn có muốn thoát không?", "Hủy bỏ;Chấp nhận", MSBox.MSBoxIcon.Question);
            switch (ms.ShowOnScreen())
            {
                //Stay on this form
                case DialogResult.Cancel:
                    {
                        e.Cancel = true;
                        break;
                    }
                default:
                    BUS_Room.Instance.UpDateColorRoom(lstRoomcolor);
                    break;
            }
        }

        private void CreateRooms_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grbEditRoom.Visible = false;
            grbxOptionRoom.Visible = true;
        }

        private void btnxoaphong_Click(object sender, EventArgs e)
        {
            if (BUS_Room.Instance.XoaPhong_ID(txtMaPhong_edit.Text) != 0)
            {
                // MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MSBox ms = new MSBox("Thông báo", "Xóa thành công", "Đồng ý", MSBox.MSBoxIcon.Done);
                ms.ShowOnScreen();
                ReloadRoom();
                rdbCoKhu_CheckedChanged(sender, e);

            }
            else
            {
                //MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MSBox ms = new MSBox("Thông báo", "Xóa thất bại", "Đồng ý", MSBox.MSBoxIcon.Error);
                ms.ShowOnScreen();
            }
        }


        private int y_loaiphong = 15;
        private int soloaiphong = 0;
        private int loaiphongdangchon = 0;
        private int flag_LuuKhungGio = 1;
        //private int flag_SuaKhungGio = 1;
        List<MetroTextBox> lstTxtLoaiPhong = new List<MetroTextBox>();
        //List<MetroButton> lstBtnLoaiPhong = new List<MetroButton>();
        //List<MetroButton> lstBtnChonGio = new List<MetroButton>(); 
        private int[] arrIntTime = new int[24];
        private void btnThemLoaiPhong_Click(object sender, EventArgs e)
        {
            if (lstTxtLoaiPhong.Count - 1 == lstRoomtype.Count)
            {
                MSBox ms = new MSBox("Thông báo", "Bạn cần phải hoàn tất cài đặt cho loại phòng hiện tại thì mới tạo mới thêm loại được", "Đồng ý", MSBox.MSBoxIcon.Infomation);
                ms.ShowDialog();
                lstTxtLoaiPhong[lstTxtLoaiPhong.Count - 1].Focus();
                return;
            }

            panelLoaiPhong.VerticalScroll.Value = 0;

            GroupBox grb = new GroupBox
            {
                Size = new Size(289, 61),
                Location = new Point(3, 3 + (lstTxtLoaiPhong.Count*80)),
                Text = "Loại phòng " + (lstTxtLoaiPhong.Count + 1),
                Name = "grbLoaiphong" + (lstTxtLoaiPhong.Count)
            };
            grb.Click += grb_Click;


            MetroTextBox tbt = new MetroTextBox
            {
                Size = new Size(277, 29),
                Location = new Point(6, 19),
                Name = "txtLoaiThu" + (lstTxtLoaiPhong.Count),
                FontSize = MetroTextBoxSize.Medium
            };
            tbt.WaterMarkFont = new Font("Times New Roman", tbt.Font.Size);
            tbt.Click += tbt_Click;
            tbt.GotFocus += tbt_GotFocus;
            
            lstTxtLoaiPhong.Add(tbt);
            grb.Controls.Add(tbt);
            
            panelLoaiPhong.Controls.Add(grb);

        }

        
        void tbt_GotFocus(object sender, EventArgs e)
        {
            DefaultColorLoaiPhong();
            var tbt = sender as MetroTextBox;
            if (tbt == null) return;
            tbt.Parent.BackColor = Color.FromArgb(color_new);
            tbt.FontSize = MetroTextBoxSize.Tall;
            tbt.FontWeight = MetroTextBoxWeight.Bold;
        }

        void tbt_Click(object sender, EventArgs e)//TextBox loại phòng
        {

            MSBox ms;


            if (flag_LuuKhungGio == 0)
            {
                ms = new MSBox("Thông báo",
                        "Bạn đã thay đổi khung giờ của loại phòng '" + (loaiphongdangchon + 1) +
                        "'\nBạn có muốn LƯU lại khung giờ mới không?", "Hủy bỏ;Chấp nhận", MSBox.MSBoxIcon.Question);
                if (ms.ShowOnScreen() == DialogResult.No) //Chấp nhận thì Update
                {
                    btnLuuKhungGio_Click(sender, e);                  
                }
                else//Hủy thì hỏi chỉnh sửa tiếp hay khôi phục về ban đầu
                {
                    lstTxtLoaiPhong[loaiphongdangchon].Focus();
                    ms = new MSBox("Thông báo", "Bạn muốn tiếp tục chỉnh sửa khung giờ hay khôi phục lại như cũ?",
                        "Chỉnh sửa;Khôi phục", MSBox.MSBoxIcon.Question);
                    if (ms.ShowOnScreen() != DialogResult.No) return;
                    CleanKhungGio();
                    flag_LuuKhungGio = 1;
                    LoadKhungGio(sender, e, loaiphongdangchon);
                }
                return;
            }
            



            if (loaiphongdangchon < lstRoomtype.Count)
            {
                if ((lstTxtLoaiPhong[loaiphongdangchon].Text != lstRoomtype[loaiphongdangchon].Decription))
                {
                    ms = new MSBox("Thông báo",
                        "Bạn đã thay đổi tên của loại phòng '" + (loaiphongdangchon + 1) +
                        "'\nBạn có muốn LƯU lại tên mới không?", "Hủy bỏ;Chấp nhận", MSBox.MSBoxIcon.Question);

                    if (ms.ShowOnScreen() == DialogResult.No)//Đồng ý lưu lại tên mới thì update
                    {
                        for (int i = 0; i < lstRoomtype.Count; i++)
                        {
                            if (lstRoomtype[i].Decription != lstTxtLoaiPhong[loaiphongdangchon].Text) continue;
                            if (i == loaiphongdangchon)//nếu có trùng nhưng nếu là chính nó 
                            {
                                return;
                            }
                            //trùng nhưng không phải chính nó
                            ms = new MSBox("Thông báo",
                                "Tên loại này đã tồn tại!",
                                "Đồng ý", MSBox.MSBoxIcon.Warning);
                            ms.ShowDialog();
                            lstTxtLoaiPhong[loaiphongdangchon].Focus();
                            return;
                        }
                        int kq = BUS_Room.Instance.Update_typeroom(loaiphongdangchon,
                            lstTxtLoaiPhong[loaiphongdangchon].Text);
                        if (kq != 0)
                        {
                            ms = new MSBox("Thông báo",
                                "Cập nhật tên loại phòng thành công!",
                                "Đồng ý", MSBox.MSBoxIcon.Done);
                            ms.ShowDialog();
                            ReloadRoomType();
                            return;
                        }
                    }
                    else
                    {
                        ms = new MSBox("Thông báo", "Bạn muốn tiếp tục chỉnh sửa loại phòng hay khôi phục lại như cũ?",
                        "Chỉnh sửa;Khôi phục", MSBox.MSBoxIcon.Question);
                        if (ms.ShowOnScreen() == DialogResult.No)//Khôi phục
                        {
                            lstTxtLoaiPhong[loaiphongdangchon].Text = lstRoomtype[loaiphongdangchon].Decription;
                        }
                        else//Chỉnh sửa
                        {
                            lstTxtLoaiPhong[loaiphongdangchon].Focus();
                        }
                        return;
                    }
                }
            }
            //if (panelLoaiPhong.Controls[loaiphongdangchon].BackColor.ToArgb() == color_new)
            //{
            //    LoadKhungGio(sender, e, loaiphongdangchon);
            //}
            int valued = loaiphongdangchon;
            var c = sender as Control;
            if (c != null && c.GetType() == typeof(MetroTextBox)) //Tức là control textbox đang gọi tới event này
            {
                c = sender as MetroTextBox;
                loaiphongdangchon = lstTxtLoaiPhong.FindIndex(t => c != null && t.Name == c.Name);
            }
            else//Tức là control Groupbox chứa textbox đang gọi tới sự kiện này
            {
                c = sender as GroupBox;
                loaiphongdangchon = lstTxtLoaiPhong.FindIndex(t => c != null && t.Name == c.Controls[0].Name);
            }
            lstTxtLoaiPhong[loaiphongdangchon].Focus();
            if (loaiphongdangchon != valued)
            {
                CleanKhungGio();
                LoadKhungGio(sender, e, loaiphongdangchon);
            }
            if (lstRoomtype.Count == 0)
            {
                grbKhungGios.Visible = false;
            }
            else
            {
                grbKhungGios.Visible = loaiphongdangchon < lstRoomtype.Count;
            }
            //LoadKhungGio(sender, e, loaiphongdangchon);
        }

        void grb_Click(object sender, EventArgs e)//GroupBox loại phòng
        {
            //var grb = sender as Control;
            //grb.BackColor = Color.FromArgb(color_new);
            tbt_Click(sender, e);
        }

        private void btnTuyChinhPhong_Click(object sender, EventArgs e)
        {
            if (grbPhong.Visible == true)
            {
                grbPhong.Visible = false;
                grbLPTG.Visible = true;
                if (lstRoomtype.Count == 0)
                {

                    flag_LuuKhungGio = 1;
                    grbKhungGios.Visible = false;
                    return;
                }
                grbKhungGios.Visible = true;

                for (var i = 0; i < lstRoomtype.Count; i++)
                {
                    btnThemLoaiPhong_Click(sender, e);//Load lên các loại phòng hiện có
                    lstTxtLoaiPhong[i].Text = lstRoomtype[i].Decription;
                }
                lstTxtLoaiPhong[0].Focus();
                loaiphongdangchon = 0;
                LoadKhungGio(sender, e, 0);
            }
            else
            {
                grbPhong.Visible = true;
                grbLPTG.Visible = false;
                CleanLoaiPhong();
            }


        }

        private void LoadKhungGio(object sender, EventArgs e, int typeroom)
        {
            if (lstRoomtimeslot.Count == 0) return;//Nếu không có dữ liệu của khung giờ nào trong DB thì dừng
            if (typeroom > lstRoomtimeslot.Count - 1) return;//Nếu loại phòng đang chọn chưa có trong DB thì dừng
            CleanKhungGio();//Xóa sạch control trong panelKhungGio
            int start = lstRoomtimeslot[typeroom].StartTime;//Load giờ bắt đầu của khung giờ hiện tại lên real
            if (start == -1)//start == -1 tức là khung giờ của loại phòng này là rỗng.
            {
                return;
            }
            int[] arrMoney = new int[24];//Tiền theo giờ bắt đầu từ start + 1
            //lstIntTime Cột đại diện cho giờ có giá trị bắt đầu từ start + 1
            for (int i = 0; i < 24; i++)
            {
                arrMoney[i] = lstRoomtimeslot[typeroom].TimeSlot[lstIntTime[typeroom][i]];
            }
            List<int> lstMoney = new List<int>();
            List<int> cmb2 = new List<int>();
            int flag_zero = -1;//Kiểm tra xem có cột giờ nào có tiền = 0 không
            //Nếu không tức là quán mở allday
            //Nếu có thì quán mở có ngừng
            //for (int i = 0; i < 24; i++)
            //{
            //    if (arrMoney[i] == 0)
            //    {
            //        flag_zero = 1;
            //    }
            //}
            flag_zero = Array.IndexOf(arrMoney, 0);
            for (int i = 0; i < 23; i++)
            {
                if (arrMoney[i] == arrMoney[i + 1]) continue;
                lstMoney.Add(arrMoney[i]);
                cmb2.Add(i); //index rồi so với IntTime
            }
            if (flag_zero == -1)//Nếu không có khung giờ nào có tiền = 0 thì thêm giá trị tiền cuối cùng vào
            {
                lstMoney.Add(arrMoney[23]);
                cmb2.Add(23);
            }


            btnThemKhungGio_Click(sender, e);//Thêm khung giờ đầu tiên vào
            CleanKhungGio(0);//Xóa giá trị của các control ở khung giờ đầu tiên
            giobatdau = start;//Gán giờ bắt đầu hiện tại 
            arrIntTime = lstIntTime[typeroom].ToArray();//Gán mảng khung giờ bắt đầu từ start + 1 qua mảng hiện tại
            
            //Đổ giá trị cho khung giờ đầu tiên
            //Đổ giá trị cho combobox 1
            for (int j = 0; j < 24; j++)
            {
                lstCmbKhungGio1[0].Items.Add(j);
            }
            lstCmbKhungGio1[0].SelectedIndex = start;

            //Đổ giá trị cho combobox 2
            for (int j = lstIntTime[typeroom].IndexOf((start + 1) % 24); j < lstIntTime[typeroom].Count; j++)
            {
                lstCmbKhungGio2[0].Items.Add(lstIntTime[typeroom][j]);
            }
            lstCmbKhungGio2[0].SelectedIndex = lstCmbKhungGio2[0].Items.IndexOf(lstIntTime[typeroom][cmb2[0]]);
            //
            //Đổ giá trị cho Textbox
            int tien = Convert.ToInt32(lstMoney[0].ToString());
            lstTxtKhungGio[0].Text = tien.ToString("#,##0");

            //Đổ giá trị cho các khung giờ phía sau
            for (int i = 1; i < lstMoney.Count; i++)
            {
                btnThemKhungGio_Click(sender, e);
                CleanKhungGio(i);

                lstCmbKhungGio1[i].Items.Add(lstIntTime[typeroom][cmb2[i - 1]].ToString());
                lstCmbKhungGio1[i].SelectedIndex = 0;

                for (int j = cmb2[i - 1] + 1; j < lstIntTime[typeroom].Count; j++)
                {
                    lstCmbKhungGio2[i].Items.Add(lstIntTime[typeroom][j]);
                }
                lstCmbKhungGio2[i].SelectedIndex = lstCmbKhungGio2[i].Items.IndexOf(lstIntTime[typeroom][cmb2[i]]);

                int tien1 = Convert.ToInt32(lstMoney[i].ToString());
                lstTxtKhungGio[i].Text = tien1.ToString("#,##0");
            }
            lstTxtKhungGio[lstTxtKhungGio.Count - 1].Focus();
            arrIntTime = lstIntTime[typeroom].ToArray();
            flag_LuuKhungGio = 1;//Bật check đã lưu
        }

        void CleanKhungGio(int idx = -1)
        {
            if (idx == -1)
            {
                panelKhungGio.Controls.Clear();
                lstCmbKhungGio1.Clear();
                lstCmbKhungGio2.Clear();
                lstTxtKhungGio.Clear();
            }
            else
            {
                lstCmbKhungGio1[idx].Items.Clear();
                lstCmbKhungGio2[idx].Items.Clear();
                lstTxtKhungGio[idx].Clear();
            }
        }
        void CleanLoaiPhong(int idx = -1)
        {
            if (idx == -1)
            {
                panelLoaiPhong.Controls.Clear();
                lstTxtLoaiPhong.Clear();
            }
            else
            {
                lstTxtLoaiPhong.RemoveAt(idx);
            }
        }
        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckIsDigitOrControl(sender, e);         
        }

        private static void CheckIsDigitOrControl(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                var ct = sender as Control;
                
                int tien;
                if (ct == null) return;
                string temp = ct.Text + e.KeyChar.ToString();
                temp = string.Join("", temp.Split(','));
                if (int.TryParse(temp, out tien) == true) return;
                MSBox ms = new MSBox("Thông báo", "Bạn nhập số quá lớn!. \nVui lòng kiểm tra lại!", "Đồng ý",
                    MSBox.MSBoxIcon.Error);
                ms.ShowOnScreen();
                ct.Focus();
                e.Handled = true;
                return;
                return;
            }
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        void tb_KeyUp(object sender, KeyEventArgs e)
        {
            MetroTextBox tb = (MetroTextBox)sender;
            if (String.IsNullOrEmpty(tb.Text))
            {
                return;
            }
            
            string chuoitien = string.Join("", tb.Text.Split(','));

            int tien = Convert.ToInt32(chuoitien);
            
            tb.Text = tien.ToString("#,##0");
            tb.Select(tb.Text.Length, 1);
        }

        List<MetroComboBox> lstCmbKhungGio1 = new List<MetroComboBox>();
        List<MetroComboBox> lstCmbKhungGio2 = new List<MetroComboBox>();
        List<MetroTextBox> lstTxtKhungGio = new List<MetroTextBox>();
        private int giobatdau = -1;
        private int color_default = Color.White.ToArgb();
        private int color_new = Color.PaleGoldenrod.ToArgb();
        private void btnThemKhungGio_Click(object sender, EventArgs e)
        {
            flag_LuuKhungGio = 0;
            MSBox ms;
            if (lstCmbKhungGio2.Count > 0)
            {
                
                if (lstTxtKhungGio[lstTxtKhungGio.Count - 1].Text == "")
                {
                    ms = new MSBox("Thông báo", "Bạn chưa nhập giá tiền cho loại phòng hiện tại!", "Đồng ý", MSBox.MSBoxIcon.Warning);
                    ms.ShowDialog();
                    lstTxtKhungGio[lstTxtKhungGio.Count - 1].Focus();
                    return;
                }

                if ((int)lstCmbKhungGio2[lstCmbKhungGio2.Count - 1].SelectedItem == arrIntTime[23])
                {
                    ms = new MSBox("Thông báo", "Bạn đã dùng hết số giờ trong ngày nên không thể tạo thêm khung giờ mới!", "Đồng ý", MSBox.MSBoxIcon.Warning);
                    ms.ShowDialog();
                    return;
                }
            }

            panelKhungGio.VerticalScroll.Value = 0;

            GroupBox gb = new GroupBox
            {
                Size = new Size(285, 64),
                Location = new Point(4, 7 + (lstCmbKhungGio2.Count*76)),
                Text = "Khung giờ " + (lstCmbKhungGio2.Count + 1).ToString(),
                Name = "grbKhungGio" + lstCmbKhungGio2.Count.ToString()
            };
            gb.Click += gb_Click;


            MetroComboBox cb1 = new MetroComboBox
            {
                Size = new Size(50, 29), 
                Location = new Point(9, 23)
            };
            lstCmbKhungGio1.Add(cb1);
            if (lstCmbKhungGio2.Count < 1)
            {
                giobatdau = 0;
                for (int i = 0; i <= 23; i++)
                {
                    cb1.Items.Add(i);
                    arrIntTime[i] = (giobatdau + i + 1) % 24;
                }
                cb1.SelectedIndex = 0;
            }
            else
            {
                int temp = (int)lstCmbKhungGio2[lstCmbKhungGio2.Count - 1].SelectedItem;
                cb1.Items.Add(temp);
                cb1.SelectedIndex = 0;
                cb1.Enabled = false;
            }
            cb1.SelectionChangeCommitted += cb1_SelectionChangeCommitted;
            gb.Controls.Add(cb1);


            Label lb1 = new Label 
            {
                Size = new Size(33, 24), 
                Location = new Point(60, 25), 
                Text = "-->"
            };
            lb1.Font = new Font(lb1.Font.FontFamily, 14.25f, lb1.Font.Style);
            gb.Controls.Add(lb1);


            MetroComboBox cb2 = new MetroComboBox
            {
                Size = new Size(50, 29), 
                Location = new Point(95, 23)
            };

            lstCmbKhungGio2.Add(cb2);
            if (lstCmbKhungGio2.Count > 1)
            {
                int temp = (int)cb1.SelectedItem;
                for (int i = Array.IndexOf(arrIntTime, temp) + 1; i < 24; i++)
                {
                    lstCmbKhungGio2[lstCmbKhungGio2.Count - 1].Items.Add(arrIntTime[i]);
                }
                lstCmbKhungGio2[lstCmbKhungGio2.Count - 1].SelectedIndex = 0;

            }
            else
            {
                for (int i = 0; i < 24; i++)
                {
                    cb2.Items.Add(arrIntTime[i]);
                }
                cb2.SelectedIndex = 0;
            }
            cb2.SelectionChangeCommitted += cb2_SelectionChangeCommitted;
            gb.Controls.Add(cb2);


            Label lb2 = new Label
            {
                Size = new Size(15, 24), 
                Location = new Point(142, 25), 
                Text = ":"
            };
            lb2.Font = new Font(lb2.Font.FontFamily, 14.25f, lb2.Font.Style);
            gb.Controls.Add(lb2);

            MetroTextBox tb = new MetroTextBox
            {
                Size = new Size(87, 29),
                Location = new Point(157, 23),
                FontSize = MetroTextBoxSize.Medium,
                TextAlign = HorizontalAlignment.Right
            };
            tb.KeyUp += tb_KeyUp;
            tb.KeyPress += tb_KeyPress;
            tb.Click += tb_Click;
            tb.GotFocus += tb_GotFocus;
            lstTxtKhungGio.Add(tb);
            gb.Controls.Add(tb);


            Label lb3 = new Label
            {
                Size = new Size(41, 18), 
                Location = new Point(242, 34), 
                Text = "đồng"
            };
            lb3.Font = new Font(lb3.Font.FontFamily, 11.25f, lb3.Font.Style);
            gb.Controls.Add(lb3);


            foreach (Control item in gb.Controls)
            {
                item.Click += item_Click;
            }
            cb1.SelectedIndexChanged += new EventHandler(WhenChangeControl);
            cb2.SelectedIndexChanged += new EventHandler(WhenChangeControl);
            tb.TextChanged += new EventHandler(WhenChangeControl);           
            panelKhungGio.Controls.Add(gb);
            lstTxtKhungGio[lstTxtKhungGio.Count - 1].Focus();
            
        }

        void tb_Click(object sender, EventArgs e)
        {
            tb_GotFocus(sender, e);
        }

        void tb_GotFocus(object sender, EventArgs e)
        {
            var c = sender as Control;
            DefaultColorKhungGio();
            if (c.GetType() == typeof (MetroTextBox))
            {
                var tb = c as MetroTextBox;
                tb.Parent.BackColor = Color.FromArgb(color_new);
                tb.Select(c.Text.Length, 1);
            }
            else
            {
                c.BackColor = Color.FromArgb(color_new);
                MetroTextBox tb = c.Controls[4] as MetroTextBox;
                if (tb != null)
                {
                    tb.Focus();
                }
                
            }
        }

        void WhenChangeControl(object sender, EventArgs e)//Bắt sự thay đổi của khung giờ
        {
            flag_LuuKhungGio = 0;
        }

        void item_Click(object sender, EventArgs e)//Control trong groupbox Khung Giờ
        {
            DefaultColorKhungGio();
            Control c = sender as Control;
            if (c != null) c.Parent.BackColor = Color.FromArgb(color_new);
        }
        void DefaultColorKhungGio()
        {
            foreach (GroupBox gr in panelKhungGio.Controls)
            {
                gr.BackColor = Color.FromArgb(color_default);
            }
        }
        void DefaultColorLoaiPhong()
        {
            foreach (GroupBox gr in panelLoaiPhong.Controls)
            {
                gr.BackColor = Color.FromArgb(color_default);
                var tbt = gr.Controls[0] as MetroTextBox;
                if (tbt != null)
                {
                    tbt.FontSize = MetroTextBoxSize.Medium;
                    tbt.FontWeight = MetroTextBoxWeight.Regular;
                }
            }
        }
        void gb_Click(object sender, EventArgs e)//GroupBox Khung Giờ
        {
            tb_GotFocus(sender, e);
        }
        void cb2_SelectionChangeCommitted(object sender, EventArgs e)//Cmb Chọn giờ END
        {

            MetroComboBox cb = (MetroComboBox)sender;
            int idx = lstCmbKhungGio2.IndexOf(cb);
            lstTxtKhungGio[lstTxtKhungGio.Count - 1].Focus();
            if (idx == lstCmbKhungGio2.Count - 1)
            {
                return;
            }
            MSBox ms = new MSBox("Thông báo", "Nếu bạn thay đổi giá trị của khung giờ hiện tại thì các khung giờ sau sẽ bị xóa đi?", "Hủy bỏ;Chấp nhận", MSBox.MSBoxIcon.Warning);

            if (ms.ShowOnScreen() == DialogResult.No)
            {
                while (idx != panelKhungGio.Controls.Count - 1)
                {
                    panelKhungGio.Controls.RemoveAt(idx + 1);
                    lstTxtKhungGio.RemoveAt(idx + 1);
                    lstCmbKhungGio1.RemoveAt(idx + 1);
                    lstCmbKhungGio2.RemoveAt(idx + 1);
                }
            }
            else
            {
                //int t = lstCmbKhungGio1[idx + 1].Items.Count;
                int item = Convert.ToInt32(lstCmbKhungGio1[idx + 1].Items[0]);
                cb.SelectedIndex = cb.Items.IndexOf(item);

            }
        }
        void cb1_SelectionChangeCommitted(object sender, EventArgs e)//Cmb Chọn giờ START
        {
            MetroComboBox cb = (MetroComboBox)sender;
            int idx = lstCmbKhungGio1.IndexOf(cb);
            lstCmbKhungGio2[idx].Items.Clear();
            int temp = (int)cb.SelectedItem;
            if (cb == lstCmbKhungGio1[0])
            {
                giobatdau = temp;
                for (int i = 0; i < 24; i++)
                {
                    arrIntTime[i] = (giobatdau + i + 1) % 24;
                }
            }

            for (int i = Array.IndexOf(arrIntTime, temp + 1); i < 24; i++)
            {
                lstCmbKhungGio2[idx].Items.Add(arrIntTime[i]);
            }
            lstCmbKhungGio2[idx].SelectedIndex = 0;
            lstTxtKhungGio[lstTxtKhungGio.Count - 1].Focus();
        }
        private void btnLuuKhungGio_Click(object sender, EventArgs e)
        {
            MSBox ms;
            for (int i = 0; i < lstTxtKhungGio.Count; i++)
            {
                if (!String.IsNullOrEmpty(lstTxtKhungGio[i].Text)) continue;
                ms = new MSBox("Thông báo", "Bạn chưa nhập giá tiền cho Khung giờ " + (i + 1) + "!", "Đồng ý", MSBox.MSBoxIcon.Warning);
                ms.ShowDialog();
                lstTxtLoaiPhong[loaiphongdangchon].Focus();
                lstTxtKhungGio[i].Focus();
                return;
            }
            int[] arrTemp = new int[24];//Tiền giờ có cột bắt đầu từ star + 1. VD Vào 9 thì bắt đầu = 10

            for (int i = 0; i < lstCmbKhungGio2.Count; i++)
            {
                int start = int.Parse(lstCmbKhungGio1[i].SelectedItem.ToString());
                int end = int.Parse(lstCmbKhungGio2[i].SelectedItem.ToString());
                string kq = string.Join("", lstTxtKhungGio[i].Text.Split(','));

                int value = int.Parse(kq);


                for (int j = Array.IndexOf(arrIntTime, (start + 1) % 24); j <= Array.IndexOf(arrIntTime, end); j++)
                {
                    arrTemp[j] = value;
                }
            }

            int[] arrTienGio = new int[24];//Tiền giờ theo đúng SQL bắt đầu từ 0
            for (int i = 0; i < 24; i++)
            {
                arrTienGio[arrIntTime[i]] = arrTemp[i];
            }

            if (lstCmbKhungGio2.Count == 0)
            {
                giobatdau = -1;
            }

            if (loaiphongdangchon < lstRoomtimeslot.Count)//Loại phòng đã tồn tại thì Update
            {
                int rs = BUS_Room.Instance.Update_RoomTimeSlot(arrTienGio, loaiphongdangchon, giobatdau);
                if (rs == 0) return;

                ms = new MSBox("Thông báo", "Cập khung giờ thành công!", "Đồng ý", MSBox.MSBoxIcon.Update);
                ms.ShowDialog();
                ReloadTimeSlot();
                flag_LuuKhungGio = 1;
                ReloadTimeSlot();
                return;

            }
            else//Chưa tồn tại thì Insert
            {
                int rs = BUS_Room.Instance.Insert_RoomTimeSlot(arrTienGio, loaiphongdangchon, giobatdau);
                if (rs == 0) return;

                ms = new MSBox("Thông báo", "Thêm khung giờ thành công!", "Đồng ý", MSBox.MSBoxIcon.Done);
                ms.ShowDialog();
                flag_LuuKhungGio = 1;
                ReloadTimeSlot();
                return;             
            }
        }
        private void btnXoaKhungGio_Click(object sender, EventArgs e)
        {
            int idx = -1;
            MSBox ms;
            foreach (GroupBox gb in panelKhungGio.Controls)
            {
                if (gb.BackColor == Color.FromArgb(color_default)) continue;
                idx = panelKhungGio.Controls.IndexOf(gb);
                break;
            }
            if (idx == -1)
            {
                ms = new MSBox("Thông báo", "Bạn chưa chọn khung giờ để xóa!?", "Hủy bỏ;Chấp nhận", MSBox.MSBoxIcon.Warning);
                ms.ShowOnScreen();
                return;
            }
            if (idx == lstCmbKhungGio2.Count - 1)
            {
                panelKhungGio.Controls.RemoveAt(idx);
                lstTxtKhungGio.RemoveAt(idx);
                lstCmbKhungGio1.RemoveAt(idx);
                lstCmbKhungGio2.RemoveAt(idx);
                flag_LuuKhungGio = 0;
                return;
            }
            ms = new MSBox("Thông báo", "Nếu bạn xóa khung giờ hiện tại thì các khung giờ sau sẽ bị xóa đi theo?", "Hủy bỏ;Chấp nhận", MSBox.MSBoxIcon.Warning);

            if (ms.ShowOnScreen() != DialogResult.No) return;
            while (idx != panelKhungGio.Controls.Count)
            {
                panelKhungGio.Controls.RemoveAt(idx);
                lstTxtKhungGio.RemoveAt(idx);
                lstCmbKhungGio1.RemoveAt(idx);
                lstCmbKhungGio2.RemoveAt(idx);
            }
            flag_LuuKhungGio = 0;
        }
        private void btnLuuLoaiPhong_Click(object sender, EventArgs e)
        {
            MSBox ms;
            //kiểm tra rỗng
            if (lstTxtLoaiPhong[loaiphongdangchon].Text == "")
            {
                ms = new MSBox("Thông báo", "Tên loại phòng không được để rỗng", "Đồng ý", MSBox.MSBoxIcon.Infomation);
                ms.ShowDialog();
                lstTxtLoaiPhong[loaiphongdangchon].Focus();
                return;
            }

            //kiểm tra tên loại phòng bị trùng
            for (int i = 0; i < lstRoomtype.Count; i++)
            {
                if (lstRoomtype[i].Decription != lstTxtLoaiPhong[loaiphongdangchon].Text) continue;
                if (i == loaiphongdangchon)//nếu có trùng nhưng nếu là chính nó 
                {
                    return;
                }
                //trùng nhưng không phải chính nó
                ms = new MSBox("Thông báo",
                    "Tên loại này đã tồn tại!",
                    "Đồng ý", MSBox.MSBoxIcon.Warning);
                ms.ShowDialog();
                lstTxtLoaiPhong[loaiphongdangchon].Focus();
                return;
            }

            if (loaiphongdangchon > lstRoomtype.Count - 1)//Nếu loại phòng đang chọn hiện không có trong Roomtype thì insert nó vào nếu tên loại mới không bị trùng
            {
                int kq1 = BUS_Room.Instance.Insert_typeroom(loaiphongdangchon, lstTxtLoaiPhong[loaiphongdangchon].Text);
                if (kq1 == 0) return;

                ms = new MSBox("Thông báo",
                    "Thêm mới loại phòng thành công!",
                    "Đồng ý", MSBox.MSBoxIcon.Infomation);
                ms.ShowDialog();
                ReloadRoomType();
                return;
                
            }
            else//Kiểm tra xem người dùng có chỉnh sửa gì không, tùy người dùng mà update dữ liệu mới hoặc rollback
            {
                if (lstRoomtype.Count <= 0) return;
                if ((lstTxtLoaiPhong[loaiphongdangchon].Text == lstRoomtype[loaiphongdangchon].Decription)) return;
                ms = new MSBox("Thông báo",
                    "Bạn có muốn LƯU lại tên mới không?", "Hủy bỏ;Chấp nhận", MSBox.MSBoxIcon.Question);

                if (ms.ShowOnScreen() == DialogResult.No)
                {
                    for (int i = 0; i < lstRoomtype.Count; i++)
                    {
                        if (lstRoomtype[i].Decription != lstTxtLoaiPhong[loaiphongdangchon].Text) continue;
                        if (i == loaiphongdangchon)//nếu có trùng nhưng nếu là chính nó 
                        {
                            return;
                        }
                        //trùng nhưng không phải chính nó
                        ms = new MSBox("Thông báo",
                            "Tên loại này đã tồn tại!",
                            "Đồng ý", MSBox.MSBoxIcon.Warning);
                        ms.ShowDialog();
                        lstTxtLoaiPhong[loaiphongdangchon].Focus();
                        return;
                    }
                    int kq = BUS_Room.Instance.Update_typeroom(loaiphongdangchon,
                        lstTxtLoaiPhong[loaiphongdangchon].Text);
                    if (kq != 0)
                    {
                        ms = new MSBox("Thông báo",
                            "Cập nhật tên loại phòng thành công!",
                            "Đồng ý", MSBox.MSBoxIcon.Infomation);
                        ms.ShowDialog();
                        ReloadRoomType();
                        return;
                    }
                }
                else
                {
                    lstTxtLoaiPhong[loaiphongdangchon].Text = lstRoomtype[loaiphongdangchon].Decription;
                    return;
                }
            }   
        }
    }
}
