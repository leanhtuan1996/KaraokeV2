namespace Karaoke_1.GUI
{
    partial class frmConnect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbbTenServer = new MetroFramework.Controls.MetroComboBox();
            this.chkXacThuc = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtDangNhap = new MetroFramework.Controls.MetroTextBox();
            this.txtMatKhau = new MetroFramework.Controls.MetroTextBox();
            this.btnKetNoi = new MetroFramework.Controls.MetroButton();
            this.btnThoat = new MetroFramework.Controls.MetroButton();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Tên Server";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(1, 78);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(101, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Tên đăng nhập";
            // 
            // cbbTenServer
            // 
            this.cbbTenServer.FormattingEnabled = true;
            this.cbbTenServer.ItemHeight = 24;
            this.cbbTenServer.Location = new System.Drawing.Point(127, 12);
            this.cbbTenServer.Name = "cbbTenServer";
            this.cbbTenServer.Size = new System.Drawing.Size(262, 30);
            this.cbbTenServer.TabIndex = 2;
            this.cbbTenServer.UseSelectable = true;
            // 
            // chkXacThuc
            // 
            this.chkXacThuc.AutoSize = true;
            this.chkXacThuc.Location = new System.Drawing.Point(127, 48);
            this.chkXacThuc.Name = "chkXacThuc";
            this.chkXacThuc.Size = new System.Drawing.Size(131, 17);
            this.chkXacThuc.TabIndex = 3;
            this.chkXacThuc.Text = "Xác thực Windows";
            this.chkXacThuc.UseSelectable = true;
            this.chkXacThuc.CheckedChanged += new System.EventHandler(this.chkXacThuc_CheckedChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(35, 120);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 20);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Mật Khẩu";
            // 
            // txtDangNhap
            // 
            // 
            // 
            // 
            this.txtDangNhap.CustomButton.Image = null;
            this.txtDangNhap.CustomButton.Location = new System.Drawing.Point(328, 1);
            this.txtDangNhap.CustomButton.Name = "";
            this.txtDangNhap.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDangNhap.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDangNhap.CustomButton.TabIndex = 1;
            this.txtDangNhap.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDangNhap.CustomButton.UseSelectable = true;
            this.txtDangNhap.CustomButton.Visible = false;
            this.txtDangNhap.Lines = new string[0];
            this.txtDangNhap.Location = new System.Drawing.Point(127, 78);
            this.txtDangNhap.MaxLength = 32767;
            this.txtDangNhap.Name = "txtDangNhap";
            this.txtDangNhap.PasswordChar = '\0';
            this.txtDangNhap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDangNhap.SelectedText = "";
            this.txtDangNhap.SelectionLength = 0;
            this.txtDangNhap.SelectionStart = 0;
            this.txtDangNhap.ShortcutsEnabled = true;
            this.txtDangNhap.Size = new System.Drawing.Size(350, 23);
            this.txtDangNhap.TabIndex = 5;
            this.txtDangNhap.UseSelectable = true;
            this.txtDangNhap.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDangNhap.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMatKhau
            // 
            // 
            // 
            // 
            this.txtMatKhau.CustomButton.Image = null;
            this.txtMatKhau.CustomButton.Location = new System.Drawing.Point(328, 1);
            this.txtMatKhau.CustomButton.Name = "";
            this.txtMatKhau.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMatKhau.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMatKhau.CustomButton.TabIndex = 1;
            this.txtMatKhau.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMatKhau.CustomButton.UseSelectable = true;
            this.txtMatKhau.CustomButton.Visible = false;
            this.txtMatKhau.Lines = new string[0];
            this.txtMatKhau.Location = new System.Drawing.Point(127, 120);
            this.txtMatKhau.MaxLength = 32767;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '●';
            this.txtMatKhau.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.SelectionLength = 0;
            this.txtMatKhau.SelectionStart = 0;
            this.txtMatKhau.ShortcutsEnabled = true;
            this.txtMatKhau.Size = new System.Drawing.Size(350, 23);
            this.txtMatKhau.TabIndex = 6;
            this.txtMatKhau.UseSelectable = true;
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMatKhau.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.Location = new System.Drawing.Point(127, 155);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(157, 37);
            this.btnKetNoi.TabIndex = 7;
            this.btnKetNoi.Text = "Kết Nối";
            this.btnKetNoi.UseSelectable = true;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(335, 155);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(142, 37);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseSelectable = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(395, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(69, 36);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmConnect
            // 
            this.AcceptButton = this.btnKetNoi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 212);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnKetNoi);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtDangNhap);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.chkXacThuc);
            this.Controls.Add(this.cbbTenServer);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConnect";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.frmConnect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbbTenServer;
        private MetroFramework.Controls.MetroCheckBox chkXacThuc;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtDangNhap;
        private MetroFramework.Controls.MetroTextBox txtMatKhau;
        private MetroFramework.Controls.MetroButton btnKetNoi;
        private MetroFramework.Controls.MetroButton btnThoat;
        private MetroFramework.Controls.MetroButton btnLoad;
    }
}

