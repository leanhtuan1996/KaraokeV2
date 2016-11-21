using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Server.DAO
{
    public class DAO_User
    {
        static DAO_User instance;

        public static DAO_User Instance
        {
            get { return instance ?? (instance = new DAO_User()); }
        }

        internal int Login(string id, string pass)
        {
            string query = @"SELECT Count(*) FROM dbo.[User] WHERE [user_name] = @user_name AND [user_pass] = @user_pass";
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@user_name", SqlDbType.VarChar, 50) { Value = id };
            para[1] = new SqlParameter("@user_pass", SqlDbType.VarChar, 50) { Value = pass };
            return (int)DataProvider.Instance.ExecuteScalar(query, para);
        }
    }
}
