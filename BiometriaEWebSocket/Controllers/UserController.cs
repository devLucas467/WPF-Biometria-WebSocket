using BiometriaEWebSocket.Classes;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Collections.ObjectModel;

namespace BiometriaEWebSocket.Controllers
{
    public class UserController
    {

        private static string AuthToken;
        /// <summary>
        /// Método que retorna uma lista com todos os usuários
        /// </summary>
        /// <returns>
        /// </returns>
        /// 

        public static void Authentication()
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            var client = new RestClient("https://172.16.100.49:443/authn/token");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("X-Correlation-ID", "64432a39-f519-40c2-bc8e-d397ef9bf584");
            request.AddHeader("Cookie", "JSESSIONID=node0t5alh0oqa7ztz8d87n8nxy3e90.node0");
            request.AddParameter("client_id", "1-admin");
            request.AddParameter("client_secret", "password");
            request.AddParameter("grant_type", "client_credentials");
            request.AddParameter("scope", "openid,profile,developerMode");
            IRestResponse response = client.Execute(request);
            JObject json = (JObject)JsonConvert.DeserializeObject(response.Content);

            UserController.AuthToken = json["access_token"].ToString();

        }


        public static ObservableCollection<User> GetAllUsers()
        {
            string url = Routes.GetAllUsers();
            ObservableCollection<User> users = new ObservableCollection<User>();

            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/vnd.hid-signo-biometric-api-1.0+json");
            request.AddHeader("Authorization", "Bearer " + UserController.AuthToken);
            request.AddHeader("X-Correlation-ID", "83d46b1f-976c-4508-bd97-c37220466391");
            request.AddHeader("Cookie", "JSESSIONID=node015u5pf8xmdfo3b9zkrfk59w1y10.node0");
            IRestResponse response = client.Execute(request);
            JObject json; 
            try
            {
                json = (JObject)JsonConvert.DeserializeObject(response.Content);
                foreach (JObject a in json["users"])
                {
                    users.Add(new User()
                    {
                        FirstName = a["attributes"]["firstName"].ToString(),
                        LastName = a["attributes"]["lastName"].ToString(),
                        Description = a["attributes"]["description"].ToString(),
                        Phone = a["attributes"]["phone"].ToString(),
                        Email = a["attributes"]["email"].ToString(),
                        // UserID = a["key"]["userId"].ToString()
                    }); ;
                }
            }
            catch (Exception e)
            {

                Debug.WriteLine("Erro ao carregar usuarios : " + e.ToString());
                return null;
            }
 

            return users; ;
        }

        public static User GetUser(string UserID)
        {
            string url = Routes.GetUser();

            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            var client = new RestClient(url + UserID);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/vnd.hid-signo-biometric-api-1.0+json");
            request.AddHeader("Authorization", "Bearer " + UserController.AuthToken);
            request.AddHeader("X-Correlation-ID", "dc6b405a-8388-4398-bc7c-62d3aa96f000");
            request.AddHeader("Cookie", "JSESSIONID=node0piahzn83s6bbg4h50532n4rz14.node0");
            IRestResponse response = client.Execute(request);
            JObject json =(JObject) JsonConvert.DeserializeObject(response.Content);

            User getto = new User();
            getto.FirstName = json["attributes"]["firstName"].ToString();
            getto.LastName = json["attributes"]["lastName"].ToString();
            getto.Description = json["attributes"]["description"].ToString();
            getto.Email = json["attributes"]["email"].ToString();
            getto.Phone = json["attributes"]["phone"].ToString();
            //getto.UserID = json["key"]["userId"].ToString();
            
            

            return getto;
        }

        public static void CreateUser(User user)
        {
            string JsonUser = ConvertUserToBodyJson(user);

            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

            string url = Routes.CreateUser();
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/vnd.hid-signo-biometric-api-1.0+json");
            request.AddHeader("Authorization", "Bearer " + UserController.AuthToken);
            request.AddHeader("X-Correlation-ID", "14d6b4aa-e2cf-4750-b8e5-68eb41b92630");
            request.AddHeader("Cookie", "JSESSIONID=node01tjo2fgejmk5oppywjt3r6qcd39.node0");
            request.AddParameter("application/vnd.hid-signo-biometric-api-1.0+json", JsonUser, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var resp = response.Headers.ElementAt(7);
            user.UserID = resp.ToString().Split('/')[9];

          
            
            
        }

        private static string ConvertUserToBodyJson(User u)
        {
            return "{\n " +
                " \"lastName\":" + u.LastName + ",\n " +
                " \"firstName\":" + u.FirstName + ",\n " +
                " \"description\":" + u.Description + ",\n " +
                " \"phone\":" + u.Phone + ",\n  " +
                "\"email\":" + u.Email  + ",\n " +
                " \"domainKey\": {\n  " +
                "  \"domainId\": 00000000-0000-0000-0000-000000000001\n " +
                " }\n}";
        }



    }
}


