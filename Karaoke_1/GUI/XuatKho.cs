using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;

using Karaoke_1.BUS;
using Karaoke_1.DTO;

namespace Karaoke_1.GUI
{
    public partial class XuatKho : MetroForm
    {
        public XuatKho()
        {
            InitializeComponent();
        }

        private void XuatKho_Load(object sender, EventArgs e)
        {
            cmbTenSanPham.DataSource = new BindingSource(MainRooms.LstProducts, null);
            cmbTenSanPham.DisplayMember = "name";
            cmbTenSanPham.ValueMember = "id";
            cmbTenSanPham.SelectedIndex = 0;
            cmbTenSanPham_SelectionChangeCommitted(sender, e);
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txtSoluong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back) return;
            if (txtSoluong.Text.Length == 0) return;
            txtSoluong.Text = txtSoluong.Text.Remove(txtSoluong.Text.Length - 1);
            txtSoluong.Select(txtSoluong.Text.Length, 1);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string[] arr = new string[6];

            arr[0] = cmbTenSanPham.Text;
            arr[1] = cmbUnit.Text;
            arr[2] = txtSoluong.Text;
            arr[3] = cmbNhaCungCap.Text;
            arr[4] = cmbNhaCungCap.SelectedValue.ToString();
            arr[5] = cmbTenSanPham.SelectedValue.ToString();
            if (!KiemTraSoLuong(arr[5]))
            {
                MessageBox.Show("Số lượng vừa nhập không hợp lệ!");
                txtSoluong.Focus();
                return;
            }
            else
            {
                ListViewItem item = new ListViewItem(arr);
                lstSanPhamXuat.Items.Add(item);
                txtSoluong.Clear();
                txtMaXuat.ReadOnly = true;
            }
        }
        
        bool KiemTraSoLuong(string masp)
        {
            float soluong = BUS_NhapXuatKho.Instance.SoLuongSanPham(masp);

            return !(float.Parse(txtSoluong.Text) > soluong);

            //if (float.Parse(txtSoluong.Text) > soluong) //nếu nó lớn hơn số lượng có trong kho thì báo lỗi
            //{
            //    return false;
            //}
            //return true;
        }

        bool KiemTraTrung(string masp)
        {
            for (int i = 0; i < lstSanPhamXuat.Items.Count; i++)
            {
                if (masp == lstSanPhamXuat.Items[i].SubItems[3].Text)
                {
                    return false;
                }
            }

            return true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstSanPhamXuat_Click(object sender, EventArgs e)
        {
            int chisodong = lstSanPhamXuat.Items.IndexOf(lstSanPhamXuat.SelectedItems[0]);
            cmbTenSanPham.SelectedValue = lstSanPhamXuat.Items[chisodong].SubItems[3].Text;
            txtSoluong.Text = lstSanPhamXuat.Items[chisodong].SubItems[2].Text;
        }

        private void lstSanPhamXuat_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            if (lstSanPhamXuat.FocusedItem.Bounds.Contains(e.Location) == true)
            {
                ctmChinhSuaList.Show(Cursor.Position);
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idx = lstSanPhamXuat.Items.IndexOf(lstSanPhamXuat.SelectedItems[0]);
            lstSanPhamXuat.Items.RemoveAt(idx);
        }
        
        private void cmbTenSanPham_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbUnit.Items.Clear();
            foreach (var item in MainRooms.LstProducts.Where(t => t.id == cmbTenSanPham.SelectedValue.ToString()))
            {
                cmbUnit.Items.Add(item.unit);
            }
            cmbUnit.SelectedIndex = 0;
            cmbUnit_SelectionChangeCommitted(sender, e);
        }
        private void cmbUnit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //cmbNhaCungCap.Items.Clear();
            string id_ncc = "";
            foreach(var item in MainRooms.LstProducts)
            {
                if (item.id == cmbTenSanPham.SelectedValue && item.unit == cmbUnit.Text)
                {
                    id_ncc = item.id_ncc;
                }
            }

            DataTable dt = BUS_NhapXuatKho.Instance.GetIDNhaCC_ID(id_ncc);

            cmbNhaCungCap.DataSource = dt;
            cmbNhaCungCap.DisplayMember = "name";
            cmbNhaCungCap.ValueMember = "id";
            cmbNhaCungCap.SelectedIndex = 0;

            

        }
        private void btnXuatKho_Click(object sender, EventArgs e)
        {
            int kq = 0;

            DateTime ngayxuat = dtpNgayXuat.Value;
            string maxuat = txtMaXuat.Text;

            for (int i = 0; i < lstSanPhamXuat.Items.Count; i++)
            {
                kq = BUS_NhapXuatKho.Instance.XuatKho(lstSanPhamXuat.Items[i].SubItems[0].Text,
                    lstSanPhamXuat.Items[i].SubItems[1].Text, lstSanPhamXuat.Items[i].SubItems[4].Text, maxuat,
                    lstSanPhamXuat.Items[i].SubItems[5].Text, float.Parse(lstSanPhamXuat.Items[i].SubItems[2].Text),
                    ngayxuat);

            }

            if (kq != 0)
            {

                MessageBox.Show("Xuất kho thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thao tác thất bại");
            }
        }

    }
}
