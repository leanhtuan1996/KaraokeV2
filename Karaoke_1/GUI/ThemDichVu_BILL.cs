using System;
using System.Data;
using System.Windows.Forms;
using HPTCMessageBox;
using MetroFramework.Forms;
using Karaoke_1.BUS;
namespace Karaoke_1.GUI
{
    public partial class Them_SuaDichVu_BILL : MetroForm
    {
        public Them_SuaDichVu_BILL()
        {
            InitializeComponent();
        }

        private void Them_SuaDichVu_BILL_Load(object sender, EventArgs e)
        {
            DataTable dt = BUS_Menu.Instance.sp_GetMenu_ThemDV();
            
            cmbTenDVHienCo_BILL.DataSource = dt;
            cmbTenDVHienCo_BILL.DisplayMember = "name";
            cmbTenDVHienCo_BILL.ValueMember = "name";
            cmbTenDVHienCo_BILL.SelectedIndex = -1;
        }

        private void cmbTenDVHienCo_BILL_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable unit = BUS_Menu.Instance.sp_GetUnit_Menu(cmbTenDVHienCo_BILL.SelectedValue.ToString());
            int price = BUS_Menu.Instance.sp_GetPrice_Menu(cmbTenDVHienCo_BILL.SelectedValue.ToString());
            cmbDonViTinh_ThemDV.DataSource = unit;
            cmbDonViTinh_ThemDV.DisplayMember = "unit";
            cmbDonViTinh_ThemDV.ValueMember = "unit";
            txtDonGiaDV_BILL.Text = price.ToString();
        }

        private void btnThemDV_BILL_Click(object sender, EventArgs e)
        {
            MainRooms.CHECK_HUY = false;
            string[] arr = new string[4];
            arr[0] = cmbTenDVHienCo_BILL.SelectedValue.ToString();
            arr[1] = txtDonGiaDV_BILL.Text;
            arr[2] = txtSoLuongDV_BILL.Text;
            arr[3] = (int.Parse(txtDonGiaDV_BILL.Text)*int.Parse(txtSoLuongDV_BILL.Text)).ToString();

            MainRooms.lsvItemBILL = new ListViewItem(arr);
            this.Close();
        }

        private void btnHuyDV_BILL_Click(object sender, EventArgs e)
        {
            MainRooms.CHECK_HUY = true;
            this.Close();
        }

        private void cmbDonViTinh_ThemDV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int price = BUS_Menu.Instance.sp_GetPrice_Unit_Name(cmbTenDVHienCo_BILL.Text,cmbDonViTinh_ThemDV.SelectedValue.ToString());

            txtDonGiaDV_BILL.Text = price.ToString();
        }
    }
}
