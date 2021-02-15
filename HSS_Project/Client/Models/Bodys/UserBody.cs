using BiometriaEWebSocket.Classes.Models.Credential_Body;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometriaEWebSocket.Classes.Models.Bodys
{
    public class UserBody
    {
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string description { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public DomainKey domainKey { get; set; }

        public UserBody(string first)
        {
            firstName = first;
            lastName = "Last Name";
            description = "HSS User description";
            phone = "000 - 000 0000"; 
            email = "wboucher@hidglobal.com";
            domainKey = new DomainKey("00000000-0000-0000-0000-000000000001");
        }

    }
}
