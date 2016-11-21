using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke_1.DTO
{
    public class DTO_User
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

        private int index_account;

        public int _index_account
        {
            get { return index_account; }
            set { index_account = value; }
        }

        private int index_contract;

        public int _index_contract
        {
            get { return index_contract; }
            set { index_contract = value; }
        }
        private int index_position;

        public int _index_position
        {
            get { return index_position; }
            set { index_position = value; }
        }
        private string full_name;

        public string _full_name
        {
            get { return full_name; }
            set { full_name = value; }
        }
        private string nick_name;

        public string _nick_name
        {
            get { return nick_name; }
            set { nick_name = value; }
        }
        private DateTime birthday;

        public DateTime _birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        private string sex;

        public string _sex
        {
            get { return sex; }
            set { sex = value; }
        }
        private string marital_status;

        public string _marital_status
        {
            get { return marital_status; }
            set { marital_status = value; }
        }
        private string cmnd;

        public string _cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }

        private string photo;

        public string _photo
        {
            get { return photo; }
            set { photo = value; }
        }
        private string status;

        public string _status
        {
            get { return status; }
            set { status = value; }
        }

        private string phone_number;

        public string _phone_number
        {
            get { return phone_number; }
            set { phone_number = value; }
        }
    }
}
