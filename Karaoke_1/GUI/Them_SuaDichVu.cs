using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using HPTCMessageBox;

using Karaoke_1.BUS;

namespace Karaoke_1.GUI
{
    public partial class ThemSuaDichVu : MetroForm
    {
        public ThemSuaDichVu()
        {
            InitializeComponent();
        }

        public static bool Check = true;

        public static string Names;
        public static string Unit;
        public static int Price;
        public static string Description;

        private void btnThemDanhSach_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            arr[0] = txtName.Text;
            arr[1] = txtUnit.Text;
            arr[2] = txtPrice.Text;
            arr[3] = txtDescription.Text;


            ListViewItem item = new ListViewItem(arr);

            lstDichVuThem.Items.Add(item);
        }


        private void lstDichVuThem_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            if (lstDichVuThem.FocusedItem.Bounds.Contains(e.Location) == true)
            {
                cmtDichVu.Show(Cursor.Position);
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (Check == true)
            {
                int check = 0;
                for (int i = 0; i < lstDichVuThem.Items.Count; i++)
                {
                    Name = lstDichVuThem.Items[i].SubItems[0].Text;
                    Unit = lstDichVuThem.Items[i].SubItems[1].Text;
                    Price = int.Parse(lstDichVuThem.Items[i].SubItems[2].Text);
                    Description = lstDichVuThem.Items[i].SubItems[3].Text;

                    if(Description == "")
                    {
                        Description = "-";
                    }

                    check = BUS_Menu.Instance.sp_ThemDichVu(Name, Unit, Price, Description);
                }

                if (check != 0)
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                if (BUS_Menu.Instance.sp_SuaDichVu(txtName.Text, txtUnit.Text, int.Parse(txtPrice.Text), txtDescription.Text) != 0)
                {
                    MessageBox.Show("Chỉnh sửa thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa thất bại");
                }

            }

        }

        private void ThemSuaDichVu_Load(object sender, EventArgs e)
        {
            grpDichVu.Visible = true;
            btnThemDanhSach.Visible = true;
            if (Check == false)
            {
                this.Text = "Sửa dịch vụ";
                txtName.Enabled = false;
                grpDichVu.Visible = false;
                btnThemDanhSach.Visible = false;
                this.Size = new System.Drawing.Size(502, 370);
                btnDongY.Location = new Point(100, 273);
                btnHuy.Location = new Point(300, 273);
                txtName.Text = Names;
                txtUnit.Text = Unit;
                txtPrice.Text = Price.ToString();
                txtDescription.Text = Description;
            }
            else
            {
                this.Text = "Thêm dịch vụ";
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        


    }
}
