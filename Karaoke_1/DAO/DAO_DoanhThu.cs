using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke_1.DAO
{
    class DAO_DoanhThu
    {
        static DAO_DoanhThu instance;

        public static DAO_DoanhThu Instance
        {
            get { return instance ?? (instance = new DAO_DoanhThu()); }
        }

        public void XemDoanhThu(int loai, DateTime ngay, ref decimal nhapkho, ref decimal hoadon, ref decimal chiphikhac, ref decimal luong)
        {
            SqlParameter[] arr = new SqlParameter[6];

            arr[0] = new SqlParameter("@loai", SqlDbType.Int);
            arr[0].Value = loai;

            arr[1] = new SqlParameter("@ngay", SqlDbType.DateTime);
            arr[1].Value = ngay;

            arr[2] = new SqlParameter("@nhapkho", SqlDbType.Decimal, 18);
            arr[2] = new SqlParameter("@nhapkho", SqlDbType.Decimal, 18);
            arr[2].Direction = ParameterDirection.Output;

            arr[3] = new SqlParameter("@hoadon", SqlDbType.Decimal, 18);
            arr[3] = new SqlParameter("@hoadon", SqlDbType.Decimal, 18);
            arr[3].Direction = ParameterDirection.Output;

            arr[4] = new SqlParameter("@chiphikhac", SqlDbType.Decimal, 18);
            arr[4] = new SqlParameter("@chiphikhac", SqlDbType.Decimal, 18);
            arr[4].Direction = ParameterDirection.Output;

            arr[5] = new SqlParameter("@luong", SqlDbType.Decimal, 18);
            arr[5] = new SqlParameter("@luong", SqlDbType.Decimal, 18);
            arr[5].Direction = ParameterDirection.Output;

            DataProvider.Instance.ExecuteNonQuery_SP("ThongKeDoanhThu", arr);

            nhapkho = Convert.ToDecimal(arr[2].Value); ;
            hoadon = Convert.ToDecimal(arr[3].Value);
            chiphikhac = Convert.ToDecimal(arr[4].Value);
            luong = Convert.ToDecimal(arr[5].Value);
        }

    }
}
