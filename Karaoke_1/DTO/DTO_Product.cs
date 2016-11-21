using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Karaoke_1.DTO
{
    public class DTO_Product
    {
        public string index { get; set; }

        public string id { get; set; }

        public string name { get; set; }

        public string unit { get; set; }

        public float soluong { get; set; }

        public string id_ncc { get; set; }

        public DTO_Product(string _id, string _name, string _unit, float _soluong, string _id_ncc)
        {
            id = _id;
            name = _name;
            unit = _unit;
            soluong = _soluong;
            id_ncc = _id_ncc;
        }

        public DTO_Product(string _index, string _id, string _name, string _unit, float _soluong, string _id_ncc)
        {
            index = _index;
            id = _id;
            name = _name;
            unit = _unit;
            soluong = _soluong;
            id_ncc = _id_ncc;
        }
    }
}
