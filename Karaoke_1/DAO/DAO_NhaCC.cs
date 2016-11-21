using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Karaoke_1.DAO
{
    class DAO_NhaCC
    {
        static DAO_NhaCC instance;

        public static DAO_NhaCC Instance
        {
            get { return instance ?? (instance = new DAO_NhaCC()); }
        }

        public DataTable GetInFoNhaCC()
        {
            return DataProvider.Instance.ExecuteQuery_SP("GetInFoNhaCC");
        }


        public int ThemNhaCC(string mancc, string tenncc, string sdt, string diachi)
        {
            SqlParameter[] arr = new SqlParameter[4];

            arr[0] = new SqlParameter("@mancc", SqlDbType.VarChar, 10) {Value = mancc};

            arr[1] = new SqlParameter("@tenncc", SqlDbType.NVarChar, 50) {Value = tenncc};

            arr[2] = new SqlParameter("@sdt", SqlDbType.VarChar, 15) {Value = sdt};

            arr[3] = new SqlParameter("@diachi", SqlDbType.NVarChar, 100) {Value = diachi};

            return DataProvider.Instance.ExecuteNonQuery_SP("ThemNhaCC", arr);

        }

        public int SuaNhaCC(string mancc, string tenncc, string sdt, string diachi)
        {
            SqlParameter[] arr = new SqlParameter[4];

            arr[0] = new SqlParameter("@mancc", SqlDbType.VarChar, 10) {Value = mancc};

            arr[1] = new SqlParameter("@tenncc", SqlDbType.NVarChar, 50) {Value = tenncc};

            arr[2] = new SqlParameter("@sdt", SqlDbType.VarChar, 15) {Value = sdt};

            arr[3] = new SqlParameter("@diachi", SqlDbType.NVarChar, 100) {Value = diachi};

            return DataProvider.Instance.ExecuteNonQuery_SP("SuaNhaCC", arr);

        }

        public int XoaNhaCC(string id)
        {
            SqlParameter[] arr = new SqlParameter[1];

            arr[0] = new SqlParameter("@id", SqlDbType.VarChar, 10) {Value = id};

            return DataProvider.Instance.ExecuteNonQuery_SP("XoaNhaCC", arr);
        }
    }
}
