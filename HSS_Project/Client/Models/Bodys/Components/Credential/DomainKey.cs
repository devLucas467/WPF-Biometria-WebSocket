using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometriaEWebSocket.Classes.Models.Credential_Body
{
    public class DomainKey
    {
        public string domainId { get; set; }
        public DomainKey(string s)
        {
            domainId = s;
        }
    }
}
