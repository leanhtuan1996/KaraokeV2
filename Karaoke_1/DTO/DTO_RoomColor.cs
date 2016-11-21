using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke_1.DTO
{
    class DTO_RoomColor
    {
        public int Status { get; set; }

        public int CodeColor { get; set; }

        public DTO_RoomColor(int status, int codeColor)
        {
            this.Status = status;
            this.CodeColor = codeColor;
        }
    }
}
