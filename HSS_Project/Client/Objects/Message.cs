using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Objects
{
    public class Message
    {
        public string command { get; set; }
        public string correlationId { get; set; }
        public string instruction { get; set; }

    }
}
