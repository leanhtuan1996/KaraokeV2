using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using HPTCMessageBox;

using Karaoke_1.BUS;

namespace Karaoke_1.GUI
{
    public partial class NhapKho : MetroForm
    {
        public NhapKho()
        {
            InitializeComponent();
        }

        private void btnThemNhaCungCap_Click(object sender, EventArgs e)
        {
            Them_SuaNCC.Check = true;            
            Them_SuaNCC them = new Them_SuaNCC();
            them.Text = "Thêm nhà cung cấp";
            them.ShowDialog();
            GetNCC();
        }

        private void NhapKho_Load(object sender, EventArgs e)
        {
            cmbTenSanPham.DataSource = new BindingSource(MainRooms.LstProducts, null);
            cmbTenSanPham.DisplayMember = "name";
            cmbTenSanPham.ValueMember = "id";
            cmbTenSanPham.SelectedIndex = 0;

            cmbTenSanPham_SelectionChangeCommitted(sender, e);

            //Get info nhà cung cấp

            GetNCC();
        }

        private void GetNCC()
        {
            DataTable namencc = BUS_NhapXuatKho.Instance.GetIDNhaCC();

            cmbNhaCungCap.DataSource = namencc;
            cmbNhaCungCap.DisplayMember = "name";
            cmbNhaCungCap.ValueMember = "id";
            cmbNhaCungCap.SelectedIndex = 0;
        }

        private void btnThemvaoList_Click(object sender, EventArgs e)
        {

            string[] arr1 = new string[7];
            arr1[0] = cmbTenSanPham.Text;
            arr1[1] = cmbUnit.Text;
            arr1[2] = txtSoluong.Text;
            arr1[3] = txtGianhap.Text;
            arr1[4] = cmbNhaCungCap.Text;
            arr1[5] = cmbNhaCungCap.SelectedValue.ToString();  //id_NCC
            arr1[6] = cmbTenSanPham.SelectedValue.ToString(); //Id_product

            ListViewItem item = new ListViewItem(arr1);
            lstSP.Items.Add(item);

            MessageBox.Show(arr1[5]);
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            string id = txtMaNhap.Text;
            DateTime ngaynhap = dtpNgayNhap.Value;
            int check = 0;
            for(int i = 0; i < lstSP.Items.Count; i++)
            {
                string masanpham = lstSP.Items[i].SubItems[6].Text;
                string donvitinh = lstSP.Items[i].SubItems[1].Text;
                float soluong = float.Parse(lstSP.Items[i].SubItems[2].Text);
                string dongia = lstSP.Items[i].SubItems[3].Text;
                string id_nhacungcap = lstSP.Items[i].SubItems[5].Text;
                check = BUS_NhapXuatKho.Instance.NhapKho(id, ngaynhap, masanpham, donvitinh, soluong, dongia, id_nhacungcap);
            }

            if(check != 0)
            {
                MessageBox.Show("Nhập kho thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Nhập kho thất bại");
            }
        }

        private void cmbTenSanPham_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbUnit.Items.Clear();
            foreach (var item in MainRooms.LstProducts.Where(t => t.id == cmbTenSanPham.SelectedValue.ToString()))
            {
                cmbUnit.Items.Add(item.unit);
            }

            cmbUnit.SelectedIndex = 0;
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstSP_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            if (lstSP.FocusedItem.Bounds.Contains(e.Location) == true)
            {
                ctmChinhSuaList.Show(Cursor.Position);
            }
        }

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idx = lstSP.Items.IndexOf(lstSP.SelectedItems[0]);
            lstSP.Items.RemoveAt(idx);
        }
    }
}
