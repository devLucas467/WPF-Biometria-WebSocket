using BiometriaEWebSocket.Classes.Models.Bodys.Components.Credential_Holder;
using BiometriaEWebSocket.Classes.Models.Credential_Body;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometriaEWebSocket.Classes.Models.Bodys
{
    public class CredentialHolderBody
    {
        public string name { get; set; }
        public User user { get; set; }
        public Validity validity { get; set; }
        public bool extendedGrantTime { get; set; }
        public DomainKey domainKey { get; set; }

        public CredentialHolderBody(string n, string id)
        {
            name = n;
            user = new User(id, "00000000-0000-0000-0000-000000000001-org");
            domainKey = new DomainKey("00000000-0000-0000-0000-000000000001");
            validity = new Validity(DateTime.Parse("2017-12-30T10:15:30+01:00"), DateTime.Parse("2020-12-30T10:15:30+01:00"));
            extendedGrantTime = false;
        }

    }
}
