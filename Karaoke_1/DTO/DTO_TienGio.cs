using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke_1.DTO
{
    class DTO_TienGio
    {
        public double Tien { get; set; }

        public string Timeslot { get; set; }

        public DTO_TienGio()
        {
            Tien = 0;
            Timeslot = "";
        }

        public DTO_TienGio(string timeslot, double tien)
        {
            this.Timeslot = timeslot;
            this.Tien = tien;
        }
    }
}
