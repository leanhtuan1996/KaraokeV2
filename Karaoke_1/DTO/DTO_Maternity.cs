using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke_1.DTO
{
     public class DTO_Maternity
    {
        private int index_user;

        public int _index_user
        {
            get { return index_user; }
            set { index_user = value; }
        }
         private DateTime day_off;

         public DateTime _day_off
         {
             get { return day_off; }
             set { day_off = value; }
         }
         private DateTime day_on;

         public DateTime _day_on
         {
             get { return day_on; }
             set { day_on = value; }
         }
         private int subsidize;

         public int _subsidize
         {
             get { return subsidize; }
             set { subsidize = value; }
         }
    }
}
