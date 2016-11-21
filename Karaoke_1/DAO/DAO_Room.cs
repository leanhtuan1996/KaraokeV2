using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using Karaoke_1.DTO;

namespace Karaoke_1.DAO
{
    class DAO_Room
    {
        static DAO_Room instance;

        public static DAO_Room Instance
        {
            get { return instance ?? (instance = new DAO_Room()); }
        }

        public DataTable LoadInfoRoom()
        {
            //string query = "select  name, type_room, status, amount, start_time from room";

            //dt = DataProvider.Instance.ExecuteQuery(query);
            var dt = DataProvider.Instance.ExecuteQuery_SP("sp_Room_LoadInfoRoom");

            return dt;
        }

        public DataTable LoadColor()
        {
            return DataProvider.Instance.ExecuteQuery_SP("sp_RoomColor_LoadColor");
        }

        public int UpdateColor(string queryinsert)
        {
            DataProvider.Instance.EXECUTENONQUERY_SP("sp_RoomColor_DeleteColor");

            return DataProvider.Instance.ExecuteNonQuery(queryinsert);
        }

        public int UpdateInfoRoom(string name, int type, int amount, int status)
        {
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@idroom", SqlDbType.VarChar, 15) {Value = name};
            para[1] = new SqlParameter("@type_room", SqlDbType.Int) {Value = type};
            para[2] = new SqlParameter("@amount", SqlDbType.Int) {Value = amount};
            para[3] = new SqlParameter("@status", SqlDbType.Int) {Value = status};

            return DataProvider.Instance.ExecuteNonQuery_SP("sp_Room_UpdateInfo_ID", para);
        }

        public int GetStatus_ID(string idroom)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@idroom", SqlDbType.VarChar, 15) {Value = idroom};
            return (int)DataProvider.Instance.ExecuteScalar_SP("sp_Room_GetStatus_ID", para);
        }


        public int ChonPhong_ID(string idroom, int tiendatcoc)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@idroom", SqlDbType.VarChar, 15) {Value = idroom};
            para[1] = new SqlParameter("@tiendatphong", SqlDbType.Int){Value = tiendatcoc};
            return DataProvider.Instance.ExecuteNonQuery_SP("sp_Room_ThuePhong_ID", para);
        }

        public int XoaPhong_ID(string idroom)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@idroom", SqlDbType.VarChar, 15) {Value = idroom};
            //string query = "delete from room where name = '" + idroom + "'";
            return DataProvider.Instance.ExecuteNonQuery_SP("sp_Room_DeleteRoom_ID", para);
        }

        public int DatPhong(string idroom, string name_customer, string phone_number, DateTime time_checkin, int deposits)
        {
            //string query_InFoCustomer = "insert into Reservation_room(name_customer, phone_number, name, time_checkin, deposits) values (N'" + name_customer + "', '" + phone_number + "','" + idroom + "' , '" + time_checkin + "', '" + deposits + "' )";
            //string query_ChangeStatus = "update room set status = 3 where name = '"+idroom+"'";
            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@idroom", SqlDbType.VarChar, 15) {Value = idroom};
            para[1] = new SqlParameter("@name_customer", SqlDbType.NVarChar, 50) {Value = name_customer};
            para[2] = new SqlParameter("@phone_number", SqlDbType.NVarChar, 15) {Value = phone_number};
            para[3] = new SqlParameter("@time_checkin", SqlDbType.DateTime) {Value = time_checkin};
            para[4] = new SqlParameter("@deposits", SqlDbType.Int) {Value = deposits};
            //DataProvider.Instance.ExecuteNonQuery(query_ChangeStatus);
            return DataProvider.Instance.ExecuteNonQuery_SP("sp_Room_DatPhong", para);
        }

        public DataTable LoadInfoCustomer()
        {
            //string query = "select name_customer, phone_number, name,  time_checkin, deposits from Reservation_Room";
            return DataProvider.Instance.ExecuteQuery_SP("sp_ReservationRoom_Loadinfo");
        }

        public int ChuyenPhong(string idroom_hientai, DateTime Thoigianvao,  string idroom_canchuyen, int tiendatphong)
        {
            //string query_capnhattrangthaiphong = "update room set status = 1 where name = '" + idroom_hientai + "'";
            //string query_capnhatthoigian = "update room set status = 2, start_time = '"+Thoigianvao+"'  where name = '" + idroom_canchuyen + "'";

            //DataProvider.Instance.ExecuteNonQuery(query_capnhattrangthaiphong);
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@idroomHienTai", SqlDbType.VarChar, 15) {Value = idroom_hientai};
            para[1] = new SqlParameter("@idroomCanChuyen", SqlDbType.VarChar, 15) {Value = idroom_canchuyen};
            para[2] = new SqlParameter("@thoigianvao", SqlDbType.DateTime) {Value = Thoigianvao};
            para[3] = new SqlParameter("@tiendatphong", SqlDbType.Int){Value = tiendatphong};

            return DataProvider.Instance.ExecuteNonQuery_SP("sp_Room_ChuyenPhong", para);
        }

        internal int sp_ThayDoiDatPhong_ID(string id_room, string name_customer, string sodienthoai, DateTime time_checkin, int tiendatcoc)
        {
            var para = new SqlParameter[5];
            para[0] = new SqlParameter("@id_room", SqlDbType.VarChar, 15) {Value = id_room};
            para[1] = new SqlParameter("@name_customer", SqlDbType.NVarChar, 50) {Value = name_customer};
            para[2] = new SqlParameter("@phone", SqlDbType.VarChar, 15) {Value = sodienthoai};
            para[3] = new SqlParameter("@time_checkin", SqlDbType.DateTime){Value = time_checkin};
            para[4] = new SqlParameter("@deposits", SqlDbType.Int){Value = tiendatcoc};

            return DataProvider.Instance.ExecuteNonQuery_SP("sp_ThayDoiDatPhong_ID", para);
        }

        internal static int sp_HuyDatPhong(string p)
        {
            var para = new SqlParameter[1];
            para[0] = new SqlParameter("@id_room", SqlDbType.VarChar,15){Value = p};
            return DataProvider.Instance.ExecuteNonQuery_SP("sp_HuyDatPhong_ID", para);
        }

        internal static int TuDongHuyDatPhong(string id_room)
        {
            var para = new SqlParameter[1];
            para[0] = new SqlParameter("@id_room", SqlDbType.VarChar, 15) {Value = id_room};
            return DataProvider.Instance.ExecuteNonQuery_SP("sp_TuHuyDonDatPhong", para);
        }

        internal int Update_typeroom(int type, string decription)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@type", SqlDbType.Int);
            para[0].Value = type;
            para[1] = new SqlParameter("@decription", SqlDbType.NText);
            para[1].Value = decription;
            return DataProvider.Instance.ExecuteNonQuery_SP("Update_typeroom", para);
        }

        internal int Insert_typeroom(int type, string decription)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@type", SqlDbType.Int);
            para[0].Value = type;
            para[1] = new SqlParameter("@decription", SqlDbType.NText);
            para[1].Value = decription;
            return DataProvider.Instance.ExecuteNonQuery_SP("Insert_typeroom", para);
        }

        internal DataTable LoadTypeRoom()
        {
            var dt = DataProvider.Instance.ExecuteQuery_SP("LoadTypeRoom");
            return dt;
        }

        internal int Insert_RoomTimeSlot(int[] a, int type_room, int start_time)
        {
            SqlParameter[] para = new SqlParameter[26];
            para[0] = new SqlParameter("@type_room", SqlDbType.Int);
            para[0].Value = type_room;
            para[1] = new SqlParameter("@start_time", SqlDbType.Int);
            para[1].Value = start_time;
            for (int i = 0; i < 24; i++)
            {
                para[i + 2] = new SqlParameter("@arr_"+i.ToString()+"", SqlDbType.Int);
                para[i + 2].Value = a[i];
            }
            return DataProvider.Instance.ExecuteNonQuery_SP("sp_Insert_RoomTimeSlot", para);
        }

        public DataTable LoadRoomTimeSlot()
        {
            DataTable dt;
            dt = DataProvider.Instance.ExecuteQuery_SP("sp_LoadRoomTimeSlot");
            return dt;
        }

        internal int Update_RoomTimeSlot(int[] a, int type_room, int start_time)
        {
            SqlParameter[] para = new SqlParameter[26];
            para[0] = new SqlParameter("@type_room", SqlDbType.Int);
            para[0].Value = type_room;
            para[1] = new SqlParameter("@start_time", SqlDbType.Int);
            para[1].Value = start_time;
            for (int i = 0; i < 24; i++)
            {
                para[i + 2] = new SqlParameter("@arr_" + i.ToString() + "", SqlDbType.Int);
                para[i + 2].Value = a[i];
            }
            return DataProvider.Instance.ExecuteNonQuery_SP("sp_Update_RoomTimeSlot", para);
        }
    }
}
