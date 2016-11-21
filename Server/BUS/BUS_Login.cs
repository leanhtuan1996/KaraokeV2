using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.DAO;


namespace Server.BUS
{
    [Serializable]
    public class BUS_Login
    {
        private static BUS_Login instance;

        public static BUS_Login Instance
        {
            get { return instance ?? (instance = new BUS_Login()); }
        }

        BUS_Login()
        { }

        public int CheckLogin(string id, string pass)
        {
            int check = DAO_User.Instance.Login(id, pass);

            if (check != 0)
            {
                return 1;
            }
            return 0;
        }
    }
}
