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

namespace Karaoke_1.GUI
{
    public partial class frmConnect : MetroForm
    {
        public frmConnect()
        {
            InitializeComponent();
        }

        private void frmConnect_Load(object sender, EventArgs e)
        {
            txtDangNhap.Enabled = false;
            txtMatKhau.Enabled = false;
        }

        private void chkXacThuc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkXacThuc.Checked == true)
            {
                txtDangNhap.Enabled = true;
                txtMatKhau.Enabled = true;
            }
            else
            {
                txtDangNhap.Enabled = false;
                txtMatKhau.Enabled = false;
            }

        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            string strConnect = "";
            if (!chkXacThuc.Checked)
            {
                strConnect = @"Server ="+cbbTenServer.Text+"; Database = Karaoke; Trusted_Connection = True";
            }
            else
            {
                strConnect = @"Server="+cbbTenServer.Text+"; Database= Karaoke; User Id="+txtDangNhap.Text+"; Password="+txtMatKhau.Text+"";
            }

            bool Check = BUS_NameServer.Instance.Check_Connect(strConnect);

            if (Check == true)
            {
                Karaoke_1.Properties.Settings.Default.strConnect = strConnect;
                Karaoke_1.Properties.Settings.Default.Save();
                Console.Beep();
                MessageBox.Show("Kết nối thành công.");

                this.Visible = false;
                frmLogin frmmain = new frmLogin();
                frmmain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kết nối không hợp lệ. Vui lòng kiểm tra lại!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            cbbTenServer.DataSource = BUS_NameServer.Instance.GetName();
            cbbTenServer.DisplayMember = "ServerName";
        }
    }
}
