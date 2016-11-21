using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Karaoke_1.DAO
{
    public class DAO_ThongTinTK
    {
        static DAO_ThongTinTK instance;

        public static DAO_ThongTinTK Instance
        {
            get { return instance ?? (instance = new DAO_ThongTinTK()); }
        }

        DAO_ThongTinTK() { }

        public SqlDataReader Load_Info()
        {
            return DataProvider.Instance.EXCUTEREADE_SP("sp_LoadInformation");
        }

        public SqlDataReader Load_Position()
        {
            return DataProvider.Instance.EXCUTEREADE_SP("sp_LoadPosition");
        }
    }
}
