using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometriaEWebSocket.Classes.Models.Credential_Body
{
    public class CredentialHolder
    {
        public CredentialHolderKey key { get; set; }
        public CredentialHolder(Guid userId)
        {
            key = new CredentialHolderKey(userId);
        }
    }
}
