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
        LoginDao loginDao;

        public bool CheckLogin(string email, string password)
        {
            LoginDao loginDao = new LoginDao();
            List<Login> users = loginDao.GetAllLogins();
            bool loginCheck = false;

            // Check for each User in the list<Login> users if their email and password are the same
            foreach (Login user in users)
            {
                if (user.Email == email && user.Password == password)
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
                if (user.Email == email && user.Password == password)
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

        public void AddNewUser(string email, string passwordHash)
        {
            loginDao.AddNewUser(email, passwordHash);
        }
    }
}
