using System;
using System.Windows.Forms;

using System.Globalization;
using Microsoft.VisualBasic.ApplicationServices;

namespace Karaoke_1.GUI
{
    static class Program
    {
        public static Form frm;
        [STAThread]

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            // Format DateTime theo US
            CultureInfo culture = new CultureInfo("en-US", true)
            {
                DateTimeFormat =
                {
                    ShortDatePattern = "yyyy/MM/dd",
                    LongDatePattern = "yyyy/MM/dd HH:mm:ss",
                    LongTimePattern = "HH:mm:ss",
                    DateSeparator = "/"
                }
            };
            Application.CurrentCulture = culture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Karaoke_1.Properties.Settings.Default.strConnect = "Server=.;Database=Karaoke;Trusted_Connection=True";
            //Karaoke_1.Properties.Settings.Default.strConnect = "";
            //Karaoke_1.Properties.Settings.Default.Save();

            bool Check = BUS.BUS_NameServer.Instance.Check_Connect(Karaoke_1.Properties.Settings.Default.strConnect);

            if (Check == true)
            {
                frm = new frmLogin();
            }
            else
            {
                frm = new frmConnect();
            }

            SingleInstanceApplication.Run(frm, NewInstanceHandler);
        }
        #region
        public static void NewInstanceHandler(object sender,

        StartupNextInstanceEventArgs e)
        {

            // Kích hoạt cửa sổ của instance đang chạy

            // Bạn có thể thay thế bằng 1 hành động khác
            frm.WindowState = FormWindowState.Normal;
            frm.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - frm.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - frm.Height) / 2);

        }

        /// <summary>

        /// Lớp này dùng để gọi chạy form dạng single instance

        /// </summary>

        public class SingleInstanceApplication : WindowsFormsApplicationBase
        {

            private SingleInstanceApplication()
            {

                base.IsSingleInstance = true;

            }

            public static void Run(Form f,

            StartupNextInstanceEventHandler startupHandler)
            {

                SingleInstanceApplication app = new SingleInstanceApplication();

                app.MainForm = f;

                app.StartupNextInstance += startupHandler;

                app.Run(Environment.GetCommandLineArgs());

            }

        }
        #endregion
    }

}