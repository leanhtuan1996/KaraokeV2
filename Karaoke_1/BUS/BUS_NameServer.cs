using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Karaoke_1.DAO;
using System.Data.SqlClient;

namespace Karaoke_1.BUS
{
    public class BUS_NameServer
    {
        static BUS_NameServer instance;

        public static BUS_NameServer Instance
        {
            get
            {
                if (instance ==null)
                {
                    instance = new BUS_NameServer();
                }
                return instance;
            }
        }

        BUS_NameServer() { }

        public DataTable GetName()
        {
            return DAO_NameServer.Instance.GetNameServer();
        }

        public bool Check_Connect(string strConnnect)
        {
            return DAO_NameServer.Instance.Check_Connect(strConnnect);
        }
    }
}
