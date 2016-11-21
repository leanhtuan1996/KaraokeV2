using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke_1.DAO
{
    public class DAO_NhapXuatKho
    {
        static DAO_NhapXuatKho instance;

        internal static DAO_NhapXuatKho Instance
        {
            get { return instance ?? (instance = new DAO_NhapXuatKho()); }
        }
        
        public DataTable GetIDNhaCC()
        {
            return DataProvider.Instance.ExecuteQuery_SP("sp_GetIDNhaCC");
        }

        public int NhapKho(string id, DateTime ngaynhap, string tensanpham, string donvitinh, float soluong, string dongia, string id_nhacungcap)
        {
            SqlParameter[] para = new SqlParameter[7];
            para[0] = new SqlParameter("@id", SqlDbType.VarChar, 10) { Value = id };
            para[1] = new SqlParameter("@id_product", SqlDbType.VarChar, 15) { Value = tensanpham };
            para[2] = new SqlParameter("@ngaynhap", SqlDbType.DateTime) { Value = ngaynhap };
            para[3] = new SqlParameter("@unit", SqlDbType.NVarChar, 10) { Value = donvitinh };
            para[4] = new SqlParameter("@soluong", SqlDbType.Float) { Value = soluong };
            para[5] = new SqlParameter("@id_nhacungcap", SqlDbType.VarChar, 10) { Value = id_nhacungcap };
            para[6] = new SqlParameter("@dongia", SqlDbType.VarChar, 20) { Value = dongia };

            return DataProvider.Instance.ExecuteNonQuery_SP("sp_NhapKho", para);
        }

        public DataTable GetInfoProduct()
        {
            return DataProvider.Instance.ExecuteQuery_SP("GetInfoProduct");
        }
        
        public int XuatKho(string tensp, string unit,string id_ncc, string maxuat, string masp, float soluong, DateTime ngayxuat)
        {
            SqlParameter[] arr = new SqlParameter[7];
            arr[0] = new SqlParameter("@maxuat", SqlDbType.VarChar, 10) { Value = maxuat };

            arr[1] = new SqlParameter("@masp", SqlDbType.VarChar, 15) { Value = masp };

            arr[2] = new SqlParameter("@tensp", SqlDbType.NVarChar,50) {Value = tensp};

            arr[3] = new SqlParameter("@unit", SqlDbType.NVarChar, 10) {Value = unit};

            arr[4] = new SqlParameter("@soluong", SqlDbType.Float) { Value = soluong };

            arr[5] = new SqlParameter("@id_ncc", SqlDbType.VarChar, 10) {Value = id_ncc};

            arr[6] = new SqlParameter("@ngayxuat", SqlDbType.DateTime) { Value = ngayxuat };

            return DataProvider.Instance.ExecuteNonQuery_SP("sp_XuatKho", arr);
        }

        internal DataTable GetIDNhaCC_ID(string id_ncc)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@id", SqlDbType.VarChar,10){Value = id_ncc};

            return DataProvider.Instance.ExecuteQuery_SP("sp_GetIDNhaCC_ID", para);
        }
    }
}
