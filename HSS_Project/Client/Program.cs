using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        private static UTF8Encoding encoding = new UTF8Encoding();

        static void Main(string[] args)
        {
            //Connect("ws://192.168.0.101/WebsocketHttpListenerDemo").Wait();
            Connect("ws://172.16.100.49:82/connected-architecture-ws").Wait();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static async Task Connect(string uri)
        {
            Thread.Sleep(1000); //wait for a sec, so server starts and ready to accept connection..

            ClientWebSocket webSocket = null;
            try
            {
                webSocket = new ClientWebSocket();
                webSocket.Options.SetRequestHeader("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJyZXF1ZXN0TG9nZ2luZyI6ZmFsc2UsImN1c3RvbWVySWQiOjEsImxvZ2luIjoiYWRtaW4iLCJleHAiOjE2MTMxMDA0NTgsImlhdCI6MTYxMzAxNDA1OH0.tPuCTQBzT5B2CcXNGSsDTXGzeZD85m38WFsmKdJ1DEY");

                await webSocket.ConnectAsync(new Uri(uri), CancellationToken.None);
                //await Task.WhenAll(Receive(webSocket), Send(webSocket));
                await Task.WhenAll(Receive(webSocket));

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex);
            }
            finally
            {
                if (webSocket != null)
                    webSocket.Dispose();
                Console.WriteLine();
                Console.WriteLine("WebSocket closed.");
            }
        }

        private static async Task Receive(ClientWebSocket webSocket)
        {
            Debug.WriteLine("Recebendo mensagem do servidor");
            byte[] buffer = new byte[1024];
            while (webSocket.State == WebSocketState.Open)
            {
                ArraySegment<byte> temp = new ArraySegment<byte>(buffer);
                var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                Debug.WriteLine(result);
                if (result.MessageType == WebSocketMessageType.Close)
                {
                    await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, CancellationToken.None);
                }
                else
                {
                    Console.WriteLine("Receive:  " + Encoding.UTF8.GetString(buffer).TrimEnd('\0'));
                }
            }
        }

    }
}
