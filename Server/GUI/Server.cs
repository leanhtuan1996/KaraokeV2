using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using DTORoom;
using Server.DAO;
using Server.BUS;
using Server.DAO;
using TranspotSocket;
using DTORoomColor;


namespace Server.GUI
{
    [Serializable]
    public partial class Server : MetroForm
    {
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            _LstClientSockets = new List<DTO_Socket>();
        }

        private static ManualResetEvent allDone = new ManualResetEvent(false);

        readonly byte[] buffer = new byte[1024 * 100];
        List<DTO_Socket> _LstClientSockets { get; set; }

        private readonly string ipAddress = GetLocalIPAddress();

        readonly Socket _serverSocket = new Socket(IPAddress.Any.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        private void Server_Load(object sender, EventArgs e)
        {
            txtPortnumber.Text = "100";
            SetupServer();
        }

        private static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList.Where(ip => ip.AddressFamily == AddressFamily.InterNetwork))
            {
                return ip.ToString();
            }
            throw new Exception("Local IP Address Not Found!");
        }

        void SetupServer()
        {

            txtIPserver.Text = ipAddress;

            try
            {
                _serverSocket.Bind(new IPEndPoint(IPAddress.Any, int.Parse(txtPortnumber.Text)));
                _serverSocket.Listen(100);

                _serverSocket.BeginAccept(new AsyncCallback(AppceptCallback), _serverSocket);


            }
            catch (SocketException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //Loop chấp nhận kết nối từ client
        void AppceptCallback(IAsyncResult ar)
        {
            var socket = _serverSocket.EndAccept(ar);
            //var s = (Socket)ar.AsyncState;
            //var socket = s.EndAccept(ar);

            var clientPCName = Dns.GetHostEntry(GetLocalIPAddress()).HostName;
            //Add socket to ListSocket
            _LstClientSockets.Add(new DTO_Socket(socket, clientPCName));

            //Add IPEndPoint to TextBox
            lstClientConnected.Items.Add((socket.RemoteEndPoint.ToString().Split(':'))[0] + " " + clientPCName);

            //Status tooltip
            lblTongSoClient.Text = "Số client hiện đang kết nối: " + _LstClientSockets.Count;

            //loop chấp nhận tất cả các kết nối từ phía client
            _serverSocket.BeginAccept(new AsyncCallback(AppceptCallback), _serverSocket);

            //bắt đầu nhận dữ liệu từ client
            socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);

        }

        private object DeserializeData(byte[] theBytesArray)
        {
            var ms = new MemoryStream(theBytesArray);
            var bf1 = new BinaryFormatter();
            ms.Position = 0;
            return bf1.Deserialize(ms);
        }
        private byte[] SerializeData(Object o)
        {
            var ms = new MemoryStream();
            var bf1 = new BinaryFormatter();
            bf1.Serialize(ms, o);
            return ms.ToArray();
        }

        // nhận yêu cầu từ client
        void ReceiveCallback(IAsyncResult ar)
        {
            var socket = (Socket)ar.AsyncState;

            if (socket.Connected)
            {
                int received;
                try
                {
                    received = socket.EndReceive(ar);
                }
                catch (SocketException) //Client bị out
                {
                    // client đóng kết nối
                    //for (int i = 0; i < _LstClientSockets.Count; i++)
                    //{
                    //    if (_LstClientSockets[i]._socket.RemoteEndPoint.ToString() == (socket.RemoteEndPoint.ToString()))
                    //    {
                    //        string name = _LstClientSockets[i]._socket.RemoteEndPoint + " " +
                    //                      _LstClientSockets[i]._name;
                            
                    //        lstClientConnected.Items.Remove(name);
                    //        _LstClientSockets.RemoveAt(i);
                    //        lblTongSoClient.Text = "Số client đang kết nối: " + _LstClientSockets.Count.ToString();
                    //    }
                    //}
                    if (_LstClientSockets != null)
                    {
                        int name = _LstClientSockets.FindIndex(t => t._socket.RemoteEndPoint.ToString() == socket.RemoteEndPoint.ToString());
                        _LstClientSockets.RemoveAt(name);
                        lstClientConnected.Items.RemoveAt(name);
                    }
                    lblTongSoClient.Text = "Số client đang kết nối: " + _LstClientSockets.Count();
                    return;
                }

                //Nếu nhận đc thì xử lý yêu cầu
                if (received != 0)
                {
                    //cấp phát bộ nhớ cho databuffer với độ dài mảng bằng tổng số lượng phần tử được nhận từ phía Client
                    var dataBuffer = new byte[received];
                    //Copy dữ liệu từ buffer qua databuffer 
                    Array.Copy(buffer, dataBuffer, received);
                    //Giải mã dữ liệu đã nhận được

                    var tran = (Transport)DeserializeData(dataBuffer);

                    //Xử lý yêu cầu Client 
                    XuLy(socket, tran);

                    socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
                }
                else //Không nhận đc => xóa client đó khỏi list và cập nhật lại số lượng client
                {
                    //for (int i = 0; i < _LstClientSockets.Count; i++)
                    //{
                    //    if (_LstClientSockets[i]._socket.RemoteEndPoint.ToString() != (socket.RemoteEndPoint.ToString()))
                    //        continue;
                    //    lstClientConnected.Items.Remove(_LstClientSockets[i]._socket.RemoteEndPoint.ToString());
                    //    _LstClientSockets.RemoveAt(i);
                    //    lblTongSoClient.Text = "Số client đang kết nối: " + _LstClientSockets.Count();
                    //}
                    if (_LstClientSockets != null)
                    {
                        int name = _LstClientSockets.FindIndex(t => t._socket.RemoteEndPoint.ToString() == socket.RemoteEndPoint.ToString());
                        _LstClientSockets.RemoveAt(name);
                        lstClientConnected.Items.RemoveAt(name);
                    }
                    lblTongSoClient.Text = "Số client đang kết nối: " + _LstClientSockets.Count();
                    return;
                }
            }

        }

        private void XuLy(Socket socket, Transport tran)
        {
            string purpose = tran._purpose;
            switch (purpose)
            {
                case "ChonPhong":
                {
                        var Room = (DTO_Room)tran._object;
                        int check = BUS_Room.Instance.ChonPhong(Room.Name, Room.Tiendatphong);

                        var t = new Transport() { _object = check +"|"+Room.Name + "|" + Room.Tiendatphong, _purpose = "ChonPhong" };

                        foreach (var client in _LstClientSockets)
                        {
                            SendDataToClient(client._socket, t);
                        }
                    }
                    break;
                case "LoadColor":
                    {
                        DataTable dt = DAO_Room.Instance.LoadColor();

                        var t = new Transport() { _object = dt, _purpose = "LoadColor" };

                        foreach (var client in _LstClientSockets)
                        {
                            SendDataToClient(client._socket, t);
                        }
                    }
                    break;
                case "LoadRoom":
                    {
                        DataTable dt = DAO_Room.Instance.LoadInfoRoom();

                        var t = new Transport() { _object = dt, _purpose = "LoadRoom" };

                        foreach (var client in _LstClientSockets)
                        {
                            SendDataToClient(client._socket, t);
                        }
                    }
                    break;
                case "LoadCustomer":
                    {
                        DataTable dt = DAO_Room.Instance.LoadInfoCustomer();

                        var t = new Transport() { _object = dt, _purpose = "LoadCustomer" };

                        foreach (var sk in _LstClientSockets)
                        {
                            SendDataToClient(sk._socket, t);
                        }
                    }
                    break;
            }
        }


        void SendDataToClient(Socket socket, object noidung) //Gửi đến ai? nội dung gửi là gì?
        {

            //Mã hóa dữ liệu về dạng byte
            var data = SerializeData(noidung);
            //Gửi
            socket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallback), socket);

            allDone.WaitOne();

            //khi gửi xong => trở về trạng thái chờ kết nối
            _serverSocket.BeginAccept(new AsyncCallback(AppceptCallback), null);
        }

        //Loop gửi yêu cầu đến client
        void SendCallback(IAsyncResult ar)
        {
            // socket.EndSend(ar);
            try
            {
                allDone.Reset();
                var socket = (Socket)ar.AsyncState;
                int bytesSent = socket.EndSend(ar);


                allDone.Set();
                //socket.Shutdown(SocketShutdown.Send);
            }
            catch (SocketException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //Gửi
        private void btnSend_Click(object sender, EventArgs e)
        {
            //DataTable dt = getdata();
            foreach (var client in _LstClientSockets)
            {
                var tran = new Transport() { _purpose = "hello", _object = "Hello Client" };
                SendDataToClient(client._socket, tran);
            }
        }

        private void txtPortnumber_Click(object sender, EventArgs e)
        {

        }

    }
}
