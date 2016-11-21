using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Karaoke_1.DAO;
using Karaoke_1.DTO;
using Karaoke_1.GUI;

namespace Karaoke_1.BUS
{
    public class BUS_NhapXuatKho
    {
        static BUS_NhapXuatKho instance;
        public static BUS_NhapXuatKho Instance
        {
            get { return instance ?? (instance = new BUS_NhapXuatKho()); }
        }

        public DataTable GetIDNhaCC()
        {
            return DAO_NhapXuatKho.Instance.GetIDNhaCC();
        }
        
        public int NhapKho(string id, DateTime ngaynhap, string tensanpham, string donvitinh, float soluong, string dongia, string id_nhacungcap)
        {
            return DAO_NhapXuatKho.Instance.NhapKho(id, ngaynhap, tensanpham, donvitinh, soluong, dongia, id_nhacungcap);
        }

        public void GetInfoProduct(List<DTO_Product> lstProducts)
        {
            DataTable dt = DAO_NhapXuatKho.Instance.GetInfoProduct();

            //lstProducts.AddRange(from DataRow item in dt.Rows select new DTO_Product((string) item[0], (string) item[1], (string) item[2], float.Parse(item[3].ToString()), (string) item[4]));

            foreach (DataRow item in dt.Rows)
            {
                if (string.IsNullOrEmpty(item[3].ToString()))
                {
                    item[3] = 0.0;
                }
                if (string.IsNullOrEmpty(item[4].ToString()))
                {
                    item[4] = "-";
                }
                DTO_Product rm = new DTO_Product((string)item[0], (string)item[1], (string)item[2], float.Parse(item[3].ToString()), (string)item[4]);
                lstProducts.Add(rm);
            }

        }

        public int XuatKho(string tensp, string unit, string id_ncc, string maxuat, string masp, float soluong, DateTime ngayxuat)
        {
            return DAO_NhapXuatKho.Instance.XuatKho(tensp, unit, id_ncc, maxuat, masp, soluong, ngayxuat);
        }

        public float SoLuongSanPham(string masp)
        {
            float soluong = 0;
            foreach (var item in MainRooms.LstProducts.Where(t => t.id == masp))
            {
                soluong = item.soluong;
            }

            return soluong;
        }


        internal DataTable GetIDNhaCC_ID(string id_ncc)
        {
            return DAO_NhapXuatKho.Instance.GetIDNhaCC_ID(id_ncc);
        }
    }
}
