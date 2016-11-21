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
    class DAO_Menu
    {
        static DAO_Menu instance;

        public static DAO_Menu Instance
        {
            get { return instance ?? (instance = new DAO_Menu()); }
        }

        public DataTable sp_GetMenu()
        {
            return DataProvider.Instance.ExecuteQuery_SP("sp_GetMenu");
        }

        public DataTable sp_Menu_GetUnit_Name(string name)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50) {Value = name};

            return DataProvider.Instance.ExecuteQuery_SP("sp_Menu_GetUnit_Name", para);
        }

        public int sp_ThemDichVu(string name, string unit, int price, string description)
        {
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50) {Value = name};

            para[1] = new SqlParameter("@unit", SqlDbType.NVarChar, 10) {Value = unit};

            para[2] = new SqlParameter("@price", SqlDbType.Int) {Value = price};

            para[3] = new SqlParameter("@description", SqlDbType.NVarChar, 100) {Value = description};

            return DataProvider.Instance.ExecuteNonQuery_SP("sp_ThemDichVu", para);
        }

        public int sp_XoaDichVu(string name)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50) {Value = name};

            return DataProvider.Instance.ExecuteNonQuery_SP("sp_xoadichvu", para);
        }

        public int sp_SuaDichVu(string name, string unit, int price, string description)
        {
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50) {Value = name};

            para[1] = new SqlParameter("@unit", SqlDbType.NVarChar, 10) {Value = unit};

            para[2] = new SqlParameter("@price", SqlDbType.Int) {Value = price};

            para[3] = new SqlParameter("@description", SqlDbType.NVarChar, 100) {Value = description};

            return DataProvider.Instance.ExecuteNonQuery_SP("sp_ChinhSuaDichVu", para);
        }

        internal int sp_Menu_GetPrice_Name(string name)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50) {Value = name};

            return (int)DataProvider.Instance.ExecuteScalar_SP("sp_Menu_GetPrice_Name", para);
        }

        internal int sp_Menu_GetPrice_Unit_Name(string name, string unit)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50){Value = name};
            para[1] = new SqlParameter("@unit", SqlDbType.NVarChar, 10){Value = unit};

            return (int) DataProvider.Instance.ExecuteScalar_SP("sp_Menu_GetPrice_Unit_Name", para);
        }

        public DataTable sp_GetMenu_ThemDV()
        {
            return DataProvider.Instance.ExecuteQuery_SP("sp_GetMenu_ThemDV");
        }
    }
}
