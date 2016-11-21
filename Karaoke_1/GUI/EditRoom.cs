using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Karaoke_1.DTO;
using Karaoke_1.BUS;

namespace Karaoke_1.GUI
{
    public partial class EditRoom : Form
    {
        public EditRoom()
        {
            InitializeComponent();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            txtloaiphong.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txttenphong.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txttrangthai.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtsucchua.Text = listView1.SelectedItems[0].SubItems[4].Text;


        }

        private void EditRoom_Load(object sender, EventArgs e)
        {

        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txttenphong.Text))
            {
                MessageBox.Show("Ten Phong khong duoc rong!");
                txttenphong.Focus();
            }
            else if (string.IsNullOrEmpty(txttrangthai.Text))
            {
                MessageBox.Show("Trang thai Phong khong duoc rong!");
                txttrangthai.Focus();
            }
            else if (string.IsNullOrEmpty(txtsoluongthem.Text))
            {
                MessageBox.Show("So luong khong duoc rong!");
                txtsoluongthem.Focus();
            }
            else if (string.IsNullOrEmpty(txtloaiphong.Text))
            {
                MessageBox.Show("Loai phong khong duoc rong!");
                txtloaiphong.Focus();
            }
            else if (string.IsNullOrEmpty(txtsucchua.Text))
            {
                MessageBox.Show("Suc chua khong duoc rong!");
                txtsucchua.Focus();
            }
            else if (string.IsNullOrEmpty(txttang.Text))
            {
                MessageBox.Show("Tang khong duoc rong!");
                txttang.Focus();
            }
            else
            {

            }
        }
    }
}
