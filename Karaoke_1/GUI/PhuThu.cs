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

using Karaoke_1.BUS;
using System.Data.SqlClient;

namespace Karaoke_1.GUI
{
    public partial class frmPhuThu : MetroForm
    {
        public frmPhuThu()
        {
            InitializeComponent();
        }

        private void PhuThu_Load(object sender, EventArgs e)
        {
            lsvPhuThu.Items.Clear();

            SqlDataReader rd = BUS_PhuThu.Instance.GetPhuThu();

            int dem = 1;
            
            while(rd.Read())
            {
                ListViewItem item = new ListViewItem(dem.ToString());

                item.SubItems.Add(Convert.ToDateTime(rd[0]).ToShortDateString());

                item.SubItems.Add(rd[1].ToString());

                item.SubItems.Add(rd[2].ToString());

                lsvPhuThu.Items.Add(item);

                dem++;
            }

            if(lsvPhuThu.Items.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu!");
                return;
            }
        }

        bool KiemTraPhuThu(DateTime ngay)
        {
            SqlDataReader rd = BUS_PhuThu.Instance.GetPhuThu();

            int dem = 1;

            while (rd.Read())
            {
                if (Convert.ToDateTime(rd[0]).Date == ngay.Date)
                    return false;
            }

            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(!KiemTraPhuThu(dtpNgay.Value))
            {
                MessageBox.Show("Ngày này đã tồn tại trong danh sách!");
                return;
            }

            int kq = BUS_PhuThu.Instance.Insert_PhuThu(dtpNgay.Value, Convert.ToInt32(txtPhanTramPhuThu.Text), txtLiDoPhuThu.Text);

            if (kq != 0)
            {
                MessageBox.Show("Thêm thành công!");
                PhuThu_Load(sender, e);
            }
            else
                MessageBox.Show("Thao tác thất bại!");
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {            

            int idx = lsvPhuThu.Items.IndexOf(lsvPhuThu.SelectedItems[0]);

            DateTime ngay = Convert.ToDateTime(lsvPhuThu.Items[idx].SubItems[1].Text);

            int kq = BUS_PhuThu.Instance.Del_PhuThu(ngay);

            if (kq != 0)
            {
                MessageBox.Show("Xóa thành công");
                lsvPhuThu.Items.RemoveAt(idx);
                PhuThu_Load(sender, e);
            }
                
            else
                MessageBox.Show("Thao thác thất bại!");
        }

        private void lsvPhuThu_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            if(lsvPhuThu.FocusedItem.Bounds.Contains(e.Location) == true)
            {
                cmtPhuThu.Show(Cursor.Position);
            }
        }

        private void txtPhanTramPhuThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }

        private void txtPhanTramPhuThu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back) return;
            if (txtPhanTramPhuThu.Text.Length == 0) return;
            txtPhanTramPhuThu.Text = txtPhanTramPhuThu.Text.Remove(txtPhanTramPhuThu.Text.Length - 1);
            txtPhanTramPhuThu.Select(txtPhanTramPhuThu.Text.Length, 1);
        }


    }
}
