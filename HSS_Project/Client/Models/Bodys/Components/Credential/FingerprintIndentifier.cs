using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometriaEWebSocket.Classes.Models.Credential_Body
{
    public class FingerprintIndentifier:Indentifiers
    {
        public bool duress { get; set; }
        public string finger { get; set; }
        public TemplateExpireAge templateExpiryAge { get; set; }
    }

    public class TemplateExpireAge
    {
        public string unitOfTime { get; set; }
        public int value { get; set; }
        public TemplateExpireAge(string s, int i)
        {
            unitOfTime = s;
            value = i;
        }
    }
}
