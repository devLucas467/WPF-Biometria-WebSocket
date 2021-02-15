using BiometriaEWebSocket.Classes.Models.Credential_Body;
using Client.Controllers;
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
    public static class WebSocketHSS
    {
        public static List<string> MessageList = new List<string>();
        public static bool HasBiometric = false;
        public static void  Start()
        {
            Connect("ws://172.16.100.49:82/connected-architecture-ws").Wait();
            Debug.WriteLine("Conectado");
        }



        public static FingerprintIndentifier GetHex()
        {
            string hexval = MessageList.Where(h => h.Contains("hexValue")).FirstOrDefault();
            hexval = "464D52002032300002D80035001700000118016000C500C501000000001980B4002AB00F405B002E640F40CF0039550B404C00480D0F40F1004C540A805600600A0D80A30061B20F4051006C060E40C00077580F40540079000B405E007D600B405100860B0C406100A4050F408400AB600F404D00C6670F805800C90A0F408D00D5670F406000E06A0F80EE00E7A30E407E00FB740F40B40115A501807301277A0F803A01396E0A4056013E760E409C014085090222010102224943020301041C346B280E0C0000FF0000008DDF6CCA3C98A5FF20320102041B790800BC18806CC0600F00DB25867BC1707EC14504005D316D6C0B00CD36865FC3FFC1C1C1C00500F33589FF7F0400D53906520E00CD3B8050C4C0FE7FC0570B00DA4A835689FE840F01065B8C77518BC0FF5D0800A86206C2FDC0C23A0E00FD6689FFC3FEC3FEC1C4C043FF04004B6F703C0D002671F1C1C1FF5350280800BE73837CC0380500C67803420900BE7A8377FF710D00FF7986FFC1FF6A8B3D05004F7C713805004C8970FFFDC3130019A3F4FE7653C0C0C03EC0FE6A130105978CC1C15FC0C07062FF5D0D00FF9F8CC1C1FEC45262C006005DA677C3FD5C0D0065A7F745C0FEC1FE4AC00A008BA9FDC2FD57FEC2FF0A0083AE7A7743731400FFBB8C59756264C4FF45C10D00FDC38C59C0C2707305004AC66D65080013CAEDFEC073FE0B008BD370C2626D820A0093D3FA3D337B1500FFCF9373C3C07F7467597D0B008BD97083C0C1FFC1470E0067DDED3DFF46FE37C00900FFD893C0757C08005FDE6DC2FFC1C191080060E46978C0910D0084F7E93B23FDC1C02B08007CFB6070FF5D060080FF5A56C0151102009EC1669D8B835CC12C0610B51203F9FE291511010BA05CC28CC4C0C0896B5B0C10180CDA35C1FFFDC24B0510A5185CC26D0410B51910FBFC1210FD2AB0C3C1C1FFC1C4C1C5C290C1FF860F10EF39B493C0C4C3C5C2C2C2C1C1C00D10E538B190B0C2C3C24F5242000B430100000B4552000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";
            //foreach (string s in MessageList)
            //{
            //    "identifierFormat":"ANSI_378_PLUS_PADDED"
            //    if (s.Contains("\"hexValue:\""))
            //    {
            //        hexval = s;
            //    }
            //}
            return new FingerprintIndentifier()
            {
                recognitionType = "FINGERPRINT",
                identifierFormat = "ANSI_378_PLUS_PADDED_ENCRYPTED",
                hexValue = hexval,
                exemptedFromAuthentication = false,
                finger = "LEFT_LITTLE_FINGER",
                duress = false,
                templateExpiryAge = new TemplateExpireAge("WEEKS",1)
            };

        }

        public static async Task Connect(string uri)
        {
            Thread.Sleep(1000); //wait for a sec, so server starts and ready to accept connection..

            ClientWebSocket webSocket = null;
            try
            {
                webSocket = new ClientWebSocket();
                webSocket.Options.SetRequestHeader("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJyZXF1ZXN0TG9nZ2luZyI6ZmFsc2UsImN1c3RvbWVySWQiOjEsImxvZ2luIjoiYWRtaW4iLCJleHAiOjE2MTMyNDk4NDQsImlhdCI6MTYxMzE2MzQ0NH0.YojukjjHOSj9zWY9LgdOgssT29EK7CqHz4lMErhins4");

               // string token = string.Format("Bearer {0}",AuthenticationController.AuthToken);
              //  webSocket.Options.SetRequestHeader("Authorization",token);

                await webSocket.ConnectAsync(new Uri(uri), CancellationToken.None);
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
            bool acumula = false;
            StringBuilder imagem = new StringBuilder();
            Debug.WriteLine("Recebendo mensagem do servidor");
            byte[] buffer = new byte[500000];
            while (webSocket.State == WebSocketState.Open)
            {
                ArraySegment<byte> temp = new ArraySegment<byte>(buffer);
                var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                if (result.MessageType == WebSocketMessageType.Close)
                {
                    await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, CancellationToken.None);
                }
                else
                {
                    var resp = Encoding.UTF8.GetString(buffer).TrimEnd('\0');
                    Console.WriteLine(resp);
                    //if (resp.Contains("capturing"))
                    //{
                    //    acumula = false;
                    //    if (!string.IsNullOrEmpty(imagem.ToString()))
                    //    {
                    //        MessageList.Add(imagem.ToString());
                    //        imagem = new StringBuilder();
                    //    }
                    //}

                    //if (acumula)
                    //{
                    //    imagem.Append(resp.Replace("{\"data\":", ""));
                    //}
                    //if (resp.Contains("captured"))
                    //{
                    //    acumula = true;
                    //}

                    if (acumula)
                    {
                        imagem.Append(resp);
                    }
                    if (resp.Contains("hexValue"))
                    {
                        acumula = true;
                        //MessageList.Add(imagem.ToString());
                        //imagem = new StringBuilder();
                        imagem.Append(resp);
                        //MessageList.Add(imagem.ToString());
                        HasBiometric = true;
                    }
                    if (resp.Contains("\"value\":\"OK\""))
                    {
                        imagem.Append(resp);
                        MessageList.Add(imagem.ToString());
                        HasBiometric = true;
                        acumula = false;
                    }
                }
            }
        }
    }
}
