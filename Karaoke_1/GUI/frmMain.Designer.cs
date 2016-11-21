namespace Karaoke_1.GUI
{
    partial class frmMain
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
            this.btnQuanLyNhanVien = new MetroFramework.Controls.MetroButton();
            this.btnQuanLyPhong = new MetroFramework.Controls.MetroButton();
            this.btnMainRoom = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(50, 72);
            this.btnQuanLyNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(154, 104);
            this.btnQuanLyNhanVien.TabIndex = 0;
            this.btnQuanLyNhanVien.Text = "Quản lý nhân viên";
            this.btnQuanLyNhanVien.UseSelectable = true;
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.btnQuanLyNhanVien_Click);
            // 
            // btnQuanLyPhong
            // 
            this.btnQuanLyPhong.Location = new System.Drawing.Point(358, 72);
            this.btnQuanLyPhong.Name = "btnQuanLyPhong";
            this.btnQuanLyPhong.Size = new System.Drawing.Size(184, 116);
            this.btnQuanLyPhong.TabIndex = 1;
            this.btnQuanLyPhong.Text = "Quản lý phòng";
            this.btnQuanLyPhong.UseSelectable = true;
            this.btnQuanLyPhong.Click += new System.EventHandler(this.btnQuanLyPhong_Click);
            // 
            // btnMainRoom
            // 
            this.btnMainRoom.Location = new System.Drawing.Point(263, 254);
            this.btnMainRoom.Name = "btnMainRoom";
            this.btnMainRoom.Size = new System.Drawing.Size(261, 86);
            this.btnMainRoom.TabIndex = 2;
            this.btnMainRoom.Text = "Main Room";
            this.btnMainRoom.UseSelectable = true;
            this.btnMainRoom.Click += new System.EventHandler(this.btnMainRoom_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 411);
            this.Controls.Add(this.btnMainRoom);
            this.Controls.Add(this.btnQuanLyPhong);
            this.Controls.Add(this.btnQuanLyNhanVien);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnQuanLyNhanVien;
        private MetroFramework.Controls.MetroButton btnQuanLyPhong;
        private MetroFramework.Controls.MetroButton btnMainRoom;
    }
}