using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometriaEWebSocket.Classes.Models.Bodys.Components.Credential_Holder
{
    public class Key
    {
        public string organizationId { get; set; }
        public Guid userId { get; set; }

        public Key(string id, string org)
        {
            userId = new Guid(id);
            organizationId = org;
        }


    }
}
