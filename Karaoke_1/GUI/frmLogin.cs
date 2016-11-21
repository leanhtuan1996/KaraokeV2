using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HPTCMessageBox;
using System.Threading;
using MetroFramework.Forms;
using MetroFramework;
using Karaoke_1.BUS;

namespace Karaoke_1.GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            MSBox.BackgroundColor = Color.WhiteSmoke; // Màu nền
            MSBox.OutlineColor = Color.Tomato; // Viền
            MSBox.TextColor = Color.Black; // Màu chữ
            txtPassword.UseSystemPasswordChar = true;

            Program.frm = this;
        }

        private Thread thrd;
        public void Load_Image()
        {
            this.BackgroundImage = Properties.Resources.login1234;
            this.BackgroundImageLayout = ImageLayout.Center;
            ptbMatKhau.Image = Properties.Resources.Visible_961;
            btnLogin.BackgroundImage = Properties.Resources.login2222;
        }

        string temp;

        public static int FormStyle;
        public static int INDEX_User;

        public void Load_txtID()
        {
            string[] arr = BUS_Name_Clone.Instance.GetID_Style();
            temp = arr[0];
            FormStyle = Convert.ToInt32(arr[1]);
            txtID.Text = temp;
            chkID.Checked = true;
            txtPassword.Focus();
        }

        public void LOAD()
        {
            // Load hinh anh len
            thrd = new Thread(Load_Image);
            thrd.Start();
            // Load txtID dang nhap lan truoc len
            Load_txtID();
        }

        public void DANGNHAP()
        {
            string[] result = BUS_Login.Instance.Login(txtID.Text, txtPassword.Text);
            if (string.IsNullOrEmpty(result[1]) || result[1].Contains("Nhân Viên") == true)
            {
                MSBox msb = new MSBox("Error", "ID hoặc Passwork không đúng. Vui lòng kiểm tra lại!", "Đồng ý", MSBox.MSBoxIcon.Error);
                msb.ShowDialog();
            }
            else
            {
                INDEX_User = 0;
                if (chkID.Checked == true && temp.Contains(txtID.Text) == false)
                {
                    string RESULT = BUS_Name_Clone.Instance.Set_UserName(temp, txtID.Text);
                    if (!string.IsNullOrEmpty(RESULT))
                    {
                        MSBox msg = new MSBox("Error", "Không ghi nhớ được tên TK. Vui lòng kiểm tra lại!", "Đồng ý", MSBox.MSBoxIcon.Error);
                        msg.ShowDialog();
                    }
                }

                // input get when you login: index_user, name_position
                if (result[1].Contains("ADMIN") == true)
                {
                    frmMain frmmain = new frmMain();
                    this.Visible = false;
                    frmmain.ShowDialog();

                    this.Visible = true;
                    txtPassword.Clear();
                }
                else
                {
                    INDEX_User = Convert.ToInt32(result[0]);
                    string position = result[1];

                    // update status
                    string error = BUS_Login.Instance.Update_status(INDEX_User, "ONLINE");
                    if (!string.IsNullOrEmpty(error))
                    {
                        MessageBox.Show(error);
                    }
                    else
                    {
                        if (position.Contains("Quản Lý") == true)
                        {
                            frmQuanLyNhanVien frmQL = new frmQuanLyNhanVien();
                            this.Visible = false;
                            frmQL.ShowDialog();

                            this.Visible = true;
                            txtPassword.Clear();
                        }
                        else if (position.Contains("Thu Ngân") == true)
                        {
                            // new form thu ngan
                        }
                        else
                        {
                            // new form thu kho
                        }
                    }
                }
            }
        }


        private void Login_Load(object sender, EventArgs e)
        {
            LOAD();
        }

        private void ptbMatKhau_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MSBox msb = new MSBox("Thông Báo", "ID không được rỗng. Vui lòng kiểm tra lại!", "Đồng ý", MSBox.MSBoxIcon.Infomation);
                msb.ShowDialog();
                //MetroMessageBox.Show(this, "ID không được rỗng. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 160);
                txtID.Focus();
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MSBox msb = new MSBox("Thông Báo", "Passwords không được rỗng. Vui lòng kiểm tra lại!", "Đồng ý", MSBox.MSBoxIcon.Infomation);
                msb.ShowDialog();
                //MetroMessageBox.Show(this, "Passwords không được rỗng. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 160);
                txtPassword.Focus();
            }
            else
            {
                DANGNHAP();
            }
        }

        Boolean flag;
        int x, y;
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void ptbMatKhau_MouseHover(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }


    }
}
