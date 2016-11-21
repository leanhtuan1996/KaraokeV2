using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Karaoke_1.DAO;
using Karaoke_1.DTO;
using System.Data;
namespace Karaoke_1.BUS
{
    class BUS_NhaCC
    {
        static BUS_NhaCC instance;

        public static BUS_NhaCC Instance
        {
            get { return instance ?? (instance = new BUS_NhaCC()); }
        }

        public DataTable GetInFoNhaCC()
        {
            return DAO_NhaCC.Instance.GetInFoNhaCC();
        }

        public int ThemNhaCC(string mancc, string tenncc, string sdt, string diachi)
        {
            return DAO_NhaCC.Instance.ThemNhaCC(mancc, tenncc, sdt, diachi);
        }

        public int SuaNhaCC(string mancc, string tenncc, string sdt, string diachi)
        {
            return DAO_NhaCC.Instance.SuaNhaCC(mancc, tenncc, sdt, diachi);
        }

        public int XoaNhaCC(string id)
        {
            return DAO_NhaCC.Instance.XoaNhaCC(id);
        }
    }
}
