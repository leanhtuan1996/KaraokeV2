using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading;
using DTORoom;
using Karaoke_1.DAO;
using Karaoke_1.DTO;
using Karaoke_1.GUI;

namespace Karaoke_1.BUS
{
    class BUS_Room
    {
        static BUS_Room instance;

        public static BUS_Room Instance
        {
            get { return instance ?? (instance = new BUS_Room()); }
        }

        public static ManualResetEvent receiveRoomDone = new ManualResetEvent(false);
        public static ManualResetEvent receiveColorDone = new ManualResetEvent(false);

        public void LoadInFoRoom(List<DTO_Room> lstRoom)
        {
            var dt = DAO_Room.Instance.LoadInfoRoom();

            //lstRoom.AddRange(from DataRow item in dt.Rows select new DTO_Room((string) item[0], (int) item[1], (int) item[2], (int) item[3], (DateTime) item[4]));

            foreach (DataRow item in dt.Rows)
            {
                DTO_Room rm = new DTO_Room((string)item[0], (int)item[1], (int)item[2], (int)item[3], (DateTime)item[4], (int)item[5]);
                lstRoom.Add(rm);
            }
        }

        public void LoadInfoCustomer(List<DTO_KhachHang> lstCustomer)
        {
            DataTable dt = new DataTable();
            dt = DAO_Room.Instance.LoadInfoCustomer();

            lstCustomer.AddRange(from DataRow row in dt.Rows select new DTO_KhachHang((string) row[0], (string) row[1], (string) row[2], (DateTime) row[3], (int) row[4]));
        }

        public void SapXepPhongTangDan(List<DTO_Room> lstRoom)
        {
            for (int i = 0; i < lstRoom.Count - 1; i++)
            {
                for (int j = i + 1; j < lstRoom.Count; j++)
                {
                    if (string.Compare(lstRoom[i].Name, lstRoom[j].Name) <= 0) continue;
                    DTO_Room rm = new DTO_Room();
                    rm = lstRoom[i];
                    lstRoom[i] = lstRoom[j];
                    lstRoom[j] = rm;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sokhu"></param>
        /// <param name="lstRoom"></param>
        /// <returns></returns>
        public int PhongMaxKhu(string sokhu, List<DTO_Room> lstRoom)
        {
            int Phongmaxkhu = 0;
            foreach (DTO_Room t in lstRoom)
            {
                if (t.Name[1].ToString() == sokhu)
                {
                    string sophong = "";
                    for (int j = 1; j <= 3; j++)
                    {
                        sophong += t.Name[j + 1].ToString();
                    }
                    int temp = int.Parse(sophong);

                    if (Phongmaxkhu < temp)
                    {
                        Phongmaxkhu = temp;
                    }
                }
            }
            return Phongmaxkhu;
        }

        /// <summary>
        /// Thêm phòng
        /// </summary>
        /// <param name="soluong"></param>
        /// <param name="sokhu"></param>
        /// <param name="loaiphong"></param>
        /// <param name="succhua"></param>
        /// <param name="Phongmaxkhu"></param>
        /// <param name="lstRoom"></param>
        /// <returns></returns>
        public int ThemPhong(int soluong, string sokhu, int loaiphong, int succhua, int Phongmaxkhu, List<DTO_Room> lstRoom)
        {
            Phongmaxkhu = PhongMaxKhu(sokhu, lstRoom);
            string querythemphong = @"insert into ROOM (name, type_room, status, amount) VALUES "; 
            for (int i = 0; i < soluong; i++)
            {
                //DTO_Room rm = new DTO_Room("P" + sokhu + (Phongmaxkhu + 1).ToString("000"), loaiphong, 0, succhua);
                string temp = "(" + "'P" + sokhu + (Phongmaxkhu + 1 + i).ToString("000") + "'," + loaiphong.ToString() + "," + 1 + "," + succhua.ToString() + ")" + ",";
                querythemphong += temp;

            }
            querythemphong = querythemphong.Remove(querythemphong.Length - 1);

            return DataProvider.Instance.ExecuteNonQuery(querythemphong);
        }

        public void LoadColor(List<DTO_RoomColor> lstRoomColor)
        {
            DataTable dt =  DAO_Room.Instance.LoadColor();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                DTO_RoomColor cl = new DTO_RoomColor((int)dr[0], (int)dr[1]);
                lstRoomColor.Add(cl);
            }
        }

        public int UpDateColorRoom(List<DTO_RoomColor> roomcolor)
        {
            string queryinsert = roomcolor.Select(item => "(" + item.Status + "," + item.CodeColor + ")" + ",").Aggregate("insert into room_color(status,code_color) values ", (current, temp) => current + temp);

            /*string queryinsert = "insert into room_color(status,code_color) values ";

            foreach (DTO_RoomColor item in roomcolor)
            {
                string temp = "(" + item.Status + "," + item.CodeColor + ")" + ",";
                queryinsert += temp;
            }
            */
            queryinsert = queryinsert.Remove(queryinsert.Length - 1);

            return DAO_Room.Instance.UpdateColor(queryinsert);
        }

        public int UpdateInfoRoom(string name, int type, int amount, int status)
        {
            //string query = @"update room set type_room = '"+ type +"', amount = '"+ amount +"', status = '"+status+"' where name = '" + name + "' ";
            return DAO_Room.Instance.UpdateInfoRoom(name, type, amount, status);
        } 

        public int GetStatus_ID(string idroom)
        {
            //string query = "select status from room where name = '" + idroom + "'";
            return DAO_Room.Instance.GetStatus_ID(idroom);
        }

        public int GetIndex_ID(List<DTO_Room> room, string id)
        {
            for(int i = 0; i < room.Count; i++)
            {
                if(room[i].Name == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public int GetIndexCustomer_ID(List<DTO_KhachHang> lstcustomer, string id_room)
        {
            for(int i = 0; i < lstcustomer.Count; i++)
            {
                if(lstcustomer[i].IdRoom == id_room)
                {
                    return i;
                }
            }
            return -1;
        }
        
        public int ChonPhong(string idroom, int tiendatcoc)
        {
            //string query = "update room set status = 2, start_time = GetDate() where name = '" + idroom + "'";
            return DAO_Room.Instance.ChonPhong_ID(idroom, tiendatcoc);
        }

        public int XoaPhong_ID(string idroom)
        {
            return DAO_Room.Instance.XoaPhong_ID(idroom);
        }

        public int DatPhong(string idroom, string name_customer, string phone_number, DateTime time_checkin, int deposits)
        {
            //Đổi trạng thái từ trống sang đã được đặt đến list
            foreach (var item in MainRooms.lstRoom.Where(name => name.Name == idroom))
            {
                item.Status = 3;
                item.Tiendatphong = deposits;
            }

            //Thêm thông tin khách hàng vào list
            DTO_KhachHang kh = new DTO_KhachHang(name_customer, phone_number, idroom, time_checkin, deposits);
            MainRooms.lstCustomer.Add(kh);

            //Đổi màu phòng
            foreach (var item in MainRooms.lstButton.Where(btnName => btnName.Name == idroom))
            {
                item.BackColor = Color.FromArgb(-65536);
            }

            return DAO_Room.Instance.DatPhong(idroom, name_customer, phone_number, time_checkin, deposits);
        }

        public DataTable LoadInfoCustomer()
        {
            return DAO_Room.Instance.LoadInfoCustomer();
        }

        public int ChuyenPhong(string idroom_hientai, DateTime giovao, string idroom_canchuyen, int tiendatphong)
        {
            return DAO_Room.Instance.ChuyenPhong(idroom_hientai, giovao, idroom_canchuyen, tiendatphong);
        }


        internal int sp_ThayDoiDatPhong_ID(string id_room, string name_customer, string sodienthoai, DateTime time_checkin, int tiendatcoc)
        {
            foreach (var item in MainRooms.lstCustomer.Where(name => name.IdRoom == id_room))
            {
                item.NameCustomer = name_customer;
                item.PhoneNumber = sodienthoai;
                item.TimeCheckin = time_checkin;
                item.Deposits = tiendatcoc;
            }   

            return DAO_Room.Instance.sp_ThayDoiDatPhong_ID(id_room, name_customer, sodienthoai, time_checkin, tiendatcoc);
        }

        public static int sp_HuyDatPhong(string p)
        {
           // Xóa nó trong lstCustomer
            int idx = MainRooms.lstCustomer.FindIndex(a => a.IdRoom == p);
            MainRooms.lstCustomer.RemoveAt(idx);

            //Cập nhật trạng thái của phòng in ListRoom
            foreach (var item in MainRooms.lstRoom.Where(a => a.Name == p))
            {
                item.Status = 1;
            }

            //Đổi màu lại trong ListButton về trống
            foreach (var item in MainRooms.lstButton.Where(b => b.Name == p))
            {
                item.BackColor = Color.FromArgb(-32576);
            }
             return DAO_Room.sp_HuyDatPhong(p);
        }

        public static int TuDongHuyDatPhong(string id_room)
        {
            return DAO_Room.TuDongHuyDatPhong(id_room);
        }

        public int Update_typeroom(int type, string decription)
        {
            return DAO_Room.Instance.Update_typeroom(type, decription);
        }

        public int Insert_typeroom(int type, string decription)
        {
            return DAO_Room.Instance.Insert_typeroom(type, decription);
        }

        public void LoadTypeRoom(List<DTO_RoomType> lstRoomtype)
        {
            DataTable RT = DAO_Room.Instance.LoadTypeRoom();
            for (int i = 0; i < RT.Rows.Count; i++)
            {
                DataRow row = RT.Rows[i];
                DTO_RoomType rmc = new DTO_RoomType((int)row[0], (string)row[1]);
                lstRoomtype.Add(rmc);
            }
        }

        public int Insert_RoomTimeSlot(int[] a, int type_room, int start_time)
        {
            return DAO_Room.Instance.Insert_RoomTimeSlot(a, type_room, start_time);
        }

        public int Update_RoomTimeSlot(int[] a, int type_room, int start_time)
        {
            return DAO_Room.Instance.Update_RoomTimeSlot(a, type_room, start_time);
        }
        public void LoadRoomTimeSlot(List<DTO_RoomTimeSlot> lstRoomtimeslot)
        {
            DataTable dt = DAO_Room.Instance.LoadRoomTimeSlot();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                DTO_RoomTimeSlot rtl = new DTO_RoomTimeSlot();
                rtl.TypeRoom = (int) row[1];
                rtl.StartTime = (int) row[2];
                for (int j = 0; j < 24; j++)
                {
                    rtl.TimeSlot[j] = (int) row[j + 3];
                }
                lstRoomtimeslot.Add(rtl);
            }
        }
    }
}
