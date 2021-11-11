using System;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using Shared;

namespace S3Ex3Client
{
    public class Client
    {
        public void StartClient()
        {
            Console.WriteLine("Starting client....");

            TcpClient client = new TcpClient("127.0.0.1", 5000);

            NetworkStream Stream = client.GetStream();
             

            while (true)
            {

                string input = Console.ReadLine();
                string input3 = Console.ReadLine();

                Message message = new Message() {Name = input, Text= input3};

                string sending = JsonSerializer.Serialize(message);
                
                byte[] dataToServer = Encoding.ASCII.GetBytes(sending);
                Stream.Write(dataToServer, 0, dataToServer.Length);

                Thread thread = new Thread(() => MsgRecived(client));
                thread.Start();


                if (input.Equals("exit"))
                {
                    Stream.Close();
                    client.Close();
                    Console.WriteLine("Client SHUT DOWN");
                    break;
                }
                
            }
            
        }

        public void MsgRecived(TcpClient client)
        {
            while (true)
            {
                byte[] dataFromServer = new byte[1024];
                NetworkStream Stream = client.GetStream();
                int bytesRead = Stream.Read(dataFromServer, 0, dataFromServer.Length);
                string response = Encoding.ASCII.GetString(dataFromServer, 0, bytesRead);
                Message printout = JsonSerializer.Deserialize<Message>(response);
                Console.WriteLine("From Server: " + printout.Name + ": " + printout.Text); 
                
             
            }
        }
    }
}