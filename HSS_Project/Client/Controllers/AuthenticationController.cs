using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Client.Controllers
{
    public class AuthenticationController
    {
        public static string AuthToken { get; set; }
        
        /// <summary>
        /// Método que retorna o Token de autenticação
        /// </summary>
        /// <returns>
        /// </returns>
        /// 
        public static void GetToken()
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            var client = new RestClient("https://172.16.100.49:443/authn/token");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("X-Correlation-ID", "97061a5d-904c-41c8-80f8-d1e8bc3766de");
            request.AddHeader("Cookie", "JSESSIONID=node08bkeu3bexilu7rqsj1zqvwo0235.node0");
            request.AddParameter("client_id", "1-admin");
            request.AddParameter("client_secret", "password");
            request.AddParameter("grant_type", "client_credentials");
            request.AddParameter("scope", "openid,profile,developerMode");
            IRestResponse response = client.Execute(request);
            JObject json = (JObject)JsonConvert.DeserializeObject(response.Content);

            AuthToken = json["access_token"].ToString();

        }

        public static string Token()
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

           return json["access_token"].ToString();

        }

    }
}
