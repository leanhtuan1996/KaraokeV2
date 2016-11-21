using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke_1.DTO
{
    public class DTO_RoomType
    {
        public int Type { get; set; }
        public string Decription { get; set; }

        public DTO_RoomType(int type, string decription)
        {
            this.Type = type;
            this.Decription = decription;
        }
    }
}
