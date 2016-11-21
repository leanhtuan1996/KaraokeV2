using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke_1.DTO
{
    public class DTO_Contract
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
        private string species;

        public string _species
        {
            get { return species; }
            set { species = value; }
        }
        private DateTime start;

        public DateTime _start
        {
            get { return start; }
            set { start = value; }
        }
        private DateTime end;

        public DateTime _end
        {
            get { return end; }
            set { end = value; }
        }
    }
}
