using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke_1.DTO
{
    public class DTO_RoomTimeSlot
    {
        public int TypeRoom { get; set; }
        public int StartTime { get; set; }

        public int[] TimeSlot
        {
            get { return timeslot; }
            set { timeslot = value; }
        }

        private int[] timeslot = new int[24];
    }
}
