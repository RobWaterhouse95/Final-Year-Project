using System;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Sockets;

namespace Server
{
    public partial class ServerForm : Form
    {
        TcpClient client = new TcpClient();
        sConnection conn;

        public ServerForm(){
            InitializeComponent();
            conn = new sConnection(this);
        }

        private void bSendData_Click(object sender, EventArgs e)
        {
            //Try to parse the IPAddress from the text boxes on the form
            IPAddress address;
            bool resHost = IPAddress.TryParse(tAddress1.Text + "." + tAddress2.Text + "." + tAddress3.Text + "." + tAddress4.Text, out address);
            if (resHost == false){
                outputToLog("Error:", "Unable to parse IP Address, Make sure it is a valid Address");
            }

            //Try to parse the port from the text box on the form
            int port;
            bool resPort = Int32.TryParse(tAddressP.Text, out port);
            if (resPort == false){
                outputToLog("Error:", "Unable to parse port number, Make sure it is a valid port number");
            }

            int latency;
            bool resLatency = Int32.TryParse(tLatency.Text, out latency);
            if(resLatency == false)
            {
                outputToLog("Error:", "Unable to parse latency value, Make sure it is a valid value (0-10,000)");
            }
            else
            {
                if(latency < 0 || latency > 10000)
                {
                    outputToLog("Error:", "Latency value is invalid, Make sure it is a valid value (0-10,000)");
                    resLatency = false;
                }
            }

            //If either of the values did not parse, do not run the SendData function. Output to the log showing error
            if(resHost == false || resPort == false || resLatency == false){
                return;
            }
            else{
                if (!client.Connected)
                {
                    conn.initialiseConnection(address, port, latency, tInputMsg.Lines);
                }
                else{
                    conn.sendData(address, port, latency, tInputMsg.Lines);
                }
                
            }            
        }

        public void OutputToLog(string type, string localPort, string remoteAddress, string remotePort, string data)
        {
            //Data to output to the log
            string[] row = { type, localPort.ToString(), remoteAddress, remotePort.ToString(), data, DateTime.UtcNow.ToString() };
            var item = new ListViewItem(row);
            listviewLog.Items.Add(item);
            listviewLog.Items[listviewLog.Items.Count - 1].EnsureVisible();
        }

        public void outputToLog(string type, string data)
        {
            OutputToLog(type, "", "", "", data);
        }

        private void UpdateLatencyValue(object sender, EventArgs e)
        {
            tLatency.Text = latencyBar.Value.ToString();
        }

        private void tLatency_TextChanged(object sender, EventArgs e)
        {
            int newVal = 0;

            try
            {
                newVal = int.Parse(tLatency.Text);
            }
            catch
            {
                outputToLog("Error:", "Value is Not A Number");
            }

            if(newVal > 10000)
            {
                newVal = 10000;
                tLatency.Text = "10000";
            }
            else if(newVal < 0)
            {
                newVal = 0;
                tLatency.Text = "0";
            }

            latencyBar.Value = newVal;
        }
    }
}
