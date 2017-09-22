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
using Client;

namespace Tool
{
    public class tConnection
    {
        ToolForm ParentForm;

        public TcpClient client = new TcpClient();

        public TcpListenerEx listener;
        public bool listening;

        StreamReader cStreamReader;
        StreamWriter cStreamWriter;

        public int connectionNumber;

        tConnection otherConnection;

        Random r;
                
        public tConnection(ToolForm f, int i)
        {
            ParentForm = f;
            connectionNumber = i;
            r = new Random();
        }

        public void setOtherConn(tConnection compConn)
        {
            if(compConn == ParentForm.conn1)
            {
                otherConnection = ParentForm.conn1;
            }
            else if(compConn == ParentForm.conn2)
            {
                otherConnection = ParentForm.conn2;
            }
        }
        
        public void sendAcrossData(string msg)
        {
            int time;
            int.TryParse(ParentForm.tLatency.Text, out time);
            Thread.Sleep(time);

            int packetLoss;
            int.TryParse(ParentForm.tPacketLoss.Text, out packetLoss);
            int value = r.Next(0, 100);
            if(value > packetLoss)
            {
                //Don't send
            }
            else
            {
                //Do send
                otherConnection.sendData(msg);
            }            
        }

        public void sendData(string msg)
        {
            try
            {
                if (client.Connected)
                {
                    int time;
                    int.TryParse(ParentForm.tLatency.Text, out time);
                    Task.Delay(time);
                    Application.DoEvents();

                    NetworkStream nStream = client.GetStream();
                    cStreamReader = new StreamReader(nStream);
                    cStreamWriter = new StreamWriter(nStream);
                    
                    cStreamWriter.WriteLine(msg);
                    
                    string address = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
                    string port = ((IPEndPoint)client.Client.RemoteEndPoint).Port.ToString();
                    ParentForm.OutputToLog("Sent:", "", address.ToString(), port.ToString(), msg, connectionNumber.ToString());

                    cStreamWriter.Flush();
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

        public async void clientListenAsync(int localPort)
        {
            try
            {
                while (true && listening)
                {
                    string remoteAddr = String.Empty;
                    string remotePort = String.Empty;

                    //Asynchronously wait for a connection
                    if(!client.Connected) { 
                        ParentForm.OutputToLog("Conn:", localPort.ToString(), "", "", "Waiting for a connection on port " + localPort.ToString(), connectionNumber.ToString());
                        client = await listener.AcceptTcpClientAsync();
                        string[] parts = client.Client.RemoteEndPoint.ToString().Split(':');
                        remoteAddr = parts[0];
                        remotePort = parts[1];
                        ParentForm.OutputToLog("Conn:", localPort.ToString(), remoteAddr, remotePort, "Connected!", connectionNumber.ToString());

                        NetworkStream nStream = client.GetStream();

                        cStreamWriter = new StreamWriter(nStream);
                        cStreamReader = new StreamReader(nStream);
                    }
                    else
                    {
                        try
                        {
                            string incoming = await cStreamReader.ReadLineAsync();
                            string temp = incoming;
                            if (temp != null)
                            {
                                if (isClientCommand(temp) == false)
                                {
                                    ParentForm.OutputToLog("Received:", localPort.ToString(), remoteAddr, remotePort, temp, "from: " + connectionNumber.ToString() + " to Tool");
                                    if (otherConnection.client.Connected)
                                    {
                                        ParentForm.OutputToLog("Sending:", localPort.ToString(), remoteAddr, remotePort, temp, "from Tool to: " + otherConnection.connectionNumber.ToString());
                                        sendAcrossData(temp);
                                    }
                                }                                
                            }                        
                        }
                        catch(Exception ex)
                        {
                            //Tool is hanging after client disconnects
                        }                                               
                    }      
                }
            }
            catch(ObjectDisposedException e)
            {
                Console.WriteLine("" + e);
            }
            catch (Exception e)
            {
                ParentForm.outputToLog("Error:", "Unknown error: " + e);
            }
        }

        private void closeConnection()
        {
            try
            {
                sendData("0xxToolClosing");
                client.GetStream().Close();
                client.Close();
                ParentForm.OutputToLog("Conn:", "", "", "", "Closed Connection", connectionNumber.ToString());
            }
            catch
            {
                ParentForm.outputToLog("Error:", "Could not close connection");
            }
        }

        public void closeServer()
        {
            closeConnection();
            try
            {
                if (listener.Active)
                {
                    listener.Stop();
                    ParentForm.OutputToLog("Conn:", "", "", "", "Stopped listening", connectionNumber.ToString());
                    listening = false;
                }
            }
            catch (Exception e)
            {
                ParentForm.outputToLog("Error:", "Could not close the server" + e);
            }
        }

        public bool isClientCommand(string msg)
        {
            switch (msg)
            {
                case "0xxClientClosing":
                    ParentForm.OutputToLog("Read:", "", "", "", "Connection has been terminated remotely,", connectionNumber.ToString());
                    closeConnection();
                    return true;
                default:
                    return false;
            }
        }
    }
}
