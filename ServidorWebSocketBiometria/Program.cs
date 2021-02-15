using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ServidorWebSocketBiometria
{
    class Program
    {
        private const int port = 2222; //Choosing the port
        static void Main(string[] args)
        {
            //configuring the IP and server
            IPAddress ip = Dns.GetHostEntry("localhost").AddressList[0];
            TcpListener server = new TcpListener(ip, port);
            TcpClient device = default(TcpClient);

            //Starting and operating server
            try
            {
                server.Start();
                Console.WriteLine("Server is Online");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            while(true)
            {
                device = server.AcceptTcpClient();

                byte[] buffer = new byte[100];
                NetworkStream stream = device.GetStream();

                stream.Read(buffer, 0, buffer.Length);

                string msg = Encoding.ASCII.GetString(buffer, 0, buffer.Length);

                Console.WriteLine(msg);
            }

        }
    }
}
