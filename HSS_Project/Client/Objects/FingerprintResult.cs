using Client.Models.Bodys.Components.Fingerprint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Objects
{
    class FingerprintResult
    {
        public Attributes attributes { get; set; }
        public Result result { get; set; }

        public string command { get; set; }
        public string correlationId { get; set; }

    }
}
