using System;
using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class LoginLogic
    {
        LoginDao loginDao = new LoginDao();

        public bool CheckLogin(string email, string password)
        {
            LoginDao loginDao = new LoginDao();
            List<Login> users = loginDao.GetAllLogins();
            bool loginCheck = false;

            // Check for each User in the list<Login> users if their email and password are the same
            foreach (Login user in users)
            {
                byte[] digestBytes = SetGivenPasswordToHash(password, user);

                if (user.Email == email && user.Password == digestBytes)
                {
                    loginCheck = true;
                }
            }
            return loginCheck;
        }

        public Login GetCurrentUser(string email, string password)
        {
            LoginDao loginDao = new LoginDao();
            List<Login> users = loginDao.GetAllLogins();
            Login currentUser = new Login();

            // Check for each User in the list<Login> users if their email and password are the same
            foreach (Login user in users)
            {
                byte[] digestBytes = SetGivenPasswordToHash(password, user);

                if (user.Email == email && user.Password == digestBytes)
                {
                    currentUser = user;
                }
            }
            return currentUser;
        }
        
        private static byte[] SetGivenPasswordToHash(string password, Login user)
        {
            HashAlgorithm hashAlgo = new SHA256Managed();
            byte[] passwordAsBytes = Encoding.UTF8.GetBytes(password);

            List<byte> passwordWithSaltBytes = new List<byte>();
            passwordWithSaltBytes.AddRange(passwordAsBytes);
            passwordWithSaltBytes.AddRange(user.SaltHash);

            byte[] digestBytes = hashAlgo.ComputeHash(passwordWithSaltBytes.ToArray());
            return digestBytes;
        }
        
        public List<Login> GetAllLogins()
        {
            return loginDao.GetAllLogins();
        }

        public void AddNewUser(string email, byte[] passwordHash, byte[] saltyUser)
        {
            loginDao.AddNewUser(email, passwordHash, saltyUser);
        }
    }
}
