using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using Karaoke_1.DAO;
using Karaoke_1.DTO;

namespace Karaoke_1.BUS
{
    class BUS_SanPham
    {
        static BUS_SanPham instance;

        public static BUS_SanPham Instance
        {
            get { return instance ?? (instance = new BUS_SanPham()); }
        }

        public DataTable GetInFoKho()
        {
            return DAO_SanPham.Instance.GetInFoKho();
        }

        public int ThemSanPham(string id, string name, string unit)
        {
            return DAO_SanPham.Instance.ThemSanPham(id, name, unit);
        }

        public int SuaSanPham(string index, string id, string name, string unit)
        {
            return DAO_SanPham.Instance.SuaSanPham(index,id, name, unit);
        }

        public int XoaSanPham(string id)
        {
            return DAO_SanPham.Instance.XoaSanPham(id);
        }
    }
}
