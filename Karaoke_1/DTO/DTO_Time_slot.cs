using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke_1.DTO
{
    public class DTO_Time_slot
    {
        private int index;

        public int _index
        {
            get { return index; }
            set { index = value; }
        }
        private string id;

        public string _id
        {
            get { return id; }
            set { id = value; }
        }
        private DateTime time_start;

        public DateTime _time_start
        {
            get { return time_start; }
            set { time_start = value; }
        }
        private DateTime time_end;

        public DateTime _time_end
        {
            get { return time_end; }
            set { time_end = value; }
        }
        private int price;

        public int _price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
