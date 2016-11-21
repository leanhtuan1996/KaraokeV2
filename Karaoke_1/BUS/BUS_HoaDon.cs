using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Karaoke_1.DAO;
using Karaoke_1.DTO;
using System.Data.SqlClient;

namespace Karaoke_1.BUS
{
    class BUS_HoaDon
    {
        static BUS_HoaDon instance;

        public static BUS_HoaDon Instance
        {
            get { return instance ?? (instance = new BUS_HoaDon()); }
        }

        public string GetMaHoaDon()
        {
            return DAO_HoaDon.Instance.GetMaHoaDon();
        }

        public int Insert_Bill(string mahoadon, DateTime ngayxuat, string maphong, string user, DateTime giovao, int tienhat, int tiendv, int giamgia, string phuthu, int tongtien)
        {
            return DAO_HoaDon.Instance.Insert_Bill(mahoadon, ngayxuat, maphong, user, giovao, tienhat, tiendv, giamgia, phuthu, tongtien);
        }

        public int Insert_BillDetail(string mahoadon, string name_menu, int dongia, int soluong)
        {
            return DAO_HoaDon.Instance.Insert_BillDetail(mahoadon, name_menu, dongia, soluong);
        }

        public SqlDataReader GetDatePhuThu()
        {
            return DAO_HoaDon.Instance.GetDatePhuThu();
        }
    }
}
