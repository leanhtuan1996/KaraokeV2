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
using Karaoke_1.GUI;

namespace Karaoke_1.GUI
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            #region Chọn Màu
            switch (frmLogin.FormStyle)
            {
                case 1:
                    {
                        this.Style = MetroColorStyle.Black;
                        break;
                    }
                case 2:
                    {
                        this.Style = MetroColorStyle.White;
                        break;
                    }
                case 3:
                    {
                        this.Style = MetroColorStyle.Silver;
                        break;
                    }
                case 4:
                    {
                        this.Style = MetroColorStyle.Blue;
                        break;
                    }
                case 5:
                    {
                        this.Style = MetroColorStyle.Green;
                        break;
                    }
                case 6:
                    {
                        this.Style = MetroColorStyle.Lime;
                        break;
                    }
                case 7:
                    {
                        this.Style = MetroColorStyle.Teal;
                        break;
                    }
                case 8:
                    {
                        this.Style = MetroColorStyle.Orange;
                        break;
                    }
                case 9:
                    {
                        this.Style = MetroColorStyle.Brown;
                        break;
                    }
                case 10:
                    {
                        this.Style = MetroColorStyle.Pink;
                        break;
                    }
                case 11:
                    {
                        this.Style = MetroColorStyle.Magenta;
                        break;
                    }
                case 12:
                    {
                        this.Style = MetroColorStyle.Purple;
                        break;
                    }
                case 13:
                    {
                        this.Style = MetroColorStyle.Red;
                        break;
                    }
                case 14:
                    {
                        this.Style = MetroColorStyle.Yellow;
                        break;
                    }
            }
            #endregion
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmQuanLyNhanVien frmqlnv = new frmQuanLyNhanVien();
            frmqlnv.ShowDialog();
            this.Close();
        }

        private void btnQuanLyPhong_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CreateRooms frmCreateRoom = new CreateRooms();
            frmCreateRoom.ShowDialog();
            this.Close();
        }

        private void btnMainRoom_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainRooms frmMainRoom = new MainRooms();
            frmMainRoom.ShowDialog();
            this.Close();
        }
    }
}
