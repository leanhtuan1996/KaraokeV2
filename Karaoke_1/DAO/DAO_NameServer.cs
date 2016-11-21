using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Karaoke_1.DAO
{
    public class DAO_NameServer
    {
        static DAO_NameServer instance;

        public static DAO_NameServer Instance
        {
            get
            {
                if (instance ==null)
                {
                    instance = new DAO_NameServer();
                }
                return DAO_NameServer.instance;
            }
        }

        DAO_NameServer() {}

        public DataTable GetNameServer()
        {
            DataTable table = new DataTable() ;
            SqlDataSourceEnumerator temp = SqlDataSourceEnumerator.Instance;
            table = temp.GetDataSources();
            return table;
        }

        public bool Check_Connect(string strConnect)
        {
            SqlConnection conn = new SqlConnection(strConnect);
            try
            {
                conn.Open();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
