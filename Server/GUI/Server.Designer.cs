namespace Server.GUI
{
    partial class Server
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstClientConnected = new System.Windows.Forms.CheckedListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTongSoClient = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtPortnumber = new MetroFramework.Controls.MetroTextBox();
            this.txtIPserver = new MetroFramework.Controls.MetroTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstClientConnected);
            this.groupBox1.Location = new System.Drawing.Point(32, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 209);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Client đang kết nối";
            // 
            // lstClientConnected
            // 
            this.lstClientConnected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstClientConnected.FormattingEnabled = true;
            this.lstClientConnected.Location = new System.Drawing.Point(3, 16);
            this.lstClientConnected.Name = "lstClientConnected";
            this.lstClientConnected.Size = new System.Drawing.Size(385, 190);
            this.lstClientConnected.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTongSoClient});
            this.statusStrip1.Location = new System.Drawing.Point(20, 322);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(418, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTongSoClient
            // 
            this.lblTongSoClient.Name = "lblTongSoClient";
            this.lblTongSoClient.Size = new System.Drawing.Size(118, 17);
            this.lblTongSoClient.Text = "toolStripStatusLabel1";
            // 
            // txtPortnumber
            // 
            // 
            // 
            // 
            this.txtPortnumber.CustomButton.Image = null;
            this.txtPortnumber.CustomButton.Location = new System.Drawing.Point(46, 1);
            this.txtPortnumber.CustomButton.Name = "";
            this.txtPortnumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPortnumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPortnumber.CustomButton.TabIndex = 1;
            this.txtPortnumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPortnumber.CustomButton.UseSelectable = true;
            this.txtPortnumber.CustomButton.Visible = false;
            this.txtPortnumber.Lines = new string[0];
            this.txtPortnumber.Location = new System.Drawing.Point(339, 72);
            this.txtPortnumber.MaxLength = 32767;
            this.txtPortnumber.Name = "txtPortnumber";
            this.txtPortnumber.PasswordChar = '\0';
            this.txtPortnumber.ReadOnly = true;
            this.txtPortnumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPortnumber.SelectedText = "";
            this.txtPortnumber.SelectionLength = 0;
            this.txtPortnumber.SelectionStart = 0;
            this.txtPortnumber.ShortcutsEnabled = true;
            this.txtPortnumber.Size = new System.Drawing.Size(84, 23);
            this.txtPortnumber.TabIndex = 25;
            this.txtPortnumber.UseSelectable = true;
            this.txtPortnumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPortnumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPortnumber.Click += new System.EventHandler(this.txtPortnumber_Click);
            // 
            // txtIPserver
            // 
            // 
            // 
            // 
            this.txtIPserver.CustomButton.Image = null;
            this.txtIPserver.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txtIPserver.CustomButton.Name = "";
            this.txtIPserver.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIPserver.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIPserver.CustomButton.TabIndex = 1;
            this.txtIPserver.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIPserver.CustomButton.UseSelectable = true;
            this.txtIPserver.CustomButton.Visible = false;
            this.txtIPserver.Lines = new string[0];
            this.txtIPserver.Location = new System.Drawing.Point(106, 72);
            this.txtIPserver.MaxLength = 32767;
            this.txtIPserver.Name = "txtIPserver";
            this.txtIPserver.PasswordChar = '\0';
            this.txtIPserver.ReadOnly = true;
            this.txtIPserver.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIPserver.SelectedText = "";
            this.txtIPserver.SelectionLength = 0;
            this.txtIPserver.SelectionStart = 0;
            this.txtIPserver.ShortcutsEnabled = true;
            this.txtIPserver.Size = new System.Drawing.Size(175, 23);
            this.txtIPserver.TabIndex = 26;
            this.txtIPserver.UseSelectable = true;
            this.txtIPserver.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIPserver.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(38, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 27;
            this.metroLabel1.Text = "IP Server";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(287, 72);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(34, 19);
            this.metroLabel2.TabIndex = 27;
            this.metroLabel2.Text = "Port";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 364);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtPortnumber);
            this.Controls.Add(this.txtIPserver);
            this.Name = "Server";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Server";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Server_Load);
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox lstClientConnected;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTongSoClient;
        private MetroFramework.Controls.MetroTextBox txtPortnumber;
        private MetroFramework.Controls.MetroTextBox txtIPserver;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}