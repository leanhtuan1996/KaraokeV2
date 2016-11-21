using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke_1.DTO
{
    public class DTO_KhachHang
    {
        public DTO_KhachHang(string name_customer, string phone_number, string id_room, DateTime time_checkin, int deposits = 0)
        {
            this.NameCustomer = name_customer;
            this.PhoneNumber = phone_number;
            this.IdRoom = id_room;
            this.TimeCheckin = time_checkin;
            this.Deposits = deposits;
        }

        public string NameCustomer { get; set; }

        public string PhoneNumber { get; set; }


        public string IdRoom { get; private set; }

        public DateTime TimeCheckin { get; set; }

        public int Deposits { get; set; }
    }
}
