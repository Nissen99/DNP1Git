using System;

namespace S3Ex3Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            
            client.StartClient();
        }
    }
}