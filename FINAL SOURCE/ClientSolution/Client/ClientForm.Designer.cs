namespace Client
{
    partial class ClientForm
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
            this.listviewLog = new System.Windows.Forms.ListView();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Remote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bSaveToFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stopListeningBtn = new System.Windows.Forms.Button();
            this.listenBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listenerPortTxt = new System.Windows.Forms.TextBox();
            this.debugBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.tAddressP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tAddress1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bConnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tAddress2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tAddress3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tAddress4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listviewLog
            // 
            this.listviewLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.LPort,
            this.Remote,
            this.RPort,
            this.Data,
            this.Time});
            this.listviewLog.FullRowSelect = true;
            this.listviewLog.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listviewLog.HideSelection = false;
            this.listviewLog.Location = new System.Drawing.Point(12, 164);
            this.listviewLog.Name = "listviewLog";
            this.listviewLog.ShowGroups = false;
            this.listviewLog.Size = new System.Drawing.Size(986, 164);
            this.listviewLog.TabIndex = 17;
            this.listviewLog.UseCompatibleStateImageBehavior = false;
            this.listviewLog.View = System.Windows.Forms.View.Details;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 80;
            // 
            // LPort
            // 
            this.LPort.Text = "Local Port";
            // 
            // Remote
            // 
            this.Remote.Text = "Remote Address";
            this.Remote.Width = 94;
            // 
            // RPort
            // 
            this.RPort.Text = "Remote Port";
            this.RPort.Width = 74;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 500;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 120;
            // 
            // bSaveToFile
            // 
            this.bSaveToFile.Location = new System.Drawing.Point(437, 41);
            this.bSaveToFile.Name = "bSaveToFile";
            this.bSaveToFile.Size = new System.Drawing.Size(75, 20);
            this.bSaveToFile.TabIndex = 18;
            this.bSaveToFile.Text = "Save to File";
            this.bSaveToFile.UseVisualStyleBackColor = true;
            this.bSaveToFile.Click += new System.EventHandler(this.bSaveToFile_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stopListeningBtn);
            this.panel1.Controls.Add(this.listenBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listenerPortTxt);
            this.panel1.Controls.Add(this.debugBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.disconnectBtn);
            this.panel1.Controls.Add(this.tAddressP);
            this.panel1.Controls.Add(this.bSaveToFile);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tAddress1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bConnect);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tAddress2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tAddress3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tAddress4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 146);
            this.panel1.TabIndex = 19;
            // 
            // stopListeningBtn
            // 
            this.stopListeningBtn.Location = new System.Drawing.Point(275, 107);
            this.stopListeningBtn.Name = "stopListeningBtn";
            this.stopListeningBtn.Size = new System.Drawing.Size(118, 36);
            this.stopListeningBtn.TabIndex = 28;
            this.stopListeningBtn.Text = "Stop Listening";
            this.stopListeningBtn.UseVisualStyleBackColor = true;
            this.stopListeningBtn.Click += new System.EventHandler(this.stopListeningBtn_Click);
            // 
            // listenBtn
            // 
            this.listenBtn.Location = new System.Drawing.Point(275, 70);
            this.listenBtn.Name = "listenBtn";
            this.listenBtn.Size = new System.Drawing.Size(118, 36);
            this.listenBtn.TabIndex = 27;
            this.listenBtn.Text = "Start Listening";
            this.listenBtn.UseVisualStyleBackColor = true;
            this.listenBtn.Click += new System.EventHandler(this.listenBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Listener Port:";
            // 
            // listenerPortTxt
            // 
            this.listenerPortTxt.Location = new System.Drawing.Point(203, 82);
            this.listenerPortTxt.Name = "listenerPortTxt";
            this.listenerPortTxt.Size = new System.Drawing.Size(66, 20);
            this.listenerPortTxt.TabIndex = 25;
            // 
            // debugBtn
            // 
            this.debugBtn.Location = new System.Drawing.Point(399, 70);
            this.debugBtn.Name = "debugBtn";
            this.debugBtn.Size = new System.Drawing.Size(113, 73);
            this.debugBtn.TabIndex = 24;
            this.debugBtn.Text = "Start Simulation!";
            this.debugBtn.UseVisualStyleBackColor = true;
            this.debugBtn.Click += new System.EventHandler(this.debugBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(614, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 160);
            this.panel2.TabIndex = 23;
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Enabled = false;
            this.disconnectBtn.Location = new System.Drawing.Point(356, 41);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(75, 20);
            this.disconnectBtn.TabIndex = 20;
            this.disconnectBtn.Text = "Disconnect";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
            // 
            // tAddressP
            // 
            this.tAddressP.Location = new System.Drawing.Point(203, 41);
            this.tAddressP.Name = "tAddressP";
            this.tAddressP.Size = new System.Drawing.Size(66, 20);
            this.tAddressP.TabIndex = 14;
            this.tAddressP.Text = "25565";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Port Number:";
            // 
            // tAddress1
            // 
            this.tAddress1.Location = new System.Drawing.Point(9, 41);
            this.tAddress1.Name = "tAddress1";
            this.tAddress1.Size = new System.Drawing.Size(37, 20);
            this.tAddress1.TabIndex = 10;
            this.tAddress1.Text = "127";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Address:";
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(275, 41);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(75, 20);
            this.bConnect.TabIndex = 16;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = ".";
            // 
            // tAddress2
            // 
            this.tAddress2.Location = new System.Drawing.Point(58, 41);
            this.tAddress2.Name = "tAddress2";
            this.tAddress2.Size = new System.Drawing.Size(37, 20);
            this.tAddress2.TabIndex = 11;
            this.tAddress2.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = ".";
            // 
            // tAddress3
            // 
            this.tAddress3.Location = new System.Drawing.Point(107, 41);
            this.tAddress3.Name = "tAddress3";
            this.tAddress3.Size = new System.Drawing.Size(37, 20);
            this.tAddress3.TabIndex = 12;
            this.tAddress3.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = ".";
            // 
            // tAddress4
            // 
            this.tAddress4.Location = new System.Drawing.Point(156, 41);
            this.tAddress4.Name = "tAddress4";
            this.tAddress4.Size = new System.Drawing.Size(37, 20);
            this.tAddress4.TabIndex = 13;
            this.tAddress4.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Connect:";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 334);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listviewLog);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listviewLog;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader LPort;
        private System.Windows.Forms.ColumnHeader Remote;
        private System.Windows.Forms.ColumnHeader RPort;
        private System.Windows.Forms.Button bSaveToFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tAddressP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tAddress1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tAddress2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tAddress3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tAddress4;
        public System.Windows.Forms.Button disconnectBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button debugBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox listenerPortTxt;
        private System.Windows.Forms.Button listenBtn;
        private System.Windows.Forms.Button stopListeningBtn;
    }
}

