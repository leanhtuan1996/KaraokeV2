using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


namespace Server.DAO
{
    class DTO_Socket
    {
        public Socket _socket { get; set; }
        public string _name { get; set; }

        public DTO_Socket(Socket socket)
        {
            _socket = socket;
        }

        public DTO_Socket(Socket socket, string name)
        {
            _socket = socket;
            _name = name;
        }
    }
}
