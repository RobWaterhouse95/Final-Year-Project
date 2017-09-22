using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Drawing;
using System.Threading.Tasks;

namespace Client
{
    public partial class ClientForm : Form
    {
        Logger logger;
        public cConnection conn;
        public HoverButton[,] btnArray;
        private int arrayWidth, arrayHeight;        

        //TODO Allow clients to connect to each other
        //TODO Change tool from queue system to just latency
        //TODO Add packet loss (Throw away X amount of packets per 100)

        public ClientForm()
        {
            InitializeComponent();

            //Pass in the parent form into the logger / connection so it can access the log object
            logger = new Logger(this);
            conn = new cConnection(this);

        }
        private void ClientForm_Load(object sender, EventArgs e)
        {
            setupBoard();
        }

        private void listenBtn_Click(object sender, EventArgs e)
        {
            int portNumber;
            int.TryParse(listenerPortTxt.Text, out portNumber);
            conn.startListener(portNumber);
        }

        void setupBoard()
        {
            arrayWidth = 19;
            arrayHeight = 7;
            int size = 20;
            btnArray = new HoverButton[arrayWidth, arrayHeight];
            for (int i = 0; i < arrayWidth; i++)
            {
                for (int j = 0; j < arrayHeight; j++)
                {
                    //618, 12
                    int x = 618 + (size * i);
                    int y = 12 + (size * j);
                    btnArray[i, j] = new HoverButton(size, x, y, this, i, j);
                    this.Controls.Add(btnArray[i, j]);
                    btnArray[i, j].Show();
                }
            }
        }

        public void OutputToLog(string type, string localPort, string remoteAddress, string remotePort, string data)
        {
            //Stuff to output to the log object
            string[] row = { type, localPort.ToString(), remoteAddress, remotePort.ToString(), data, DateTime.UtcNow.ToString() };

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
            OutputToLog(type, "", "", "", data);
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

        private void bConnect_Click(object sender, EventArgs e)
        {
            //Try to parse the IPAddress from the text boxes on the form
            IPAddress address;
            bool resHost = IPAddress.TryParse(tAddress1.Text + "." + tAddress2.Text + "." + tAddress3.Text + "." + tAddress4.Text, out address);
            if (resHost == false)
            {
                outputToLog("Error:", "Unable to parse IP Address, Make sure it is a valid Address");
            }

            //Try to parse the port from the text box on the form
            int port;
            bool resPort = Int32.TryParse(tAddressP.Text, out port);
            if (resPort == false)
            {
                outputToLog("Error:", "Unable to parse port number, Make sure it is a valid port number");
            }

            //If either of the values did not parse, do not run the SendData function. Output to the log showing error
            if (resHost == false || resPort == false)
            {
                return;
            }
            else
            {
                if (!conn.client.Client.Connected)
                {
                    conn.initialiseConnection(address, port);
                }
            }
        }
        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.client.Client.Connected)
                {
                    conn.closeConnection();
                }
            }
            catch (Exception ex)
            {
                outputToLog("Error:", "Unknown Error: " + ex);
            }
        }

        private void bSaveToFile_Click(object sender, EventArgs e)
        {
            logger.logToFile();
        }
        
        private async void debugBtn_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int counter = 0;
            while (true)
            {
                await Task.Delay(130);
                btnArray[counter, r.Next(0, 6)].fakeMouseEnter();
                counter++;
                if (counter >= arrayWidth)
                    counter = 0;
            }
        }

        private void stopListeningBtn_Click(object sender, EventArgs e)
        {
            if (conn.client.Connected)
            {
                conn.closeConnection();
            }
            conn.listening = false;
            outputToLog("Conn:", "Stopped listening");
            conn.listener.Stop();
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn.client.Connected)
            {
                conn.closeConnection();
            }
        }
    }
}
