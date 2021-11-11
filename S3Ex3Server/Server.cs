using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace S3Ex3Server
{
    public class Server
    {
        private List<SocketHandler> listOfSocketHandlers = new List<SocketHandler>();

        public void StartServer()
        {
            Console.WriteLine("Starting Server...");

            IPAddress ip = IPAddress.Parse("127.0.0.1");

            TcpListener listener = new TcpListener(ip, 5000);
            listener.Start();
            Console.WriteLine("Server started....");

            while (true)
            {
                SocketHandler socketHandler = new SocketHandler(this);
                TcpClient client = listener.AcceptTcpClient();
                listOfSocketHandlers.Add(socketHandler);
                Console.WriteLine("Client connected");
                Thread t = new Thread(() => socketHandler.Run(client));
                t.Start();
            }
        }


        public void BroadcastMsg(string msg)
        {
            foreach (SocketHandler handler in listOfSocketHandlers)
            {
                handler.SendMessage(msg);
                Console.WriteLine("WROTE IN BROADCSAT TO CLINET");
            }

        }
    }
}