using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke_1.DTO
{
    public class DTO_Position
    {
        private int index;

        public int _index
        {
            get { return index; }
            set { index = value; }
        }

        private string name;

        public string _name
        {
            get { return name; }
            set { name = value; }
        }

        private int basic_salary;

        public int _basic_salary
        {
            get { return basic_salary; }
            set { basic_salary = value; }
        }

        private int allowance;

        public int _allowance
        {
            get { return allowance; }
            set { allowance = value; }
        }
    }
}
