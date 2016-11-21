using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Karaoke_1.DAO;
using Karaoke_1.DTO;
using System.Data.SqlClient;

namespace Karaoke_1.BUS
{
    class BUS_TinhTien
    {
        static BUS_TinhTien instance;

        public static BUS_TinhTien Instance
        {
            get { return instance ?? (instance = new BUS_TinhTien()); }
        }

        private int Phut(int gio, int phut)
        {
            return gio * 60 + phut;
        }

        string Gio(int time)
        {
            string s = "";

            int gio, phut;

            gio = time / 60;
            gio = gio == 24 ? 0 : gio;
            phut = time % 60;

            s = (gio < 10 ? ('0' + Convert.ToString(gio)) : Convert.ToString(gio)) + ':' + (phut < 10 ? ('0' + Convert.ToString(phut)) : Convert.ToString(phut));

            return s;
        }

        public double LamTron(double tien)
        {
            double temp;

            temp = tien / 1000;

            double thapphan = temp - (int)temp;

            if (thapphan > 0 && thapphan < 0.5)
                tien = (int)temp * 1000 + 500;
            else if (thapphan > 0.5)
                tien = (int)temp * 1000 + 1000;

            return tien;
        }

        public double TienTrong1Ngay(int loaiphong)
        {
            return DAO_TinhTien.Instance.TienTrong1Ngay(loaiphong);
        }

        void Xoa(List<DTO_TienGio> arr_TienGio)
        {


            for (int i = 0; i < arr_TienGio.Count; i++)
            {
                string[] arr = new string[2];
                arr[0] = arr_TienGio[0].Timeslot.Substring(0, 5);

                int lenght = arr_TienGio[arr_TienGio.Count - 1].Timeslot.Length;

                arr[1] = arr_TienGio[arr_TienGio.Count - 1].Timeslot.Substring(lenght - 5, 5);
                if (arr[0].CompareTo(arr[1]) == 0)
                {
                    arr_TienGio.RemoveAt(i);
                }
            }
        }

        double KiemTraPhuthu(DateTime ngay, double tien)
        {
            int phuthu = -1;

            SqlDataReader rd = DAO_TinhTien.Instance.KiemTraPhuThu();

            while (rd.Read())
            {
                //MessageBox.Show(ngay.Date.ToString("dd-MM-yyyy") + " - " + Convert.ToDateTime(rd[0]).ToString("dd-MainMenu-yyyy"));
                if (ngay.Date != Convert.ToDateTime(rd[0]).Date) continue;
                phuthu = (int)rd[1];
                //MessageBox.Show("phụ thu " + phuthu);
                break;
            }
            rd.Close();


            tien += (phuthu != -1) ? (tien * (phuthu / 100.0)) : 0; //nếu có phụ thu thì + thêm tiền, ngược lại ko cộng

            return tien;
        }

        double TinhTien(int phutvao, int phutra, int loaiphong, List<DTO_TienGio> arr_TienGio)
        {
            double tien = 0;

            if (phutra == 0 && phutvao == 0)
            {
                return TienTrong1Ngay(loaiphong);
            }

            if (phutra < phutvao)
            {
                phutra = phutra + 24 * 60;
            }

            double tienphut = 0;

            DataTable dt = new DataTable();
            dt = DAO_TinhTien.Instance.TinhTien(loaiphong);

            int i = 0; //tượng trưng cho giờ

            int secondminute = 0;
            double tien_timeslot = 0;

            int cot;

            int start_time, end_time;
            start_time = phutvao;
            end_time = 0;

            bool Check = false;

            while (true)
            {
                if (i == 24)
                    i = 0;


                /*ex: vào 23h30 = 1410 thì i lúc này = 23
                Áp dụng công thức ở if (1410 <= (23+1)*60) thỏa                   
                */
                if (phutvao <= (i + 1) * 60)
                {
                    if (dt != null)
                    {
                        tienphut = (int)dt.Rows[0][i] / 60;


                        cot = i == 0 ? 23 : i - 1; // i=0 tương đương 1h, i=23 tương đương 0h
                        if ((int)dt.Rows[0][cot] != (int)dt.Rows[0][i])
                        {


                            end_time = (i == 0 || i == 23) ? (i == 0 ? 0 : 23 * 60) : i * 60;

                            if (start_time == 0 && ((int)dt.Rows[0][23] == (int)dt.Rows[0][0]))
                            {

                                if (arr_TienGio.Count != 0)
                                {
                                    end_time = i * 60;
                                    int lenght = arr_TienGio[arr_TienGio.Count - 1].Timeslot.Length;

                                    string chuoi = arr_TienGio[arr_TienGio.Count - 1].Timeslot.Substring(lenght - 5, 5);

                                    string kq = Gio(end_time);

                                    arr_TienGio[arr_TienGio.Count - 1].Timeslot = arr_TienGio[arr_TienGio.Count - 1].Timeslot.Replace(chuoi, kq);

                                }

                            }
                            else
                            {
                                if (start_time / 60 != end_time / 60)
                                {
                                    DTO_TienGio TG = new DTO_TienGio(Gio(start_time) + " - " + Gio(end_time), LamTron(tien_timeslot));
                                    arr_TienGio.Add(TG);
                                }
                                else
                                    end_time = start_time;

                            }

                            secondminute = 0;
                            tien_timeslot = 0;

                            Check = true;//= true mới lưu lại start_time                      
                        }
                        else
                            Check = false;
                    }


                    if ((i + 1) * 60 > phutra) // điều kiện dừng
                    {

                        start_time = end_time;
                        end_time = phutra;

                        DTO_TienGio TG = new DTO_TienGio(Gio(start_time) + "  - " + Gio(end_time), LamTron((phutra - phutvao) * tienphut + tien_timeslot));
                        arr_TienGio.Add(TG);
                        tien += (phutra - phutvao) * tienphut;

                        break;
                    }
                    else
                    {

                        if (Check)
                            start_time = phutvao; //nếu giá tiền khác với giờ trước đó thì lưu lại giờ bắt đầu của timeslot mới

                        tien += ((i + 1) * 60 - phutvao) * tienphut;

                        secondminute += ((i + 1) * 60 - phutvao);  //thêm

                        tien_timeslot += ((i + 1) * 60 - phutvao) * tienphut;//thêm

                        phutvao = (i + 1) * 60;


                        if (phutvao == 1440)
                        {
                            phutvao = 0;
                            phutra -= 1440;
                        }
                    }

                }
                i++;
            }

            //Xoa(arr_TienGio);
            return LamTron(tien);
        }

        public double PhuThu(DateTime vao, DateTime ra, int loaiphong, ref int tongthoigiansudung, List<DTO_TienGio> arr_TienGio)
        {
            double tien = 0, tien_temp = 0;
            string[] arr;

            string kq1 = (ra - vao).ToString();

            arr = kq1.Split('.', ':');

            DateTime date_temp = new DateTime();
            date_temp = vao;
            int dem = 0;

            int phutvao = Phut(vao.Hour, vao.Minute);
            int phutra = Phut(ra.Hour, ra.Minute);

            tongthoigiansudung = (phutra < phutvao) ? (phutra + 24 * 60 - phutvao) : phutra - phutvao;


            /*
                - Ví dụ: vào lúc 16h10p ngày 29/4/2016
                        ra lúc 19h20 ngày 2/5/2016
             */

            if (arr.Count() == 4 || (vao.Date != ra.Date)) //nghĩa là nó ngủ ở trỏng hơn 1 ngày -_-
            {
                //if (Convert.ToInt16(arr[0]) < 1) return LamTron(tien);
                tongthoigiansudung += Convert.ToInt16(arr[0]) * 24 * 60;


                if (arr.Count() == 4)
                {
                    DTO_TienGio TG = new DTO_TienGio(arr[0].ToString() + " ngày", Convert.ToInt16(arr[0]) * TienTrong1Ngay(loaiphong));
                    arr_TienGio.Add(TG);
                }


                int j = 1;
                while (true)
                {
                    /*
                            - Lần lặp đầu tiên:
                         *                      j=0 <=> ngày 29/4, phút vào là 980, date_temp = vao.AddDayS(1).Date = 0h 30/4/2016            
                         *                      
                         *                          tien += TinhTien4(980, 0, loaiphong, arr);
                         *                          
                         *                          if(date_temp == ra.Date) 30/4 0h = 2/5 0h (KO THỎA)
                         *                          pvao = Phut(date_temp.hour, minute) = Phut(0, 0) = 0
                         *                      
                         *  - Lần lặp thứ 2:
                         *                      j=1 <=> ngày 30/4, phutvao = 0, date_temp = vao.AddDays(2).Date = 0h 1/5/2016
                         *                      
                         *                          tien += TinhTien4(0, 0, loaiphong, arr);
                         *                                                   
                         *                          if(date_temp == ra.Date) 1/5 0h = 2/5 0h (KO THỎA)                         
                         * 
                         *                          pvao = Phut(date_temp.hour, minute) = 0
                         *                      
                         *  - Lần lặp thứ 3:
                         *                      j=3 <=> ngày 1/5, phutvao = 0, date_temp = vao.AddDays(3).Date = 0h 2/5/2016
                         *                      
                         *                          tien += TinhTien4(0, 0, loaiphong, arr);
                         *                          
                         *                          if(date_temp == ra.Date) 2/5 0h = 2/5 0h (THỎA)
                         *                          {
                         *                                  if(Phut(date_temp.hour, date_temp.minute) = 0 & phutra = 0)   (0 = 0) & )19h10 != 0)       KO THỎA
                         *                                  
                         *                                  else
                         *                                  {
                         *                                      TinhTien(Phut(date_temp.hour, date_temp.minute), phutra) = TinhTien(0, 19h10)
                         *                                      break;
                         *                                  }
                         *                          }
                                                            
                         */



                    date_temp = vao.AddDays(j).Date; //0h ngày 30/4

                    //vao.AddDays(j).Date //0h ngày 29/4 trước date_temp 1 ngày

                    tien += KiemTraPhuthu(vao.AddDays(j - 1).Date, TinhTien(phutvao, Phut(date_temp.Hour, date_temp.Minute), loaiphong, arr_TienGio));

                    if (date_temp.Date == ra.Date) //ngày 2/5 = 2/5 (chỉ cần so sánh ngày)
                    {

                        //SD cho trường hợp vào 0h0p ngày 30/4, ra lúc 0h0p ngày 1/5


                        if (phutra == 0 && Phut(date_temp.Hour, date_temp.Minute) == 0) //vào 0h0p ngày 2/5 ra lúc 0h0p ngày 4/5
                        {
                            break;
                        }


                        else//vào 0h0p ngày 2/5 ra lúc 19h10p ngày 4/5
                        {
                            tien += KiemTraPhuthu(ra, TinhTien(Phut(date_temp.Hour, date_temp.Minute), phutra, loaiphong, arr_TienGio));
                            break;
                        }
                    }
                    phutvao = Phut(date_temp.Hour, date_temp.Minute);
                    j++;
                }
            }

            else //trường hợp nó giờ vào, ra cùng 1 ngày
            {
                tien += KiemTraPhuthu(ra, TinhTien(phutvao, phutra, loaiphong, arr_TienGio));

            }//end else 


            return LamTron(tien);
        }


        //đừng xóa
        /*
        public double TinhTien2(int phutvao, int phutra, string[] arr, int loaiphong, ref int tongthoigiansudung)
        {
            double tien = 0;

            double TienTrongNgay = TienTrong1Ngay(loaiphong);

            if (arr.Count() == 4) //nghĩa là nó ngủ ở trỏng hơn 1 ngày -_-
            {
                if (Convert.ToInt16(arr[0]) >= 1) //ngày >= 1
                {
                    tien += (Convert.ToInt16(arr[0]) * TienTrongNgay);
                    tongthoigiansudung = Convert.ToInt16(arr[0]) * 24 * 60;

                }

            }   


            //--------------------
            if (phutra < phutvao)
            {
                phutra = phutra + 24 * 60;
            }

            tongthoigiansudung += (phutra - phutvao);

            double tienphut = 0;

            DataTable dt = new DataTable();
            dt = DAO_TinhTien.Instance.TinhTien(loaiphong);

            int i = 0;

            while (true)
            {
                if (i == 24)
                    i = 0;

                if (phutvao <= (i + 1) * 60)
                {
                    tienphut = (int)dt.Rows[0][i] / 60;

                    if ((i + 1) * 60 > phutra)
                    {                
                        tien += (phutra - phutvao) * tienphut;
                        break;
                    }
                    else
                    {
                        tien += ((i + 1) * 60 - phutvao) * tienphut;

                        phutvao = (i + 1) * 60;

                        if (phutvao == 1440)
                        {
                            phutvao = 0;
                            phutra -= 1440;
                        }
                    }

                }

                i++;

            }

            return tien;
        }
         */
    }
}
