using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Karaoke_1.BUS;
using TranspotSocket;

namespace Karaoke_1.SocketManager
{
    class SocketManager
    {
        private static Socket _socket;
        private static byte[] _buffer;
        public static Transport Tran;
        private SocketManager()
        {
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _buffer = new byte[5000 * 5000];
        }

        private static SocketManager _instance = null;

        public static SocketManager Instance
        {
            get { return _instance ?? (_instance = new SocketManager()); }
        }

        public void Init()
        {
            _socket.Connect(IPAddress.Loopback, 100);
            _socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack),
                _socket);
        }
        public void ReceiveCallBack(IAsyncResult ar)
        {
            try
            {
                var socket = (Socket)ar.AsyncState;
                int byteRead = socket.EndReceive(ar);

                if (byteRead > 0)
                {
                    var databuffer = new byte[byteRead];

                    Array.Copy(_buffer, databuffer, byteRead);

                    Tran = (Transport)DeserializeData(databuffer);

                    switch (Tran._purpose)
                    {
                        case "LoadRoom":
                            BUS_Room.receiveRoomDone.Set();
                            //Tiếp tục gọi 1 hàm ở dưới tầng GUI để nó thực thi => hàm đó chứa các câu lệnh cập nhật danh sách phòng, danh sách button, đổi màu với chức năng tương ứng
                            break;
                        case "LoadColor":
                            BUS_Room.receiveColorDone.Set();
                            break;
                    }
                }

            }
            catch (Exception)
            {
                throw new Exception("Không nhận được dữ liệu");
            }

            _socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack),
                        _socket);

        }

        public void SendData(object data)
        {
            byte[] _data = SerializeData(data);

            _socket.BeginSend(_data, 0, _data.Length, SocketFlags.None, new AsyncCallback(SendCallBack), _socket);
            _socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack),
                _socket);
        }

        private void SendCallBack(IAsyncResult ar)
        {

            try
            {
                Socket client = (Socket)ar.AsyncState;

                client.EndSend(ar);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public object DeserializeData(byte[] theBytesArray)
        {
            var ms = new MemoryStream(theBytesArray);
            var bf1 = new BinaryFormatter();
            ms.Position = 0;
            return bf1.Deserialize(ms);
        }
        public byte[] SerializeData(Object o)
        {
            var ms = new MemoryStream();
            var bf1 = new BinaryFormatter();
            bf1.Serialize(ms, o);
            return ms.ToArray();
        }
    }
}
