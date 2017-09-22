using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool
{
    public partial class ToolForm : Form
    {
        Logger logger;
        public tConnection conn1;
        public tConnection conn2;

        public ToolForm()
        {
            InitializeComponent();

            //Pass in the parent form into the logger / connection so it can access the log object
            conn1 = new tConnection(this,1);
            conn2 = new tConnection(this,2);
            logger = new Logger(this);

            //give each conn access to the other
            conn1.setOtherConn(conn2);
            conn2.setOtherConn(conn1);

            //DEBUG - Show local IP in window title.
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
                if (ip.AddressFamily == AddressFamily.InterNetwork)                
                    this.Text = "Local IP Address: " + ip.ToString();   
        }

        public void OutputToLog(string type, string localPort, string remoteAddress, string remotePort, string data, string connectionNumber)
        {
            //Stuff to output to the log object
            string[] row = { type, localPort.ToString(), remoteAddress, remotePort.ToString(), connectionNumber, data, DateTime.UtcNow.ToString() };

            //Output the log data to the logger
            string output = "";
            foreach (string s in row) output += s + ',';

            logger.appendLogFile(output);

            //Put the items in the log object
            var item = new ListViewItem(row);
            listviewLog.Items.Add(item);
            listviewLog.Items[listviewLog.Items.Count - 1].EnsureVisible();
        }

        public void outputToLog(string type, string data)
        {
            OutputToLog(type, "", "", "", data, "");
        }

        private void bListen_Click(object sender, EventArgs e)
        {
            bListen.Text = bListen.Text == "Listen" ? "Stop Listening" : "Listen";
            bListen.BackColor = bListen.BackColor == Color.Green ? Color.Red : Color.Green;
            if (bListen.BackColor == Color.Green)
            {
                bool portIsValid = isPortValid(conn1Port.Text);
                if (portIsValid == true)
                {
                    int portValue;
                    bool resPort = Int32.TryParse(conn1Port.Text, out portValue);
                    conn1.startListener(portValue);
                }
            }
            else
            {
                conn1.sendData("0xxToolStopListening");
                conn1.closeServer();
            }
        }
        
        private void conn2button_Click(object sender, EventArgs e)
        {
            bListen2.Text = bListen2.Text == "Listen" ? "Stop Listening" : "Listen";
            bListen2.BackColor = bListen2.BackColor == Color.Green ? Color.Red : Color.Green;
            if(bListen2.BackColor == Color.Green)
            {
                bool portIsValid = isPortValid(conn2Port.Text);
                if (portIsValid == true)
                {
                    int portValue;
                    bool resPort = Int32.TryParse(conn2Port.Text, out portValue);
                    conn2.startListener(portValue);
                }
            }            
            else
            {
                conn2.sendData("0xxToolStopListening");
                conn2.closeServer();
            }
        }

        bool isPortValid(string p)
        {
            int port;

            //try to parse the port, if successful return the port number, else return 0
            bool resPort = Int32.TryParse(p, out port);
            if (resPort == false)
            {
                string data = "Please enter a valid port number";
                outputToLog("LOG:", data);
                return false;
            }
            return true;
        }

        private void LatencyTabStop(object sender, EventArgs e)
        {
            tLatency.Text = latencyBar.Value.ToString();
        }

        private void ToolForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn1.client.Client.Connected)
            {
                conn1.closeServer();
            }
            if (conn2.client.Client.Connected)
            {
                conn2.closeServer();
            }
        }

        private void PacketLossTabStop(object sender, EventArgs e)
        {
            tPacketLoss.Text = tPacketLossBar.Value.ToString();
        }

        private void saveLog_Click(object sender, EventArgs e)
        {
            logger.logToFile();
        }
    }
}
