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
using Karaoke_1.BUS;
using Karaoke_1.GUI;
using System.Threading;
using System.Diagnostics;

namespace Karaoke_1.GUI
{
    public partial class frmQuanLyNhanVien : MetroForm
    {
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private Thread thrd;

        public void LOAD_Image()
        {
            btnThongTinTaiKhoan.BackgroundImageLayout = ImageLayout.Stretch;
            btnThongTinTaiKhoan.BackgroundImage = Karaoke_1.Properties.Resources.thongtintaikhoan;
            btnDanhSachTaiKhoan.BackgroundImageLayout = ImageLayout.Stretch;
            btnDanhSachTaiKhoan.BackgroundImage = Karaoke_1.Properties.Resources.danhsachtaikhoan;
            btnChonMauNen.BackgroundImageLayout = ImageLayout.Stretch;
            btnChonMauNen.BackgroundImage = Karaoke_1.Properties.Resources.chonmaunen;
            btnDangXuat.BackgroundImageLayout = ImageLayout.Stretch;
            btnDangXuat.BackgroundImage = Karaoke_1.Properties.Resources.dangxuat;
            btnGiaiTri.BackgroundImageLayout = ImageLayout.Stretch;
            btnGiaiTri.BackgroundImage = Karaoke_1.Properties.Resources.giaitri;
        }
        public void LOAD()
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

            // Load image
            thrd = new Thread(LOAD_Image);
            thrd.Start();
        }
        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LOAD();
        }

        private void metroLink1_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/Nevermore1412");
        }

        private void metroLink2_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/tugialoc?fref=hovercard");
        }

        private void metroLink3_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/tuanle511");
        }

        private void metroLink4_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/thuytran.3007");
        }

        private void metroLink5_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/trandangngocthanh?fref=hovercard");
        }

        private void metroLink6_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/nguyen.van.cuong.2016");
        }

        private void btnThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            frmThongTinTaiKhoan frmThongTinTK = new frmThongTinTaiKhoan();
            this.Visible = false;
            frmThongTinTK.ShowDialog();
            this.Visible = true;
        }
    }
}
