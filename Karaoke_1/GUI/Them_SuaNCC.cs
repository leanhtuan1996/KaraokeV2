using System;
using System.Windows.Forms;
using MetroFramework.Forms;

using Karaoke_1.BUS;

namespace Karaoke_1.GUI
{
    public partial class Them_SuaNCC : MetroForm
    {
        public Them_SuaNCC()
        {
            InitializeComponent();
        }

        public static string mancc, tenncc, sdt, diachi;
        public static bool Check = true; //thêm

        private void Them_SuaNCC_Load(object sender, EventArgs e)
        {
            txtDiachi.Text = "";
            txtMaNCC.Text = "";
            txtSDT.Text = "";
            txtTenNhaCC.Text = "";
            if (Check) return;
            txtMaNCC.ReadOnly = true;
            txtMaNCC.Text = mancc;
            txtTenNhaCC.Text = tenncc;
            txtSDT.Text = sdt;
            txtDiachi.Text = diachi;
        }

        private void btnChapnhan_Click(object sender, EventArgs e)
        {
            if (Check)
            {
                MessageBox.Show(
                    BUS_NhaCC.Instance.ThemNhaCC(txtMaNCC.Text, txtTenNhaCC.Text, txtSDT.Text, txtDiachi.Text) != 0
                        ? "Thêm thành công"
                        : "Thao tác thất bại!");
            }
            else
            {
                MessageBox.Show(
                    BUS_NhaCC.Instance.SuaNhaCC(txtMaNCC.Text, txtTenNhaCC.Text, txtSDT.Text, txtDiachi.Text) != 0
                        ? "Cập nhật thành công"
                        : "Thao tác thất bại!");
            }

            this.Close();
        }
    }
}
