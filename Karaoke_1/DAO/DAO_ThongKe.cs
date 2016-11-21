using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke_1.DAO
{
    class DAO_ThongKe
    {
        static DAO_ThongKe instance;

        public static DAO_ThongKe Instance
        {
            get { return instance ?? (instance = new DAO_ThongKe()); }
        }

        public SqlDataReader ThongKeNhapKho(int loai, DateTime ngayfrom, DateTime ngayto)
        {
            SqlParameter[] arr = new SqlParameter[3];

            arr[0] = new SqlParameter("@loai", SqlDbType.Int);
            arr[0].Value = loai;

            arr[1] = new SqlParameter("@ngayfrom", SqlDbType.Date);
            arr[1].Value = ngayfrom;

            arr[2] = new SqlParameter("@ngayto", SqlDbType.Date);
            arr[2].Value = ngayto;

            return DataProvider.Instance.EXCUTEREADE_SP("ThongKeNhapKho", arr);
        }

        public SqlDataReader HoaDon(int loai, DateTime ngayfrom, DateTime ngayto)
        {
            SqlParameter[] arr = new SqlParameter[3];

            arr[0] = new SqlParameter("@loai", SqlDbType.Int);
            arr[0].Value = loai;

            arr[1] = new SqlParameter("@ngayfrom", SqlDbType.Date);
            arr[1].Value = ngayfrom;

            arr[2] = new SqlParameter("@ngayto", SqlDbType.Date);
            arr[2].Value = ngayto;

            return DataProvider.Instance.EXCUTEREADE_SP("HoaDon", arr);
        }

        public SqlDataReader ChiTietHoaDon(string mahoadon)
        {
            SqlParameter[] arr = new SqlParameter[1];

            arr[0] = new SqlParameter("@mahoadon", SqlDbType.VarChar, 10);
            arr[0].Value = mahoadon;

            return DataProvider.Instance.EXCUTEREADE_SP("Get_ChiTietHoaDon", arr);
        }

        public SqlDataReader ChiPhiKhac(int loai, DateTime ngayfrom, DateTime ngayto)
        {
            SqlParameter[] arr = new SqlParameter[3];

            arr[0] = new SqlParameter("@loai", SqlDbType.Int);
            arr[0].Value = loai;

            arr[1] = new SqlParameter("@ngayfrom", SqlDbType.Date);
            arr[1].Value = ngayfrom;

            arr[2] = new SqlParameter("@ngayto", SqlDbType.Date);
            arr[2].Value = ngayto;

            return DataProvider.Instance.EXCUTEREADE_SP("ThongKeCPK", arr);
        }
    }
}
