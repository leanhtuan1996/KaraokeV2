using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace Karaoke_1.DAO
{
    public class DAO_qlnv
    {
        static DAO_qlnv instance;

        public static DAO_qlnv Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_qlnv();
                }
                return DAO_qlnv.instance;
            }
        }

        DAO_qlnv() { }

        public DataTable Load_dsnvONLINE()
        {
            return DataProvider.Instance.ExecuteQuery_SP("sp_dsnvONLINE");
        }
    }
}
