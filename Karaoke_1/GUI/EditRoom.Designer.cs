namespace Karaoke_1.GUI
{
    partial class EditRoom
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
            this.succhua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trangthai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loaiphong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnsuaphong = new System.Windows.Forms.Button();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.btnxoaphong = new System.Windows.Forms.Button();
            this.txttenphong = new System.Windows.Forms.TextBox();
            this.txtloaiphong = new System.Windows.Forms.TextBox();
            this.txttrangthai = new System.Windows.Forms.TextBox();
            this.txtsucchua = new System.Windows.Forms.TextBox();
            this.txtsoluongthem = new System.Windows.Forms.TextBox();
            this.txttang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // succhua
            // 
            this.succhua.Text = "Sức chứa";
            this.succhua.Width = 311;
            // 
            // trangthai
            // 
            this.trangthai.Text = "Trạng Thái";
            this.trangthai.Width = 111;
            // 
            // loaiphong
            // 
            this.loaiphong.Text = "Loại Phòng";
            this.loaiphong.Width = 93;
            // 
            // name
            // 
            this.name.Text = "Tên Phòng";
            this.name.Width = 94;
            // 
            // stt
            // 
            this.stt.Text = "Số thứ tự";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stt,
            this.name,
            this.loaiphong,
            this.trangthai,
            this.succhua});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 206);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(440, 134);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnsuaphong
            // 
            this.btnsuaphong.Location = new System.Drawing.Point(139, 145);
            this.btnsuaphong.Name = "btnsuaphong";
            this.btnsuaphong.Size = new System.Drawing.Size(75, 23);
            this.btnsuaphong.TabIndex = 7;
            this.btnsuaphong.Text = "Sửa phòng";
            this.btnsuaphong.UseVisualStyleBackColor = true;
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(29, 145);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(75, 23);
            this.btnThemPhong.TabIndex = 6;
            this.btnThemPhong.Text = "Thêm phòng";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            // 
            // btnxoaphong
            // 
            this.btnxoaphong.Location = new System.Drawing.Point(251, 145);
            this.btnxoaphong.Name = "btnxoaphong";
            this.btnxoaphong.Size = new System.Drawing.Size(75, 23);
            this.btnxoaphong.TabIndex = 5;
            this.btnxoaphong.Text = "Xóa phòng";
            this.btnxoaphong.UseVisualStyleBackColor = true;
            // 
            // txttenphong
            // 
            this.txttenphong.Location = new System.Drawing.Point(114, 10);
            this.txttenphong.Name = "txttenphong";
            this.txttenphong.Size = new System.Drawing.Size(100, 20);
            this.txttenphong.TabIndex = 13;
            // 
            // txtloaiphong
            // 
            this.txtloaiphong.Location = new System.Drawing.Point(301, 6);
            this.txtloaiphong.Name = "txtloaiphong";
            this.txtloaiphong.Size = new System.Drawing.Size(100, 20);
            this.txtloaiphong.TabIndex = 12;
            // 
            // txttrangthai
            // 
            this.txttrangthai.Location = new System.Drawing.Point(114, 55);
            this.txttrangthai.Name = "txttrangthai";
            this.txttrangthai.Size = new System.Drawing.Size(100, 20);
            this.txttrangthai.TabIndex = 11;
            // 
            // txtsucchua
            // 
            this.txtsucchua.Location = new System.Drawing.Point(301, 55);
            this.txtsucchua.Name = "txtsucchua";
            this.txtsucchua.Size = new System.Drawing.Size(100, 20);
            this.txtsucchua.TabIndex = 10;
            // 
            // txtsoluongthem
            // 
            this.txtsoluongthem.Location = new System.Drawing.Point(114, 98);
            this.txtsoluongthem.Name = "txtsoluongthem";
            this.txtsoluongthem.Size = new System.Drawing.Size(100, 20);
            this.txtsoluongthem.TabIndex = 9;
            // 
            // txttang
            // 
            this.txttang.Location = new System.Drawing.Point(301, 98);
            this.txttang.Name = "txttang";
            this.txttang.Size = new System.Drawing.Size(100, 20);
            this.txttang.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tên phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Trạng thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Số lượng thêm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Thuộc tầng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sức chứa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Loại phòng";
            // 
            // EditRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 340);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttang);
            this.Controls.Add(this.txtsoluongthem);
            this.Controls.Add(this.txtsucchua);
            this.Controls.Add(this.txttrangthai);
            this.Controls.Add(this.txtloaiphong);
            this.Controls.Add(this.txttenphong);
            this.Controls.Add(this.btnxoaphong);
            this.Controls.Add(this.btnThemPhong);
            this.Controls.Add(this.btnsuaphong);
            this.Controls.Add(this.listView1);
            this.Name = "EditRoom";
            this.Text = "EditRoom";
            this.Load += new System.EventHandler(this.EditRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader succhua;
        private System.Windows.Forms.ColumnHeader trangthai;
        private System.Windows.Forms.ColumnHeader loaiphong;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader stt;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnsuaphong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Button btnxoaphong;
        private System.Windows.Forms.TextBox txttenphong;
        private System.Windows.Forms.TextBox txtloaiphong;
        private System.Windows.Forms.TextBox txttrangthai;
        private System.Windows.Forms.TextBox txtsucchua;
        private System.Windows.Forms.TextBox txtsoluongthem;
        private System.Windows.Forms.TextBox txttang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}