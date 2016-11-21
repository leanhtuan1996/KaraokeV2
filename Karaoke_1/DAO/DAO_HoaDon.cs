using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke_1.DAO
{
    class DAO_HoaDon
    {
        static DAO_HoaDon instance;

        public static DAO_HoaDon Instance
        {
            get { return instance ?? (instance = new DAO_HoaDon()); }
        }

        public string GetMaHoaDon()
        {
            return (string)DataProvider.Instance.ExecuteScalar_SP("GetMaHoaDon");
        }

        public int Insert_Bill(string id, DateTime ngayxuat, string id_room, string id_user, DateTime giovao, int tienhat, int tiendichvu, int giamgia, string phuthu, int tongtien)
        {
            SqlParameter[] arr = new SqlParameter[10];

            arr[0] = new SqlParameter("@id", SqlDbType.VarChar, 10) { Value = id };

            arr[1] = new SqlParameter("@ngayxuat", SqlDbType.DateTime) { Value = ngayxuat };

            arr[2] = new SqlParameter("@id_room", SqlDbType.VarChar, 15) { Value = id_room };

            arr[3] = new SqlParameter("@id_user", SqlDbType.VarChar, 50) { Value = id_user };

            arr[4] = new SqlParameter("@giovao", SqlDbType.DateTime) { Value = giovao };

            arr[5] = new SqlParameter("@tienhat", SqlDbType.Int) { Value = tienhat };

            arr[6] = new SqlParameter("@tiendichvu", SqlDbType.Int) { Value = tiendichvu };

            arr[7] = new SqlParameter("@giamgia", SqlDbType.Int) { Value = giamgia };

            arr[8] = new SqlParameter("@phuthu", SqlDbType.VarChar, 50) { Value = phuthu };

            arr[9] = new SqlParameter("@tongtien", SqlDbType.Int) { Value = tongtien };

            return DataProvider.Instance.ExecuteNonQuery_SP("Insert_Bill", arr);
        }

        public int Insert_BillDetail(string id, string name_menu, int dongia, int soluong)
        {
            SqlParameter[] arr = new SqlParameter[4];

            arr[0] = new SqlParameter("id", SqlDbType.VarChar, 10) { Value = id };

            arr[1] = new SqlParameter("name_menu", SqlDbType.NVarChar, 50) { Value = name_menu };

            arr[2] = new SqlParameter("dongia", SqlDbType.Int) { Value = dongia };

            arr[3] = new SqlParameter("soluong", SqlDbType.Int) { Value = soluong };

            return DataProvider.Instance.ExecuteNonQuery_SP("Insert_BillDetail", arr);

        }

        public SqlDataReader GetDatePhuThu()
        {
            return DataProvider.Instance.EXCUTEREADE_SP("GetDatePhuThu");
        }
    }
}
