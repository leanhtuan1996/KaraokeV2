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
using System.Data.SqlClient;

using Karaoke_1.BUS;

namespace Karaoke_1.GUI
{
    public partial class frmThongKeKho : MetroForm
    {
        public frmThongKeKho()
        {
            InitializeComponent();
        }

        public static int type ;
        public static DateTime ngayto, ngayfrom;

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            cbbLoaiThongKe.Items.Clear();
            cbbLoaiThongKe.Items.Add("Theo ngày");
            cbbLoaiThongKe.Items.Add("Theo tháng");
            cbbLoaiThongKe.Items.Add("Theo năm");

            //dtpNgay_From.Value = ngayfrom;
            //dtpNgay_To.Value = ngayto;
            //cbbLoaiThongKe.SelectedIndex = type;

            //lsvThongKe.Columns.Add("STT", 50);
            //lsvThongKe.Columns.Add("Ngày nhập", 100);
            //lsvThongKe.Columns.Add("Phiếu nhập", 100);
            //lsvThongKe.Columns.Add("Tên SP", 100);
            //lsvThongKe.Columns.Add("ĐVT", 80);
            //lsvThongKe.Columns.Add("Số lượng", 80);
            //lsvThongKe.Columns.Add("Đơn giá", 80);
            //lsvThongKe.Columns.Add("Tên NCC", 100);

            //SqlDataReader rd = BUS_ThongKe.Instance.NhapKho(cbbLoaiThongKe.SelectedIndex, dtpNgay_From.Value, dtpNgay_To.Value);

            //int dem = 1;
            //while(rd.Read())
            //{
            //    ListViewItem item = new ListViewItem(dem.ToString());
            //    item.SubItems.Add((Convert.ToDateTime(rd[0]).ToShortDateString()).ToString());
            //    item.SubItems.Add(rd[1].ToString());
            //    item.SubItems.Add(rd[2].ToString());
            //    item.SubItems.Add(rd[3].ToString());
            //    item.SubItems.Add(rd[4].ToString());
            //    item.SubItems.Add(rd[5].ToString());
            //    item.SubItems.Add(rd[6].ToString());

            //    dem++;

            //    lsvThongKe.Items.Add(item);
            //}

            //mntThongKe.Items
        }



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            tabKho.SelectedTab = tabKho.TabPages[0];

            SqlDataReader rd = BUS_ThongKe.Instance.NhapKho(cbbLoaiThongKe.SelectedIndex, dtpNgay_From.Value, dtpNgay_To.Value);

            int dem = 1;
            while (rd.Read())
            {
                ListViewItem item = new ListViewItem(dem.ToString());
                item.SubItems.Add((Convert.ToDateTime(rd[0]).ToShortDateString()).ToString());
                item.SubItems.Add(rd[1].ToString());
                item.SubItems.Add(rd[2].ToString());
                item.SubItems.Add(rd[3].ToString());
                item.SubItems.Add(rd[4].ToString());
                item.SubItems.Add(rd[5].ToString());
                item.SubItems.Add(rd[6].ToString());

                dem++;

                lsvThongKe.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabKho.SelectedTab = tabKho.TabPages[1];
        }

        private void btnSoLuong_Click(object sender, EventArgs e)
        {
            tabKho.SelectedTab = tabKho.TabPages[2];
        }
    }
}
