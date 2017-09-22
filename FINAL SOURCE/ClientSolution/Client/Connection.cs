using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Connection
    {
        ClientForm _ParentForm;
        
        public TcpClient client;
        public TcpListenerEx server = null;

        public Connection(ClientForm form)
        {
            _ParentForm = form;
        }

        public void startListener(int port)
        {
            //default port is 25565 as per the form design
            server = new TcpListenerEx(IPAddress.Any, port);
            server.Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
            server.Start();
            clientListenAsync(port);
        }

        public async Task clientListenAsync(int localPort)
        {
            
            try
            {
                while (true)
                {
                    _ParentForm.OutputToLog("Conn:", localPort.ToString(), "", "", "Waiting for a connection on port");

                    Byte[] bytes = new Byte[256];
                    String data = null;

                    //Asynchronously wait for a connection
                    client = await server.AcceptTcpClientAsync();

                    string[] parts = client.Client.RemoteEndPoint.ToString().Split(':');
                    string remoteAddr = parts[0];
                    string remotePort = parts[1];

                    _ParentForm.OutputToLog("Conn:", localPort.ToString(), remoteAddr, remotePort, "Connected!");

                    NetworkStream stream = client.GetStream();

                    int i;

                    // Loop to receive all the data sent by the client.
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        // Translate data bytes to a ASCII string.
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        _ParentForm.OutputToLog("Received:", localPort.ToString(), remoteAddr, remotePort, data);

                        // Process the data sent by the client.
                        data = data.ToUpper();

                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                        // Send back a response.
                        stream.Write(msg, 0, msg.Length);
                        //Console.WriteLine(String.Format("Sent: {0}", data));

                        i = stream.Read(bytes, 0, bytes.Length);
                    }

                    client.Close();
                }
            }
            catch (SocketException e)
            {
                _ParentForm.OutputToLog("Error:", "SocketException: " + e);
            }
            /*
            catch (Exception e)
            {
                _ParentForm.OutputToLog("Error:", "Unknown error: " + e);
            }
            */
        }

        public void closeConnection()
        {
            try
            {
                if (client.Connected)
                {
                    client.Close();
                }                
            }
            catch (Exception e)
            {
                _ParentForm.OutputToLog("Error:", "Could not close the connection" + e);
            }
            
        }

        public void closeServer()
        {
            closeConnection();

            try
            {
                if (server.Active)
                {
                    server.Stop();
                }                
            }
            catch (Exception e)
            {
                _ParentForm.OutputToLog("Error:", "Could not close the server" + e);
            }
        }
    }
}
