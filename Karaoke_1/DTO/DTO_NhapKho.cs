using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke_1.DTO
{
    class DTO_NhapKho
    {
        string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string IdProduct { get; set; }

        public DateTime Ngaynhap { get; set; }

        string unit;

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        float soluong;

        public float Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        string id_nhacungcap;

        public string Id_nhacungcap
        {
            get { return id_nhacungcap; }
            set { id_nhacungcap = value; }
        }

        string gianhap;

        public string Gianhap
        {
            get { return gianhap; }
            set { gianhap = value; }
        }

        public DTO_NhapKho(string id, string id_product, DateTime ngaynhap, string unit, float soluong, string id_nhacungcap, string gianhap)
        {
            this.id = id;
            this.IdProduct = id_product;
            this.Ngaynhap = ngaynhap;
            this.unit = unit;
            this.soluong = soluong;
            this.id_nhacungcap = id_nhacungcap;
            this.gianhap = gianhap;
        }
    }
}
