using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using HPTCMessageBox;

using Karaoke_1.BUS;

namespace Karaoke_1.GUI
{
    public partial class NhaCungCap : MetroForm
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            dgvNhaCungCap.DataSource = BUS_NhaCC.Instance.GetInFoNhaCC();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them_SuaNCC frm = new Them_SuaNCC();
            frm.Text = "Thêm nhà cung cấp";
            frm.ShowDialog();
            NhaCungCap_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhaCungCap.Rows.Count <= 0) return;
            if (dgvNhaCungCap.CurrentRow != null)
            {
                string id = dgvNhaCungCap.CurrentRow.Cells[0].Value.ToString();

                if (BUS_NhaCC.Instance.XoaNhaCC(id) != 0)
                {
                    MessageBox.Show("Xóa thành công");
                    NhaCungCap_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thao tác thất bại!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them_SuaNCC frm = new Them_SuaNCC {Text = "Sửa nhà cung cấp"};
            if (dgvNhaCungCap.Rows.Count <= 0) return;
            if (dgvNhaCungCap.CurrentRow != null)
            {
                Them_SuaNCC.mancc = dgvNhaCungCap.CurrentRow.Cells[0].Value.ToString();
                Them_SuaNCC.tenncc = dgvNhaCungCap.CurrentRow.Cells[1].Value.ToString();
                Them_SuaNCC.sdt = dgvNhaCungCap.CurrentRow.Cells[2].Value.ToString();
                Them_SuaNCC.diachi = dgvNhaCungCap.CurrentRow.Cells[3].Value.ToString();
            }
            Them_SuaNCC.Check = false;

                
            frm.ShowDialog();

            NhaCungCap_Load(sender, e);
        }
    }
}
