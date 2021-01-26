using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometriaEWebSocket.Classes
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool HasCredential { get; set; }

        public User()
        {
            HasCredential = false;
        }
        public override string ToString()
        {
            return FirstName + " "
                   + LastName + " "
                   + Description + " "
                   + Phone + " "
                   + Email + " "
                   + HasCredential;
        }

    }
}
