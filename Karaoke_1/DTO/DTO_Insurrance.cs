using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke_1.DTO
{
    public class DTO_Insurrance
    {
        private int index_user;

        public int _index_user
        {
            get { return index_user; }
            set { index_user = value; }
        }
        private string id;

        public string _id
        {
            get { return id; }
            set { id = value; }
        }
        private DateTime day_offer;

        public DateTime _day_offer
        {
            get { return day_offer; }
            set { day_offer = value; }
        }
        private string place_of_issue;

        public string _place_of_issue
        {
            get { return place_of_issue; }
            set { place_of_issue = value; }
        }
    }
}
