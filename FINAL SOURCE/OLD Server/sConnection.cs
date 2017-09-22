using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Threading;
using System.ComponentModel;
using System.Windows.Forms;

namespace Server
{
    class sConnection
    {
        ServerForm ParentForm;

        TcpClient client = new TcpClient();
        StreamReader clientStreamReader;
        StreamWriter clientStreamWriter;

        public sConnection(ServerForm f)
        {
            ParentForm = f;
        }

        public void initialiseConnection(IPAddress address, int port, int latency, string[] msg)
        {
            //Initialise a new client
            client = new TcpClient();

            ParentForm.OutputToLog("Conn:", "", address.ToString(), port.ToString(), "Attempting connection to client...");
            try
            {
                client.Connect(address, port);
                ParentForm.OutputToLog("Conn:", "", address.ToString(), port.ToString(), "Connected!");
                sendData(address, port, latency, msg);
            }
            catch
            {
                ParentForm.OutputToLog("Conn:", "", address.ToString(), port.ToString(), "Could not connect to client, Server is probably not listening");
                return;
            }
        }

        public void sendData(IPAddress address, int port, int latency, string[] msg)
        {
            try
            {
                if (client.Connected)
                {
                    NetworkStream nStream = client.GetStream();
                    clientStreamReader = new StreamReader(nStream);
                    clientStreamWriter = new StreamWriter(nStream);
                    foreach (string s in msg)
                    {
                        clientStreamWriter.WriteLine(s);
                        ParentForm.OutputToLog("Sent:", "", address.ToString(), port.ToString(), s);
                        clientStreamWriter.Flush();
                        Application.DoEvents();
                        Thread.Sleep(latency);
                    }
                }
            }

            catch (ArgumentNullException e)
            {
                ParentForm.outputToLog("Error:", "ArgumentNullException: " + e);
            }
            catch (SocketException e)
            {
                ParentForm.outputToLog("Error:", "SocketException: " + e);
            }
            catch
            {
                ParentForm.outputToLog("Error:", "Could not connect to server");
                return;
            }
        }
        public void closeConnection()
        {
            try
            {
                client.Close();
            }
            catch
            {
                ParentForm.outputToLog("Error:", "Could not close connection");
            }
        }
    }
}
