namespace Karaoke_1.GUI
{
    partial class ChuyenPhong
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
            this.txtPhongHienTai_ChuyenPhong = new MetroFramework.Controls.MetroTextBox();
            this.cmbPhongMuonChuyen_ChuyenPhong = new MetroFramework.Controls.MetroComboBox();
            this.btnHuy_ChuyenPhong = new MetroFramework.Controls.MetroButton();
            this.btnChuyen_ChuyenPhong = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(37, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Phòng hiện tại";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 126);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(129, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Phòng muốn chuyển";
            // 
            // txtPhongHienTai_ChuyenPhong
            // 
            // 
            // 
            // 
            this.txtPhongHienTai_ChuyenPhong.CustomButton.Image = null;
            this.txtPhongHienTai_ChuyenPhong.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txtPhongHienTai_ChuyenPhong.CustomButton.Name = "";
            this.txtPhongHienTai_ChuyenPhong.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPhongHienTai_ChuyenPhong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhongHienTai_ChuyenPhong.CustomButton.TabIndex = 1;
            this.txtPhongHienTai_ChuyenPhong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhongHienTai_ChuyenPhong.CustomButton.UseSelectable = true;
            this.txtPhongHienTai_ChuyenPhong.CustomButton.Visible = false;
            this.txtPhongHienTai_ChuyenPhong.Enabled = false;
            this.txtPhongHienTai_ChuyenPhong.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPhongHienTai_ChuyenPhong.Lines = new string[0];
            this.txtPhongHienTai_ChuyenPhong.Location = new System.Drawing.Point(181, 79);
            this.txtPhongHienTai_ChuyenPhong.MaxLength = 32767;
            this.txtPhongHienTai_ChuyenPhong.Name = "txtPhongHienTai_ChuyenPhong";
            this.txtPhongHienTai_ChuyenPhong.PasswordChar = '\0';
            this.txtPhongHienTai_ChuyenPhong.ReadOnly = true;
            this.txtPhongHienTai_ChuyenPhong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhongHienTai_ChuyenPhong.SelectedText = "";
            this.txtPhongHienTai_ChuyenPhong.SelectionLength = 0;
            this.txtPhongHienTai_ChuyenPhong.SelectionStart = 0;
            this.txtPhongHienTai_ChuyenPhong.ShortcutsEnabled = true;
            this.txtPhongHienTai_ChuyenPhong.Size = new System.Drawing.Size(154, 29);
            this.txtPhongHienTai_ChuyenPhong.TabIndex = 1;
            this.txtPhongHienTai_ChuyenPhong.UseSelectable = true;
            this.txtPhongHienTai_ChuyenPhong.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhongHienTai_ChuyenPhong.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbPhongMuonChuyen_ChuyenPhong
            // 
            this.cmbPhongMuonChuyen_ChuyenPhong.FormattingEnabled = true;
            this.cmbPhongMuonChuyen_ChuyenPhong.ItemHeight = 23;
            this.cmbPhongMuonChuyen_ChuyenPhong.Location = new System.Drawing.Point(181, 119);
            this.cmbPhongMuonChuyen_ChuyenPhong.Name = "cmbPhongMuonChuyen_ChuyenPhong";
            this.cmbPhongMuonChuyen_ChuyenPhong.Size = new System.Drawing.Size(154, 29);
            this.cmbPhongMuonChuyen_ChuyenPhong.TabIndex = 2;
            this.cmbPhongMuonChuyen_ChuyenPhong.UseSelectable = true;
            // 
            // btnHuy_ChuyenPhong
            // 
            this.btnHuy_ChuyenPhong.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnHuy_ChuyenPhong.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnHuy_ChuyenPhong.Location = new System.Drawing.Point(231, 173);
            this.btnHuy_ChuyenPhong.Name = "btnHuy_ChuyenPhong";
            this.btnHuy_ChuyenPhong.Size = new System.Drawing.Size(93, 30);
            this.btnHuy_ChuyenPhong.TabIndex = 3;
            this.btnHuy_ChuyenPhong.Text = "Hủy bỏ";
            this.btnHuy_ChuyenPhong.UseCustomBackColor = true;
            this.btnHuy_ChuyenPhong.UseCustomForeColor = true;
            this.btnHuy_ChuyenPhong.UseSelectable = true;
            this.btnHuy_ChuyenPhong.Click += new System.EventHandler(this.btnHuy_ChuyenPhong_Click);
            // 
            // btnChuyen_ChuyenPhong
            // 
            this.btnChuyen_ChuyenPhong.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnChuyen_ChuyenPhong.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnChuyen_ChuyenPhong.Location = new System.Drawing.Point(59, 173);
            this.btnChuyen_ChuyenPhong.Name = "btnChuyen_ChuyenPhong";
            this.btnChuyen_ChuyenPhong.Size = new System.Drawing.Size(93, 30);
            this.btnChuyen_ChuyenPhong.TabIndex = 3;
            this.btnChuyen_ChuyenPhong.Text = "Chuyển phòng";
            this.btnChuyen_ChuyenPhong.UseCustomBackColor = true;
            this.btnChuyen_ChuyenPhong.UseCustomForeColor = true;
            this.btnChuyen_ChuyenPhong.UseSelectable = true;
            this.btnChuyen_ChuyenPhong.Click += new System.EventHandler(this.btnChuyen_ChuyenPhong_Click);
            // 
            // ChuyenPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 226);
            this.ControlBox = false;
            this.Controls.Add(this.btnChuyen_ChuyenPhong);
            this.Controls.Add(this.btnHuy_ChuyenPhong);
            this.Controls.Add(this.cmbPhongMuonChuyen_ChuyenPhong);
            this.Controls.Add(this.txtPhongHienTai_ChuyenPhong);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximumSize = new System.Drawing.Size(429, 226);
            this.Name = "ChuyenPhong";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Chuyển Phòng";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.ChuyenPhong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPhongHienTai_ChuyenPhong;
        private MetroFramework.Controls.MetroComboBox cmbPhongMuonChuyen_ChuyenPhong;
        private MetroFramework.Controls.MetroButton btnHuy_ChuyenPhong;
        private MetroFramework.Controls.MetroButton btnChuyen_ChuyenPhong;
    }
}