namespace Tool
{
    partial class ToolForm
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
            this.LocalPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RemoteAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RemotePort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.connNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.conn1Port = new System.Windows.Forms.TextBox();
            this.bListen = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.latencyBar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.tLatency = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveLog = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tPacketLossBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.tPacketLoss = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.conn2Port = new System.Windows.Forms.TextBox();
            this.bListen2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latencyBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tPacketLossBar)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            this.connNumber,
            this.Data,
            this.Time});
            this.listviewLog.FullRowSelect = true;
            this.listviewLog.HideSelection = false;
            this.listviewLog.Location = new System.Drawing.Point(12, 158);
            this.listviewLog.Name = "listviewLog";
            this.listviewLog.ShowGroups = false;
            this.listviewLog.Size = new System.Drawing.Size(982, 164);
            this.listviewLog.TabIndex = 20;
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
            // connNumber
            // 
            this.connNumber.Text = "Connection Number";
            this.connNumber.Width = 110;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 440;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 120;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.conn1Port);
            this.panel3.Controls.Add(this.bListen);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(12, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(134, 145);
            this.panel3.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Listening Port:";
            // 
            // conn1Port
            // 
            this.conn1Port.Location = new System.Drawing.Point(6, 111);
            this.conn1Port.Name = "conn1Port";
            this.conn1Port.Size = new System.Drawing.Size(100, 20);
            this.conn1Port.TabIndex = 18;
            this.conn1Port.Text = "25565";
            // 
            // bListen
            // 
            this.bListen.BackColor = System.Drawing.Color.Red;
            this.bListen.Location = new System.Drawing.Point(6, 19);
            this.bListen.Name = "bListen";
            this.bListen.Size = new System.Drawing.Size(125, 23);
            this.bListen.TabIndex = 17;
            this.bListen.Text = "Listen";
            this.bListen.UseVisualStyleBackColor = false;
            this.bListen.Click += new System.EventHandler(this.bListen_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Connection 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Options:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.latencyBar);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tLatency);
            this.panel2.Location = new System.Drawing.Point(95, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 62);
            this.panel2.TabIndex = 23;
            // 
            // latencyBar
            // 
            this.latencyBar.LargeChange = 500;
            this.latencyBar.Location = new System.Drawing.Point(98, 7);
            this.latencyBar.Maximum = 5000;
            this.latencyBar.Name = "latencyBar";
            this.latencyBar.Size = new System.Drawing.Size(526, 45);
            this.latencyBar.SmallChange = 100;
            this.latencyBar.TabIndex = 16;
            this.latencyBar.TickFrequency = 100;
            this.latencyBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.latencyBar.ValueChanged += new System.EventHandler(this.LatencyTabStop);
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
            this.tLatency.Size = new System.Drawing.Size(86, 20);
            this.tLatency.TabIndex = 15;
            this.tLatency.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveLog);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(155, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 145);
            this.panel1.TabIndex = 25;
            // 
            // saveLog
            // 
            this.saveLog.Location = new System.Drawing.Point(6, 88);
            this.saveLog.Name = "saveLog";
            this.saveLog.Size = new System.Drawing.Size(83, 50);
            this.saveLog.TabIndex = 25;
            this.saveLog.Text = "Save Log to File";
            this.saveLog.UseVisualStyleBackColor = true;
            this.saveLog.Click += new System.EventHandler(this.saveLog_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tPacketLossBar);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.tPacketLoss);
            this.panel5.Location = new System.Drawing.Point(95, 72);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(607, 62);
            this.panel5.TabIndex = 24;
            // 
            // tPacketLossBar
            // 
            this.tPacketLossBar.LargeChange = 10;
            this.tPacketLossBar.Location = new System.Drawing.Point(98, 7);
            this.tPacketLossBar.Maximum = 100;
            this.tPacketLossBar.Name = "tPacketLossBar";
            this.tPacketLossBar.Size = new System.Drawing.Size(526, 45);
            this.tPacketLossBar.TabIndex = 16;
            this.tPacketLossBar.TickFrequency = 100;
            this.tPacketLossBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tPacketLossBar.ValueChanged += new System.EventHandler(this.PacketLossTabStop);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Packet Loss (%): ";
            // 
            // tPacketLoss
            // 
            this.tPacketLoss.Location = new System.Drawing.Point(6, 32);
            this.tPacketLoss.Name = "tPacketLoss";
            this.tPacketLoss.Size = new System.Drawing.Size(86, 20);
            this.tPacketLoss.TabIndex = 15;
            this.tPacketLoss.Text = "0";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.conn2Port);
            this.panel4.Controls.Add(this.bListen2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(866, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(134, 145);
            this.panel4.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Listening Port:";
            // 
            // conn2Port
            // 
            this.conn2Port.Location = new System.Drawing.Point(6, 111);
            this.conn2Port.Name = "conn2Port";
            this.conn2Port.Size = new System.Drawing.Size(100, 20);
            this.conn2Port.TabIndex = 18;
            this.conn2Port.Text = "25566";
            // 
            // bListen2
            // 
            this.bListen2.BackColor = System.Drawing.Color.Red;
            this.bListen2.Location = new System.Drawing.Point(6, 19);
            this.bListen2.Name = "bListen2";
            this.bListen2.Size = new System.Drawing.Size(125, 23);
            this.bListen2.TabIndex = 17;
            this.bListen2.Text = "Listen";
            this.bListen2.UseVisualStyleBackColor = false;
            this.bListen2.Click += new System.EventHandler(this.conn2button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Connection 2";
            // 
            // ToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 334);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.listviewLog);
            this.Name = "ToolForm";
            this.Text = "Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToolForm_FormClosing);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latencyBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tPacketLossBar)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listviewLog;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader LocalPort;
        private System.Windows.Forms.ColumnHeader RemoteAddress;
        private System.Windows.Forms.ColumnHeader RemotePort;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar latencyBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bListen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox conn1Port;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox conn2Port;
        private System.Windows.Forms.Button bListen2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader connNumber;
        public System.Windows.Forms.TextBox tLatency;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TrackBar tPacketLossBar;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tPacketLoss;
        private System.Windows.Forms.Button saveLog;
    }
}

