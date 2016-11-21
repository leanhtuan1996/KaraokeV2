using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Karaoke_1.DAO;
using System.Data.SqlClient;

namespace Karaoke_1.BUS
{
    public class BUS_qlnv
    {
        static BUS_qlnv instance;

        public static BUS_qlnv Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_qlnv();
                }
                return instance;
            }
        }

        BUS_qlnv() { }

        public string[] ARR = new string[14];
        public DataTable View_ONLINE()
        {
            return DAO_qlnv.Instance.Load_dsnvONLINE();
        }
        
        public List<string[]> Load_Info(int idx_user)
        {
            List<string []> List_Info = new List<string []>();

            SqlDataReader dr = DAO_ThongTinTK.Instance.Load_Info();
            while (dr.Read())
            {
                string[] arr = new string[14];
                if (dr["index"].ToString().Contains(idx_user.ToString()) == true)
                {
                    ARR[0] = dr["index"].ToString();
                    ARR[1] = dr["id"].ToString();
                    ARR[2] = dr["full_name"].ToString();
                    ARR[3] = dr["nick_name"].ToString();
                    ARR[4] = dr["birthday"].ToString().Substring(0,10);
                    ARR[5] = dr["sex"].ToString();
                    ARR[6] = dr["marital_status"].ToString();
                    ARR[7] = dr["cmnd"].ToString();
                    ARR[8] = dr["photo"].ToString();
                    ARR[9] = dr["status"].ToString();
                    ARR[10] = dr["phone_number"].ToString();
                    ARR[11] = dr["name"].ToString();
                    ARR[12] = dr["account_name"].ToString();
                    ARR[13] = dr["account_pass"].ToString();
                }

                arr[0] = dr["index"].ToString();
                arr[1] = dr["id"].ToString();
                arr[2] = dr["full_name"].ToString();
                arr[3] = dr["nick_name"].ToString();
                arr[4] = dr["birthday"].ToString();
                arr[5] = dr["sex"].ToString();
                arr[6] = dr["marital_status"].ToString();
                arr[7] = dr["cmnd"].ToString();
                arr[8] = dr["photo"].ToString();
                arr[9] = dr["status"].ToString();
                arr[10] = dr["phone_number"].ToString();
                arr[11] = dr["name"].ToString();
                arr[12] = dr["account_name"].ToString();
                arr[13] = dr["account_pass"].ToString();
                List_Info.Add(arr);
            }
            dr.Close();
            dr.Dispose();
            DataProvider.Instance.ConnectionClose();
            return List_Info;
        }

        public List<string []> Load_Position()
        {
            List<string[]> List = new List<string[]>();
 
            SqlDataReader dr = DAO_ThongTinTK.Instance.Load_Position();
            while(dr.Read())
            {
                if (dr["name"].ToString().CompareTo("ADMIN") == 0 || dr["basic_salary"].ToString().CompareTo("0") == 0 || dr["allowance"].ToString().CompareTo("0") == 0)
                {
                    //continue;
                }
                else
                {
                    string[] arr = new string[3];
                    arr[0] = dr["name"].ToString();
                    arr[1] = dr["basic_salary"].ToString();
                    arr[2] = dr["allowance"].ToString();
                    List.Add(arr);
                }
            }
            dr.Close();
            dr.Dispose();
            DataProvider.Instance.ConnectionClose();
            return List;

        }

        public List<string[]> GetList(int selectedindex, string txtTimKiem, List<string[]> List)
        {
            string txtTK = Edit_string(txtTimKiem);
            List<string[]> List_User = new List<string[]>();
            foreach(string [] arr in List)
            {
                for (int i = 0; i < arr.Length;++i )
                {
                    if (selectedindex == 0)
                    {
                        // Ma
                        if (Edit_string(arr[1]).Contains(txtTK) == true)
                        {
                            List_User.Add(arr);
                            break;
                        }
                    }
                    else if (selectedindex == 1)
                    {
                        // ten
                        if (Edit_string(arr[2]).Contains(txtTK) == true)
                        {
                            List_User.Add(arr);
                            break;
                        }
                    }
                    else if (selectedindex == 2)
                    {
                        // cmnd
                        if (Edit_string(arr[7]).Contains(txtTK) == true)
                        {
                            List_User.Add(arr);
                            break;
                        }
                    }
                    else if (selectedindex == 3)
                    {
                        // chuc vu
                        if (Edit_string(arr[11]).Contains(txtTK) == true)
                        {
                            List_User.Add(arr);
                            break;
                        }

                    }
                    else if (selectedindex == 4)
                    {
                        // gioi tinh
                        if (Edit_string(arr[5]).Contains(txtTK) == true)
                        {
                            List_User.Add(arr);
                            break;
                        }
                    }
                    else
                    {
                        // sdt
                        if (Edit_string(arr[10]).Contains(txtTK) == true)
                        {
                            List_User.Add(arr);
                            break;
                        }
                    }
                }
            }
            return List_User;
        }

        public string [] Show(string tag, List<string []> list)
        {
            string [] ARR = new string[14];
            foreach(string [] arr in list)
            {
                if (arr[0].ToString().Contains(tag) == true)
                {
                    ARR = arr;
                    break;
                }
            }
            return ARR;
        }

        public string Edit_string(string str)
        {
            return str.ToLower();
        }
    }
}