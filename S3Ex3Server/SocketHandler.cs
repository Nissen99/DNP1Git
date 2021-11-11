using System;
using System.Net.Sockets;
using System.Text;

namespace S3Ex3Server
{
    public class SocketHandler
    {
        private TcpClient client;
        private NetworkStream stream;
        private Server Server;

        public SocketHandler(Server server)
        {
            this.Server = server;
        }

        public void Run(TcpClient client)
        {
            this.client = client; 
            stream = client.GetStream();

            while (true)
            {
                byte[] dataFromClient = new byte[1024];
                int bytesRead = stream.Read(dataFromClient, 0, dataFromClient.Length);
                string s = Encoding.ASCII.GetString(dataFromClient, 0, bytesRead);
                Console.WriteLine(s);

                if (s.Equals("exit"))
                {
                    client.Close();
                    Console.WriteLine("SERVER SHUT DOWN");
                    break;
                }
                
                Server.BroadcastMsg(s);
                
            }
        }

        public void SendMessage(string msg)
        {
            byte[] dataToClient = Encoding.ASCII.GetBytes(msg);
            stream.Write(dataToClient, 0, dataToClient.Length);
        }
    }
}