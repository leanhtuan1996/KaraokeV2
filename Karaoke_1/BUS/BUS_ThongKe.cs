using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Karaoke_1.DAO;
using System.Data.SqlClient;

namespace Karaoke_1.BUS
{
    class BUS_ThongKe
    {
        static BUS_ThongKe instance;

        public static BUS_ThongKe Instance
        {
            get { return instance ?? (instance = new BUS_ThongKe()); }
        }

        public SqlDataReader NhapKho(int loai, DateTime ngayfrom, DateTime ngayto)
        {
            return DAO_ThongKe.Instance.ThongKeNhapKho(loai, ngayfrom, ngayto);
        }


        public SqlDataReader HoaDon(int loai, DateTime ngayfrom, DateTime ngayto)
        {
            return DAO_ThongKe.Instance.HoaDon(loai, ngayfrom, ngayto);
        }

        public SqlDataReader ChiTietHoaDon(string mahoadon)
        {
            return DAO_ThongKe.Instance.ChiTietHoaDon(mahoadon);
        }

        public SqlDataReader ChiPhiKhac(int loai, DateTime ngayfrom, DateTime ngayto)
        {
            return DAO_ThongKe.Instance.ChiPhiKhac(loai, ngayfrom, ngayto);
        }
    }
}
