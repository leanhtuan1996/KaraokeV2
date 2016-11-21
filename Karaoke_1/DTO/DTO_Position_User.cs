using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke_1.DTO
{
    public class DTO_Position_User
    {
        private string position_id;

        public string _position_id
        {
            get { return position_id; }
            set { position_id = value; }
        }

        private string user_id;

        public string _user_id
        {
            get { return user_id; }
            set { user_id = value; }
        }

        private bool status;

        public bool _status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
