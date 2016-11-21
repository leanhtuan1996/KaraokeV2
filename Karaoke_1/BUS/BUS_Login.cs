using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Karaoke_1.DAO;
using System.IO;

namespace Karaoke_1.BUS
{
    public class BUS_Login
    {
        private static BUS_Login instance;

        public static BUS_Login Instance
        {
            get { return instance ?? (instance = new BUS_Login()); }
        }

        BUS_Login()
        { }

        public string[] Login(string id, string pass)
        {
            string [] result = new string[2];
            SqlDataReader dr = DAO_Login.Instance.READ_Login();

            while(dr.Read())
            {
                if (dr["account_name"].ToString().Contains(id) == true && dr["account_pass"].ToString().Contains(pass) == true)
                {
                    result[0] = dr["index_user"].ToString();
                    result[1] = dr["name"].ToString();
                    break;
                }
            }
            dr.Close();
            dr.Dispose();
            DataProvider.Instance.ConnectionClose();
            return result;
        }


        public string Update_status(int id, string status)
        {
            return DAO_Login.Instance.Update_status(id,status);
        }
    }
}
