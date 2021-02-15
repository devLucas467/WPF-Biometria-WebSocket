using BiometriaEWebSocket.Classes.Models.Credential_Body;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometriaEWebSocket.Classes.Models
{
    public class CredentialBody
    {
        public string name { get; set; }
        public Validity validity { get; set; }

        public CredentialHolder credentialHolder { get; set; }

        public List<Indentifiers> credentialIdentifiers { get; set; }
        public DomainKey domainKey;
        public DateTime version { get; set; }

    }
}
