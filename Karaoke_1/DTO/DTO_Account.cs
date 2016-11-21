using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke_1.DTO
{
    public class DTO_Account
    {
        private int index;

        public int _index
        {
            get { return index; }
            set { index = value; }
        }

        private string account_name;

        public string _account_name
        {
            get { return account_name; }
            set { account_name = value; }
        }

        private string account_pass;

        public string _account_pass
        {
            get { return account_pass; }
            set { account_pass = value; }
        }

        private int index_position;

        public int _index_position
        {
            get { return index_position; }
            set { index_position = value; }
        }

        private DateTime day_create;

        public DateTime _day_create
        {
            get { return day_create; }
            set { day_create = value; }
        }
    }
}
