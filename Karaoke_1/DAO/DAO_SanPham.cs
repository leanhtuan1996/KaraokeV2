using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using Karaoke_1.DTO;

namespace Karaoke_1.DAO
{
    class DAO_SanPham
    {
        static DAO_SanPham instance;

        public static DAO_SanPham Instance
        {
            get { return instance ?? (instance = new DAO_SanPham()); }
        }

        //Get info KHO to datagridview
        public DataTable GetInFoKho()
        {
            return DataProvider.Instance.ExecuteQuery_SP("sp_GetInfoKho");
        }

        public int ThemSanPham(string id, string name, string unit)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@id", SqlDbType.VarChar, 15) {Value = id};

            para[1] = new SqlParameter("@name_product", SqlDbType.NVarChar, 50) {Value = name};

            para[2] = new SqlParameter("@unit", SqlDbType.NVarChar, 10) {Value = unit};

            return DataProvider.Instance.ExecuteNonQuery_SP("sp_insertProduct", para);

        }

        public int SuaSanPham(string index, string id, string name, string unit)
        {
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@id", SqlDbType.VarChar, 15) {Value = id};

            para[1] = new SqlParameter("@name_product", SqlDbType.NVarChar, 50) {Value = name};

            para[2] = new SqlParameter("@unit", SqlDbType.NVarChar, 10) {Value = unit};

            para[3] = new SqlParameter("@index", SqlDbType.Int){Value = index};

            return DataProvider.Instance.ExecuteNonQuery_SP("sp_EditProduct", para);

        }

        public int XoaSanPham(string id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@id", SqlDbType.VarChar, 15) {Value = id};

            return DataProvider.Instance.ExecuteNonQuery_SP("sp_XoaSanPham_ID", para);

        }

    }
}
