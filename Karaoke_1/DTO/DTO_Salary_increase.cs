using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke_1.DTO
{
    public class DTO_Salary_increase
    {
        private int index_user;

        public int _index_user
        {
            get { return index_user; }
            set { index_user = value; }
        }

        private int index_position;

        public int _index_position
        {
            get { return index_position; }
            set { index_position = value; }
        }

        private int salary_bonus;

        public int _salary_bonus
        {
            get { return salary_bonus; }
            set { salary_bonus = value; }
        }

        private int salary_advance;

        public int _salary_advance
        {
            get { return salary_advance; }
            set { salary_advance = value; }
        }

        private string reson;

        public string _reson
        {
            get { return reson; }
            set { reson = value; }
        }
    }
}
