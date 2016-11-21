using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Karaoke_1.DAO;
using System.Data;
using System.Data.SqlClient;

namespace Karaoke_1.BUS
{
    public class BUS_XemChiTiet
    {
        static BUS_XemChiTiet instance;

        public static BUS_XemChiTiet Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_XemChiTiet();
                }
                return instance;
            }
        }
 
        public string [] Arr_Info(string idx_user)
        {
            string[] arr = new string[22];
            SqlDataReader dr = DAO_XemChiTiet.Instance.Get_LoadFullInfo(idx_user);
            while(dr.Read())
            {
                for (int i = 0; i < 22;++i )
                {
                    arr[i] = dr[i].ToString();
                }
            }
            dr.Close();
            dr.Dispose();
            DataProvider.Instance.ConnectionClose();
            return arr;
        }

        
    }
}
