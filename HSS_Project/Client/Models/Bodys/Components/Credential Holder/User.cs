using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometriaEWebSocket.Classes.Models.Bodys.Components.Credential_Holder
{
    public class User
    {
        public Key key { get; set; }
        public User(string u, string org)
        {
            key = new Key(u, org);
        }
    }
}
