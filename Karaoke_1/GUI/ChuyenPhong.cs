using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DTORoom;
using MetroFramework.Forms;
using HPTCMessageBox;

using Karaoke_1.DTO;
using Karaoke_1.BUS;

namespace Karaoke_1.GUI
{
    public partial class ChuyenPhong : MetroForm
    {
        public static string Nameroom;
       
        public ChuyenPhong()
        {
            InitializeComponent();
            MSBox.BackgroundColor = Color.WhiteSmoke; // Màu nền
            MSBox.OutlineColor = Color.Tomato; // Viền
            MSBox.TextColor = Color.Black; // Màu chữ
        }

        private void ChuyenPhong_Load(object sender, EventArgs e)
        {

            txtPhongHienTai_ChuyenPhong.Text = Nameroom;
            
            foreach (var room in MainRooms.lstRoom.Where(room => room.Status == 1))
            {
                cmbPhongMuonChuyen_ChuyenPhong.Items.Add(room.Name);
            }
            cmbPhongMuonChuyen_ChuyenPhong.SelectedIndex = 0;
            
        }

        private void btnHuy_ChuyenPhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChuyen_ChuyenPhong_Click(object sender, EventArgs e)
        {
            DateTime giovao = DateTime.Now;
            int tiendatphong = 0;
            foreach (DTO_Room room in MainRooms.lstRoom.Where(room => room.Name == Nameroom))
            {
                giovao = room.StartTime;
                tiendatphong = room.Tiendatphong;
                break;
            }

            int kq = BUS_Room.Instance.ChuyenPhong(txtPhongHienTai_ChuyenPhong.Text, giovao, cmbPhongMuonChuyen_ChuyenPhong.SelectedItem.ToString(), tiendatphong);
            if (kq != 0)
            {
                MSBox ms = new MSBox("Thông báo", "Chuyển phòng thành công", "Đóng", MSBox.MSBoxIcon.Done);

                //Chuyển trạng thái của phòng cần chuyển
                foreach (var item in MainRooms.lstRoom.Where(name => name.Name == Nameroom))
                {
                    item.Status = 1;
                    item.Tiendatphong = 0;
                    break;
                }

                //Cập nhật trái thái phòng sắp vào & set thời gian bắt đầu
                foreach(var item in MainRooms.lstRoom.Where(name => name.Name == cmbPhongMuonChuyen_ChuyenPhong.SelectedItem.ToString()))
                {
                    item.Status = 2;
                    item.StartTime = giovao;
                    item.Tiendatphong = tiendatphong;
                    break;
                }

                //Đổi màu phòng cần chuyển và phòng đến
                foreach (var item in MainRooms.lstButton.Where(button => button.Name == Nameroom))
                {
                    item.BackColor = Color.FromArgb(-32576);
                    break;
                }


                foreach (
                    var item1 in
                        MainRooms.lstButton.Where(
                            button1 => button1.Name == cmbPhongMuonChuyen_ChuyenPhong.SelectedItem.ToString()))
                {
                    item1.BackColor = Color.FromArgb(-16744448);
                }

                DialogResult dialog = ms.ShowOnScreen();
                if(dialog == System.Windows.Forms.DialogResult.Cancel)
                {
                    this.Close();
                }
            }
            else
            {
                MSBox ms = new MSBox("Thông báo", "Chuyển phòng thất bại", "Đóng", MSBox.MSBoxIcon.Error);
                return;
            }
        }


    }
}
