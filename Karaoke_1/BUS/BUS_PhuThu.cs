using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Karaoke_1.DAO;

namespace Karaoke_1.BUS
{
    class BUS_PhuThu
    {
        static BUS_PhuThu instance;

        public static BUS_PhuThu Instance
        {
            get { return instance ?? (instance = new BUS_PhuThu()); }
        }

        public SqlDataReader GetPhuThu()
        {
            return DAO_PhuThu.Instance.GetPhuThu();
        }

        public int Insert_PhuThu(DateTime ngay, int percent, string description)
        {
            return DAO_PhuThu.Instance.Insert_PhuThu(ngay, percent, description);
        }

        public int Del_PhuThu(DateTime ngay)
        {
            return DAO_PhuThu.Instance.Del_PhuThu(ngay);
        }
    }
}
