namespace Karaoke_1.GUI
{
    partial class frmPhuThu
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
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lsvPhuThu = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ngay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhanTramPhuThu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LyDo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpNgay = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPhanTramPhuThu = new MetroFramework.Controls.MetroTextBox();
            this.txtLiDoPhuThu = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnThem = new System.Windows.Forms.Button();
            this.cmtPhuThu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmtPhuThu.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(126, 107);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Ngày phụ thu:";
            // 
            // lsvPhuThu
            // 
            this.lsvPhuThu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.Ngay,
            this.PhanTramPhuThu,
            this.LyDo});
            this.lsvPhuThu.FullRowSelect = true;
            this.lsvPhuThu.GridLines = true;
            this.lsvPhuThu.Location = new System.Drawing.Point(23, 289);
            this.lsvPhuThu.Name = "lsvPhuThu";
            this.lsvPhuThu.Size = new System.Drawing.Size(458, 172);
            this.lsvPhuThu.TabIndex = 1;
            this.lsvPhuThu.UseCompatibleStateImageBehavior = false;
            this.lsvPhuThu.View = System.Windows.Forms.View.Details;
            this.lsvPhuThu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsvPhuThu_MouseClick);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 50;
            // 
            // Ngay
            // 
            this.Ngay.Text = "Ngày phụ thu";
            this.Ngay.Width = 100;
            // 
            // PhanTramPhuThu
            // 
            this.PhanTramPhuThu.Text = "Phần trăm phụ thu";
            this.PhanTramPhuThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhanTramPhuThu.Width = 100;
            // 
            // LyDo
            // 
            this.LyDo.Text = "Lý do phụ thu";
            this.LyDo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LyDo.Width = 200;
            // 
            // dtpNgay
            // 
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(250, 97);
            this.dtpNgay.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(164, 29);
            this.dtpNgay.TabIndex = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(108, 140);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(121, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Phần trăm phụ thu:";
            // 
            // txtPhanTramPhuThu
            // 
            // 
            // 
            // 
            this.txtPhanTramPhuThu.CustomButton.Image = null;
            this.txtPhanTramPhuThu.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txtPhanTramPhuThu.CustomButton.Name = "";
            this.txtPhanTramPhuThu.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhanTramPhuThu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhanTramPhuThu.CustomButton.TabIndex = 1;
            this.txtPhanTramPhuThu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhanTramPhuThu.CustomButton.UseSelectable = true;
            this.txtPhanTramPhuThu.CustomButton.Visible = false;
            this.txtPhanTramPhuThu.Lines = new string[0];
            this.txtPhanTramPhuThu.Location = new System.Drawing.Point(250, 136);
            this.txtPhanTramPhuThu.MaxLength = 32767;
            this.txtPhanTramPhuThu.Name = "txtPhanTramPhuThu";
            this.txtPhanTramPhuThu.PasswordChar = '\0';
            this.txtPhanTramPhuThu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhanTramPhuThu.SelectedText = "";
            this.txtPhanTramPhuThu.SelectionLength = 0;
            this.txtPhanTramPhuThu.SelectionStart = 0;
            this.txtPhanTramPhuThu.ShortcutsEnabled = true;
            this.txtPhanTramPhuThu.Size = new System.Drawing.Size(164, 23);
            this.txtPhanTramPhuThu.TabIndex = 4;
            this.txtPhanTramPhuThu.UseSelectable = true;
            this.txtPhanTramPhuThu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhanTramPhuThu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhanTramPhuThu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhanTramPhuThu_KeyDown);
            this.txtPhanTramPhuThu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhanTramPhuThu_KeyPress);
            // 
            // txtLiDoPhuThu
            // 
            // 
            // 
            // 
            this.txtLiDoPhuThu.CustomButton.Image = null;
            this.txtLiDoPhuThu.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txtLiDoPhuThu.CustomButton.Name = "";
            this.txtLiDoPhuThu.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLiDoPhuThu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLiDoPhuThu.CustomButton.TabIndex = 1;
            this.txtLiDoPhuThu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLiDoPhuThu.CustomButton.UseSelectable = true;
            this.txtLiDoPhuThu.CustomButton.Visible = false;
            this.txtLiDoPhuThu.Lines = new string[0];
            this.txtLiDoPhuThu.Location = new System.Drawing.Point(250, 175);
            this.txtLiDoPhuThu.MaxLength = 32767;
            this.txtLiDoPhuThu.Name = "txtLiDoPhuThu";
            this.txtLiDoPhuThu.PasswordChar = '\0';
            this.txtLiDoPhuThu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLiDoPhuThu.SelectedText = "";
            this.txtLiDoPhuThu.SelectionLength = 0;
            this.txtLiDoPhuThu.SelectionStart = 0;
            this.txtLiDoPhuThu.ShortcutsEnabled = true;
            this.txtLiDoPhuThu.Size = new System.Drawing.Size(164, 23);
            this.txtLiDoPhuThu.TabIndex = 6;
            this.txtLiDoPhuThu.UseSelectable = true;
            this.txtLiDoPhuThu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLiDoPhuThu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(126, 179);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Lý do phụ thu:";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThem.Location = new System.Drawing.Point(23, 233);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(458, 46);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cmtPhuThu
            // 
            this.cmtPhuThu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem});
            this.cmtPhuThu.Name = "cmtPhuThu";
            this.cmtPhuThu.Size = new System.Drawing.Size(95, 26);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // frmPhuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 503);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtLiDoPhuThu);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtPhanTramPhuThu);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.lsvPhuThu);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPhuThu";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Quản lý phụ thu";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.PhuThu_Load);
            this.cmtPhuThu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ListView lsvPhuThu;
        private System.Windows.Forms.ColumnHeader Ngay;
        private System.Windows.Forms.ColumnHeader PhanTramPhuThu;
        private System.Windows.Forms.ColumnHeader LyDo;
        private System.Windows.Forms.ColumnHeader STT;
        private MetroFramework.Controls.MetroDateTime dtpNgay;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPhanTramPhuThu;
        private MetroFramework.Controls.MetroTextBox txtLiDoPhuThu;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Button btnThem;
        private MetroFramework.Controls.MetroContextMenu cmtPhuThu;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
    }
}