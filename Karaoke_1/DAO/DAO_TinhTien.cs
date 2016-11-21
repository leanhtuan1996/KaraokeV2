using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke_1.DAO
{
    class DAO_TinhTien
    {
        private static DAO_TinhTien instance;

        public static DAO_TinhTien Instance
        {
            get { return instance ?? (instance = new DAO_TinhTien()); }
        }

        public double TienTrong1Ngay(int loaiphong)
        {
            double TienTrongNgay = 0;

            string query = @"Select     [1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12], [13], [14], [15], [16], [17], [18], [19], [20], [21], [22], [23], [0]
                            From        KindRoom
                            WHERE       type_room = " + loaiphong + "";


            SqlDataReader rd = DataProvider.Instance.Excutereader(query);

            rd.Read();
            for (int i = 0; i < 24; i++)
            {
                TienTrongNgay += (int)rd[i];
            }

            rd.Close();

            //DataProvider.Instance.ConnectionClose();

            return TienTrongNgay;
        }

        public SqlDataReader KiemTraPhuThu()
        {
            string query = @"SELECT ngay, phantramphuthu FROM PhuThu";

            return DataProvider.Instance.Excutereader(query);
        }
        public DataTable TinhTien(int loaiphong)
        {

            string query = @"Select    [1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12], [13], [14], [15], [16], [17], [18], [19], [20], [21], [22], [23], [0]
                            From		KindRoom
                            WHERE       type_room = " + loaiphong + "";

            return DataProvider.Instance.ExecuteQuery(query);
        }


    }
}
