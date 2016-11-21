using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using HPTCMessageBox;

using Karaoke_1.BUS;

namespace Karaoke_1.GUI
{
    public partial class Them_SuaSanPham : MetroForm
    {
        public Them_SuaSanPham()
        {
            InitializeComponent();
        }

        public static bool check = true;
        public static string id_sp, name, unit, index;
        private void btnChapnhan_Click(object sender, EventArgs e)
        {
            if(check) // Them
            {
                if(BUS_SanPham.Instance.ThemSanPham(txtMaSP.Text, txtTenSP.Text, txtDonViTinh.Text) != 0)
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else //Sua
            {
                if (BUS_SanPham.Instance.SuaSanPham(txtIndex.Text, txtMaSP.Text, txtTenSP.Text, txtDonViTinh.Text) != 0)
                {
                    MessageBox.Show("Sửa thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }

        private void Them_SuaSanPham_Load(object sender, EventArgs e)
        {
            txtIndex.Visible = false;
            txtDonViTinh.Text = "";
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            if (check != false) return;
            txtMaSP.Text = id_sp;
            txtDonViTinh.Text = unit;
            txtTenSP.Text = name;
            txtMaSP.ReadOnly = true;
            txtIndex.Text = index;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
