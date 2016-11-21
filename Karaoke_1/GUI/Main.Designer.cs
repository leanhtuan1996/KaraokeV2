namespace Karaoke_1.GUI
{
    partial class Main
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
            this.lstPhong = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPhong
            // 
            this.lstPhong.Controls.Add(this.panel2);
            this.lstPhong.Location = new System.Drawing.Point(263, 12);
            this.lstPhong.Name = "lstPhong";
            this.lstPhong.Size = new System.Drawing.Size(633, 487);
            this.lstPhong.TabIndex = 8;
            this.lstPhong.TabStop = false;
            this.lstPhong.Text = "Danh sách phòng";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 468);
            this.panel2.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 566);
            this.Controls.Add(this.lstPhong);
            this.Name = "Main";
            this.Text = "Main";
            this.lstPhong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox lstPhong;
        private System.Windows.Forms.Panel panel2;
    }
}