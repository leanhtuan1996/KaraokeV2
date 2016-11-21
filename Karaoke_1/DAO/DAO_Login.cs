using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Karaoke_1.DAO
{
    public class DAO_Login
    {
        static DAO_Login instance;

        public static DAO_Login Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_Login();
                }
                return instance;
            }
        }

        DAO_Login() { }

        public SqlDataReader READ_Login()
        {
            return DataProvider.Instance.EXCUTEREADE_SP("sp_Login");
        }

        public string Update_status(int idx_user, string status)
        {
            string result = "";

            SqlParameter [] para = new SqlParameter[2];
            para[0] = new SqlParameter("@idx_user", SqlDbType.Int);
            para[0].Value = idx_user;
            para[1] = new SqlParameter("@str_status", SqlDbType.NVarChar,50);
            para[1].Value = status;

            result = DataProvider.Instance.EXECUTENONQUERY_SP("sp_UpdateStatus", para);
            return result;
        }
    }
}
