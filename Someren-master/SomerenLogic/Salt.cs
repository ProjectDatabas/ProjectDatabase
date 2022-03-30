using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    // This code was acquired from here https://dotnetcodr.com/2016/10/17/how-to-hash-passwords-with-a-salt-in-net/
    // Author: "Andras Nemes"
    public class Salt
    {
        public string Salt { get; }
        public string Digest { get; set; }

        public Salt(string salt, string digest)
        {
            Salt = salt;
            Digest = digest;
        }
    }
}
