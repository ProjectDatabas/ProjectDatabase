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
        private const int FourtyThreeChars = 43;
        LoginDao loginDao = new LoginDao();
        PasswordWithSaltHasher pwsh = new PasswordWithSaltHasher();

        public bool CheckLogin(string email, string password)
        {
            LoginDao loginDao = new LoginDao();
            List<Login> users = loginDao.GetAllLogins();
            bool loginCheck = false;

            // Check for each User in the list<Login> users if their email and password are the same
            foreach (Login user in users)
            {
                string filledInPassword = pwsh.PasswordPlusSalt(password, user.Salt);
                // check if the first 43 letters in a string are the same as the password
                int counter = 0;
                for (int i = 0; i < FourtyThreeChars; i++)
                {
                    if (filledInPassword[i] != user.Password[i])
                    {
                        break;
                    } 
                    else
                    {
                        counter++;
                    }
                }
                
                if (user.Email == email && counter == FourtyThreeChars)
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

                string filledInPassword = pwsh.PasswordPlusSalt(password, user.Salt);
                // check if the first 43 letters in a string are the same as the password
                int counter = 0;
                for (int i = 0; i < FourtyThreeChars; i++)
                {
                    if (filledInPassword[i] != user.Password[i])
                    {
                        break;
                    }
                    else
                    {
                        counter++;
                    }
                }

                if (user.Email == email && counter == FourtyThreeChars)
                {
                    currentUser = user;
                }
            }
            return currentUser;
        }
        
        
        public List<Login> GetAllLogins()
        {
            return loginDao.GetAllLogins();
        }

        public void AddNewUser(string email, byte[] passwordHash, string saltyUser)
        {
            loginDao.AddNewUser(email, passwordHash, saltyUser);
        }
    }
}
