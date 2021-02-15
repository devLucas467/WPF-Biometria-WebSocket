using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometriaEWebSocket.Classes.Models.Credential_Body
{
    public class CredentialHolderKey
    {
        public Guid credentialHolderId { get; set; }
        public string systemId { get; set; }

        public CredentialHolderKey(Guid cardholderID)
        {
            credentialHolderId = cardholderID;
            systemId = "00000000-0000-0000-0000-000000000001";
        }
    }
}
