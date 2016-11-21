using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke_1.DTO
{
    class DTO_Menu
    {
        private string Description { get; set; }

        private int Price { get; set; }

        private string Unit { get; set; }

        private string Name { get; set; }

        public DTO_Menu(string name, string unit, int price, string description = null)
        {
            this.Name = name;
            this.Unit = unit;
            this.Price = price;
            this.Description = description;
        }

    }
}
