using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Karaoke_1.DAO
{
    public class DAO_XemChiTiet
    {
        static DAO_XemChiTiet instance;

        public static DAO_XemChiTiet Instance
        {
            get
            {
                if (instance ==null)
                {
                    instance = new DAO_XemChiTiet();
                }
                return instance;
            }
        }

        DAO_XemChiTiet() { }

        public SqlDataReader Get_LoadFullInfo(string idx_user)
        {
            SqlParameter [] para = new SqlParameter[1];
            para[0] = new SqlParameter("@idx_user", SqlDbType.Int);
            para[0].Value = idx_user;
            return DataProvider.Instance.EXCUTEREADE_SP("sp_ViewFullInfo", para);
        }
    }
}
