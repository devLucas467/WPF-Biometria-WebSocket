using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometriaEWebSocket.Classes.Models.Credential_Body
{
    public class Indentifiers
    {
        public string recognitionType { get; set; }
        public string identifierFormat { get; set; }
        public string hexValue { get; set; }
        public bool exemptedFromAuthentication { get; set; }
    }
}

