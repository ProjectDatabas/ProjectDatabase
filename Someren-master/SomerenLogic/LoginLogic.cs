using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class LoginLogic
    {
        public bool CheckLogin(string email, string password)
        {
            // Check if email and password are correct
            return email == "admin@inholland.nl" && password == "admin";
        }
    }
}
