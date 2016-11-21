using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke_1.DTO
{
    public class DTO_Time_slot_user
    {
        private int index_time_slot;

        public int _index_time_slot
        {
            get { return index_time_slot; }
            set { index_time_slot = value; }
        }
        private int index_user;

        public int _index_user
        {
            get { return index_user; }
            set { index_user = value; }
        }
        private int date_work;

        public int _date_work
        {
            get { return date_work; }
            set { date_work = value; }
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
    }
}
