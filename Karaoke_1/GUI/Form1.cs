using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Karaoke_1.DAO;
using Karaoke_1.BUS;

namespace Karaoke_1
{
    public partial class frmTinhTien : Form
    {
        public frmTinhTien()
        {
            InitializeComponent();
        }
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            //Tim();
            ///TinhTien("101");
            ///
            MessageBox.Show(btnTinhTien.BackColor.GetHashCode().ToString());
        }

        private void TinhTien(string maphong)
        {
            int loaiphong;
            DateTime VAO;
            DateTime RA;

            DataTable dt = new DataTable();
            dt = DAO_TinhTien.Instance.LoadThongTinPhong(maphong);

            loaiphong = (int)dt.Rows[0][1];
            VAO = (DateTime)dt.Rows[0][2];
            RA = (DateTime)dt.Rows[0][3];

            int phutvao, phutra;

            phutvao = BUS_TinhTien.Instance.ConvertToMinutes((int)VAO.Hour, (int)VAO.Minute);
            phutra = BUS_TinhTien.Instance.ConvertToMinutes((int)RA.Hour, (int)RA.Minute);
            double tien = 0;

            tien = BUS_TinhTien.Instance.TinhTongTien(phutvao, phutra, loaiphong, maphong);

            tien = BUS_TinhTien.Instance.LamTron(tien);

        }

        private void frmTinhTien_Load(object sender, EventArgs e)
        {

        }

    }
}
