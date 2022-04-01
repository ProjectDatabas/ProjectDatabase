using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Login
    {
        public int UserId { get; }
        public string Email { get; set; }
        public string Password { get; }
        public bool AdminStatus { get; set; }
        public string Salt { get; }

        public Login() { }
        
        public Login(int userId, string email, string password, bool adminStatus, string salt)
        {
            UserId = userId;
            Email = email;
            Password = password;
            AdminStatus = adminStatus;
            Salt = salt;
        }
    }
}
