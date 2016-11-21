using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Karaoke_1.DAO;

namespace Karaoke_1.BUS
{
    class BUS_DoanhThu
    {
        static BUS_DoanhThu instance;

        public static BUS_DoanhThu Instance
        {
            get { return instance ?? (instance = new BUS_DoanhThu()); }
        }

        public void XemThongKe(int loai, DateTime ngay, ref decimal nhapkho, ref decimal hoadon, ref decimal chiphikhac, ref decimal luong)
        {
            DAO_DoanhThu.Instance.XemDoanhThu(loai, ngay, ref nhapkho, ref  hoadon, ref  chiphikhac, ref luong);
        }

    }
}
