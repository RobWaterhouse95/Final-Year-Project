namespace Server
{
    partial class ServerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tAddress1 = new System.Windows.Forms.TextBox();
            this.tAddress2 = new System.Windows.Forms.TextBox();
            this.tAddress3 = new System.Windows.Forms.TextBox();
            this.tAddress4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.latencyBar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.tLatency = new System.Windows.Forms.TextBox();
            this.tAddressP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tInputMsg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bSendData = new System.Windows.Forms.Button();
            this.listviewLog = new System.Windows.Forms.ListView();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LocalPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RemoteAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RemotePort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latencyBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connect to:";
            // 
            // tAddress1
            // 
            this.tAddress1.Location = new System.Drawing.Point(5, 21);
            this.tAddress1.Name = "tAddress1";
            this.tAddress1.Size = new System.Drawing.Size(37, 20);
            this.tAddress1.TabIndex = 1;
            this.tAddress1.Text = "127";
            // 
            // tAddress2
            // 
            this.tAddress2.Location = new System.Drawing.Point(54, 21);
            this.tAddress2.Name = "tAddress2";
            this.tAddress2.Size = new System.Drawing.Size(37, 20);
            this.tAddress2.TabIndex = 2;
            this.tAddress2.Text = "0";
            // 
            // tAddress3
            // 
            this.tAddress3.Location = new System.Drawing.Point(103, 21);
            this.tAddress3.Name = "tAddress3";
            this.tAddress3.Size = new System.Drawing.Size(37, 20);
            this.tAddress3.TabIndex = 3;
            this.tAddress3.Text = "0";
            // 
            // tAddress4
            // 
            this.tAddress4.Location = new System.Drawing.Point(152, 21);
            this.tAddress4.Name = "tAddress4";
            this.tAddress4.Size = new System.Drawing.Size(37, 20);
            this.tAddress4.TabIndex = 4;
            this.tAddress4.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = ".";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tAddressP);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tInputMsg);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tAddress1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bSendData);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tAddress2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tAddress3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tAddress4);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 142);
            this.panel1.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Options:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.latencyBar);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tLatency);
            this.panel2.Location = new System.Drawing.Point(352, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 118);
            this.panel2.TabIndex = 16;
            // 
            // latencyBar
            // 
            this.latencyBar.LargeChange = 500;
            this.latencyBar.Location = new System.Drawing.Point(74, 7);
            this.latencyBar.Maximum = 10000;
            this.latencyBar.Name = "latencyBar";
            this.latencyBar.Size = new System.Drawing.Size(550, 45);
            this.latencyBar.SmallChange = 100;
            this.latencyBar.TabIndex = 16;
            this.latencyBar.TickFrequency = 100;
            this.latencyBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.latencyBar.Value = 1000;
            this.latencyBar.Scroll += new System.EventHandler(this.UpdateLatencyValue);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Latency (ms): ";
            // 
            // tLatency
            // 
            this.tLatency.Location = new System.Drawing.Point(6, 32);
            this.tLatency.Name = "tLatency";
            this.tLatency.Size = new System.Drawing.Size(62, 20);
            this.tLatency.TabIndex = 15;
            this.tLatency.Text = "1000";
            this.tLatency.TextChanged += new System.EventHandler(this.tLatency_TextChanged);
            // 
            // tAddressP
            // 
            this.tAddressP.Location = new System.Drawing.Point(199, 21);
            this.tAddressP.Name = "tAddressP";
            this.tAddressP.Size = new System.Drawing.Size(66, 20);
            this.tAddressP.TabIndex = 5;
            this.tAddressP.Text = "25565";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Message to send:";
            // 
            // tInputMsg
            // 
            this.tInputMsg.Location = new System.Drawing.Point(5, 67);
            this.tInputMsg.Multiline = true;
            this.tInputMsg.Name = "tInputMsg";
            this.tInputMsg.Size = new System.Drawing.Size(341, 72);
            this.tInputMsg.TabIndex = 13;
            this.tInputMsg.Text = "This is A test String\r\nThis is B test String\r\nThis is C test String\r\nThis is D te" +
    "st String\r\nThis is E test String";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Port Number:";
            // 
            // bSendData
            // 
            this.bSendData.Location = new System.Drawing.Point(271, 21);
            this.bSendData.Name = "bSendData";
            this.bSendData.Size = new System.Drawing.Size(75, 20);
            this.bSendData.TabIndex = 6;
            this.bSendData.Text = "Send Data";
            this.bSendData.UseVisualStyleBackColor = true;
            this.bSendData.Click += new System.EventHandler(this.bSendData_Click);
            // 
            // listviewLog
            // 
            this.listviewLog.AllowColumnReorder = true;
            this.listviewLog.AutoArrange = false;
            this.listviewLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.LocalPort,
            this.RemoteAddress,
            this.RemotePort,
            this.Data,
            this.Time});
            this.listviewLog.FullRowSelect = true;
            this.listviewLog.HideSelection = false;
            this.listviewLog.Location = new System.Drawing.Point(12, 149);
            this.listviewLog.Name = "listviewLog";
            this.listviewLog.ShowGroups = false;
            this.listviewLog.Size = new System.Drawing.Size(982, 164);
            this.listviewLog.TabIndex = 19;
            this.listviewLog.UseCompatibleStateImageBehavior = false;
            this.listviewLog.View = System.Windows.Forms.View.Details;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 80;
            // 
            // LocalPort
            // 
            this.LocalPort.Text = "Local Port";
            // 
            // RemoteAddress
            // 
            this.RemoteAddress.Text = "Remote Address";
            this.RemoteAddress.Width = 94;
            // 
            // RemotePort
            // 
            this.RemotePort.Text = "Remote Port";
            this.RemotePort.Width = 74;
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
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 323);
            this.Controls.Add(this.listviewLog);
            this.Controls.Add(this.panel1);
            this.Name = "ServerForm";
            this.Text = "Server";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latencyBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tAddress1;
        private System.Windows.Forms.TextBox tAddress2;
        private System.Windows.Forms.TextBox tAddress3;
        private System.Windows.Forms.TextBox tAddress4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bSendData;
        private System.Windows.Forms.TextBox tAddressP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tInputMsg;
        private System.Windows.Forms.ListView listviewLog;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader LocalPort;
        private System.Windows.Forms.ColumnHeader RemoteAddress;
        private System.Windows.Forms.ColumnHeader RemotePort;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tLatency;
        private System.Windows.Forms.TrackBar latencyBar;
    }
}

