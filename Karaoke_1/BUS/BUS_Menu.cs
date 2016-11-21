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
    class BUS_Menu
    {
        static BUS_Menu instance;

        public static BUS_Menu Instance
        {
            get { return instance ?? (instance = new BUS_Menu()); }
        }

        public DataTable sp_GetMenu()
        {
            return DAO_Menu.Instance.sp_GetMenu();
        }

        public DataTable sp_GetUnit_Menu(string name)
        {
            return DAO_Menu.Instance.sp_Menu_GetUnit_Name(name);
        }

        public int sp_GetPrice_Menu(string name)
        {
            return DAO_Menu.Instance.sp_Menu_GetPrice_Name(name);
        }

        public int sp_GetPrice_Unit_Name(string name, string unit)
        {
            return DAO_Menu.Instance.sp_Menu_GetPrice_Unit_Name(name, unit);
        }

        public int sp_ThemDichVu(string name, string unit, int price, string description)
        {
            return DAO_Menu.Instance.sp_ThemDichVu(name, unit, price, description);
        }

        public int sp_XoaDichVu(string name)
        {
            return DAO_Menu.Instance.sp_XoaDichVu(name);
        }

        public int sp_SuaDichVu(string name, string unit, int price, string description)
        {
            return DAO_Menu.Instance.sp_SuaDichVu(name, unit, price, description);
        }

        internal DataTable sp_GetMenu_ThemDV()
        {
            return DAO_Menu.Instance.sp_GetMenu_ThemDV();
        }
    }
}
