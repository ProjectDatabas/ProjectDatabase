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
        public byte[] Password { get; set; }
        public bool UserStatus { get; set; }
        public byte[] SaltHash { get; }

        public Login(int userId, string email, byte[] password, bool adminStatus, byte[] saltHash)
        {
            UserId = userId;
            Email = email;
            Password = password;
            AdminStatus = adminStatus;
            SaltHash = saltHash;
        }

        public Login()
        {
            
        }
    }
}
