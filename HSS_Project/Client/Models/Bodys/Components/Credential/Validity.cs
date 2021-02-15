using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometriaEWebSocket.Classes.Models.Credential_Body
{
    public class Validity
    {
        public DateTime startDateTime { get; set; }
        public DateTime endDateTime { get; set; }

        public Validity(DateTime start, DateTime end)
        {
            startDateTime = start;
            endDateTime = end;
        }

    }
}
