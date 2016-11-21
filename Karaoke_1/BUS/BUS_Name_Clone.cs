using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;


namespace Karaoke_1.BUS
{
    public class BUS_Name_Clone
    {
        static BUS_Name_Clone instance;
        public static BUS_Name_Clone Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_Name_Clone();
                }
                return instance;
            }
        }

        BUS_Name_Clone() { }

        public string[] GetID_Style()
        {
            string[] result = new string[2];
            try
            {
                using (StreamReader sr = new StreamReader("Local.txt"))
                {
                    string str = "";
                    while ((str = sr.ReadLine()) != null)
                    {
                        if (str.Contains("Login.ID") == true)
                        {
                            result[0] = str.Substring(11);
                        }

                        if (str.Contains("qlnv.FormStyle") == true)
                        {
                            result[1] = str.Substring(17);
                        }
                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public string Set_UserName(string Old, string New)
        {
            try
            {
                string[] arr = File.ReadAllLines("Local.txt");
                File.Delete("Local.txt");
                for (int i = 0; i < arr.Length; ++i)
                {
                    if (arr[i].Contains(Old) == true)
                    {
                        arr[i] = arr[i].Replace(Old, New);
                    }
                }

                using (StreamWriter sw = new StreamWriter("Local.txt", true))
                {
                    for (int i = 0; i < arr.Length; ++i)
                    {
                        sw.WriteLine(arr[i]);
                    }
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return "";
        }

    }
}
