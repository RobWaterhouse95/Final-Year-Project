using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;

namespace Client
{
    public class cConnection
    {
        ClientForm ParentForm;

        public TcpClient client = new TcpClient();
        StreamReader clientStreamReader;
        StreamWriter clientStreamWriter;

        public TcpListenerEx listener;
        public bool listening;
        private int tick = 0;

        public cConnection(ClientForm f)
        {
            ParentForm = f;
        }

        public void startListener(int port)
        {
            //default port is 25565 as per the form design
            listener = new TcpListenerEx(IPAddress.Any, port);
            listener.Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
            listener.Start();
            client = new TcpClient();
            listening = true;
            clientListenAsync(port);
        }

        public void initialiseConnection(IPAddress address, int port)
        {
            //Initialise a new client
            client = new TcpClient();

            ParentForm.OutputToLog("Conn:", "", address.ToString(), port.ToString(), "Attempting connection to tool...");
            try
            {
                client.Connect(address, port);
                ParentForm.OutputToLog("Conn:", "", address.ToString(), port.ToString(), "Connected!");
                ParentForm.disconnectBtn.Enabled = true;
                NetworkStream nStream = client.GetStream();
                clientStreamWriter = new StreamWriter(nStream);
                clientStreamReader = new StreamReader(nStream);
                listening = true;
                clientListenAsync(port);
            }
            catch
            {
                ParentForm.OutputToLog("Conn:", "", address.ToString(), port.ToString(), "Could not connect to tool, Server is probably not listening");
                return;
            }
        }

        public async void clientListenAsync(int localPort)
        {
            try
            {
                while (true && listening)
                {
                    string remoteAddr = String.Empty;
                    string remotePort = String.Empty;

                    //Asynchronously wait for a connection
                    if (!client.Connected)
                    {
                        ParentForm.OutputToLog("Conn:", localPort.ToString(), "", "", "Waiting for a connection on port " + localPort.ToString());
                        client = await listener.AcceptTcpClientAsync();
                        string[] parts = client.Client.RemoteEndPoint.ToString().Split(':');
                        remoteAddr = parts[0];
                        remotePort = parts[1];
                        ParentForm.OutputToLog("Conn:", localPort.ToString(), remoteAddr, remotePort, "Connected!");

                        NetworkStream nStream = client.GetStream();

                        clientStreamWriter = new StreamWriter(nStream);
                        clientStreamReader = new StreamReader(nStream);
                        ParentForm.disconnectBtn.Enabled = true;
                    }
                    else
                    {
                        try
                        {
                            string incoming = await clientStreamReader.ReadLineAsync();
                            string temp = incoming;

                            string[] parts = client.Client.RemoteEndPoint.ToString().Split(':');
                            remoteAddr = parts[0];
                            remotePort = parts[1];

                            if (temp != null)
                            {
                                ParentForm.OutputToLog("Received:", localPort.ToString(), remoteAddr, remotePort, temp);
                                incomingData(temp);
                            }
                            else
                            {
                                //bad state
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex);
                            //Tool is hanging after client disconnects
                        }
                    }
                    
                }
            }
            catch (ObjectDisposedException e)
            {
                Console.WriteLine("" + e);
            }
            catch (Exception e)
            {
                ParentForm.outputToLog("Error:", "Unknown error: " + e);
            }
        }

        private Color returnColour(int level)
        {
            switch (level)
            {
                case 0:
                    return SystemColors.Control;
                case 1:
                    return Color.FromArgb(255 / 5, 0, 0, 0);
                case 2:
                    return Color.FromArgb(255 / 4, 0, 0, 0);
                case 3:
                    return Color.FromArgb(255 / 3, 0, 0, 0);
                case 4:
                    return Color.FromArgb(255 / 2, 0, 0, 0);
                case 5:
                    return Color.FromArgb(255 / 1, 0, 0, 0);
                default:
                    return SystemColors.Control;
            }
        }

        public void sendData(string msg)
        {
            try
            {
                if (client.Connected)
                {
                    NetworkStream nStream = client.GetStream();
                    clientStreamReader = new StreamReader(nStream);
                    clientStreamWriter = new StreamWriter(nStream);

                    clientStreamWriter.WriteLine(msg);

                    string address = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
                    string port = ((IPEndPoint)client.Client.RemoteEndPoint).Port.ToString();
                    ParentForm.OutputToLog("Sent:", "", address, port, msg);
                    clientStreamWriter.Flush();
                    Application.DoEvents();
                }
                else{
                    if(tick == 0)
                    {
                        ParentForm.outputToLog("Error:", "Could not send data, Client not connected.");
                        RepeatDelay();
                    }
                }
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
                if (client.Connected)
                {
                    ParentForm.disconnectBtn.Enabled = false;
                    listening = false;
                    sendData("0xxClientClosing");
                    client.GetStream().Close();
                    client.Close();
                    ParentForm.outputToLog("Conn:", "Closing connection");
                }
            }
            catch
            {
                ParentForm.outputToLog("Error:", "Could not close connection");
            }
        }

        void incomingData(string data)
        {
            switch (data)
            {
                case "0xxToolClosing":
                case "0xxToolStopListening":
                case "0xxClientClosing":
                    closeConnection();
                    break;
                default:
                    break;
            }

            if (data.StartsWith("1xx"))
            {
                string[] _data = data.Split(',');
                int[] _vals = new int[2];
                for (int i = 0; i < 2; i++)
                {
                    int.TryParse(_data[i + 1], out _vals[i]);
                }
                ParentForm.btnArray[_vals[0], _vals[1]].BackColor = returnColour(6);
                ParentForm.btnArray[_vals[0], _vals[1]].level = 6;
                ParentForm.btnArray[_vals[0], _vals[1]].tick();
            }
        }

        async void RepeatDelay()
        {
            while (tick < 2)
            {
                tick++;
                await Task.Delay(1000);
            }
            if(tick == 2)
            {
                tick = 0;
            }
        }
    }
}
