using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke_1.DAO
{
    class DAO_PhuThu
    {
        static DAO_PhuThu instance;

        public static DAO_PhuThu Instance
        {
            get { return instance ?? (instance = new DAO_PhuThu()); }
        }

        public SqlDataReader GetPhuThu()
        {
            return DataProvider.Instance.EXCUTEREADE_SP("GetPhuThu");
        }

        public int Insert_PhuThu(DateTime ngay, int percent, string description)
        {
            SqlParameter[] arr = new SqlParameter[3];

            arr[0] = new SqlParameter("@ngay", SqlDbType.Date);
            arr[0].Value = ngay;

            arr[1] = new SqlParameter("@percent", SqlDbType.Int);
            arr[1].Value = percent;

            arr[2] = new SqlParameter("description", SqlDbType.NText);
            arr[2].Value = description == null ? "-" : description;

            return DataProvider.Instance.ExecuteNonQuery_SP("Insert_PhuThu", arr);
        }

        public int Del_PhuThu(DateTime ngay)
        {
            SqlParameter[] arr = new SqlParameter[1];

            arr[0] = new SqlParameter("@ngay", SqlDbType.Date);
            arr[0].Value = ngay;

            return DataProvider.Instance.ExecuteNonQuery_SP("Del_PhuThu", arr);
        }
    }
}
