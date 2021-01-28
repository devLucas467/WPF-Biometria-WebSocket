using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometriaEWebSocket.Classes
{
    class Routes
    {


        public static string AuthorizationToken()
        {
            return "/authn/token";
        }

        public static string GetAllUsers()
        {
            return "https://172.16.100.49:443/connected-architecture/customer/1/system/00000000-0000-0000-0000-000000000001/user";
        }

        public static string GetUser()
        {
            return "https://172.16.100.49:443/connected-architecture/customer/1/system/00000000-0000-0000-0000-000000000001/user/";
        }

        public static string CreateUser()
        {
            return "https://172.16.100.49:443/connected-architecture/customer/1/system/00000000-0000-0000-0000-000000000001/user";
        }
    }
}
