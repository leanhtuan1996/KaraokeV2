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
    public partial class frmThongKeThuChi : MetroForm
    {
        public static int type = 0;//ngày, tháng or năm, mặc định là ngày
        public static int type_load = 0; //type_load
        public static DateTime ngayfrom, ngayto;

        public frmThongKeThuChi()
        {
            InitializeComponent();
        }

        void SetToolTip(ListViewItem item, SqlDataReader rd)
        {
            //toolTipHoaDon.SetToolTip(item, "ABC");

            //toolTipHoaDon.Active = true;
            //toolTipHoaDon.IsBalloon = true;
            //toolTipHoaDon.ShowAlways = true;

            //toolTipHoaDon.SetToolTip(item, toolTipHoaDon.GetToolTip(item) + "Tên dịch vụ: " + rd[1].ToString + ", Số lượng: " + rd[2].ToString());

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            if (dtpNgay_From.Value > dtpNgay_To.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!");
                return;
            }

            tabThuChi.SelectedTab = tabThuChi.TabPages[0];

            lsvHoaDon.Items.Clear();

            int dem = 1;

            SqlDataReader rd = BUS_ThongKe.Instance.HoaDon(cbbLoaiThongKe.SelectedIndex, dtpNgay_From.Value, dtpNgay_To.Value);

            while(rd.Read())
            {
                ListViewItem item = new ListViewItem(dem.ToString());

                item.SubItems.Add(rd[0].ToString());
                item.SubItems.Add(rd[1].ToString());
                item.SubItems.Add(rd[2].ToString());
                item.SubItems.Add(rd[3].ToString());
                item.SubItems.Add(rd[4].ToString());
                item.SubItems.Add(rd[5].ToString());
                item.SubItems.Add(String.Format("{0:0,0}", rd[6]));
                item.SubItems.Add(String.Format("{0:0,0}", rd[7]));
                item.SubItems.Add(String.Format("{0:0,0}", rd[8]));
                item.SubItems.Add(rd[9].ToString());
                item.SubItems.Add(String.Format("{0:0,0}", rd[10]));

                lsvHoaDon.Items.Add(item);

                dem++;
            }
        }

        private void ThongKeThuChi_Load(object sender, EventArgs e)
        {
            cbbLoaiThongKe.Items.Clear();
            cbbLoaiThongKe.Items.Add("Theo ngày");
            cbbLoaiThongKe.Items.Add("Theo tháng");
            cbbLoaiThongKe.Items.Add("Theo năm");

            cbbLoaiThongKe.SelectedIndex = type;

            dtpNgay_From.Value = ngayfrom;
            dtpNgay_To.Value = ngayto;

            //if(type_load == 3)
            //{
            //    btnCPK_Click(sender, e);
            //}

            //else if(type_load == 5)
            //{
            //    btnHoaDon_Click(sender, e);
            //}
        }

     

        private void lsvHoaDon_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            string mahoadon = e.Item.SubItems[1].Text;

            //MessageBox.Show(mahoadon);

            SqlDataReader rd = BUS_ThongKe.Instance.ChiTietHoaDon(mahoadon); 

            while(rd.Read())
            {
                
                //toolTipHoaDon.SetToolTip(e as Control, "Chi Tiết Hóa Đơn");
                //toolTipHoaDon.Active = true;
                //toolTipHoaDon.IsBalloon = true;
                //toolTipHoaDon.ShowAlways = true;
                
                //toolTipHoaDon.SetToolTip(e as Control, toolTipHoaDon.GetToolTip(e as Control) + "\nTên dịch vụ: " + rd[1].ToString() + ", Đơn giá: " + rd[2].ToString() + ", Số lượng: " + rd[2].ToString());
            }
        }

        private void lsvHoaDon_MouseClick(object sender, MouseEventArgs e)
        {

        }

        public void btnCPK_Click(object sender, EventArgs e)
        {
            if (dtpNgay_From.Value > dtpNgay_To.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!");
                return;
            }

            lsvCPK.Items.Clear();

            int dem = 1;

            tabThuChi.SelectedTab = tabThuChi.TabPages[1];

            SqlDataReader rd = BUS_ThongKe.Instance.ChiPhiKhac(cbbLoaiThongKe.SelectedIndex, dtpNgay_From.Value, dtpNgay_To.Value);

            while(rd.Read())
            {
                ListViewItem item = new ListViewItem(dem.ToString());

                item.SubItems.Add(Convert.ToDateTime(rd[0]).ToString());
                item.SubItems.Add(rd[1].ToString());
                item.SubItems.Add(String.Format("{0:0,0}", rd[2]));

                lsvCPK.Items.Add(item);

                dem++;
            }
        }
    }
}
