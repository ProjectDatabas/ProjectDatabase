using System;
using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenLogic
{
    public class LoginLogic
    {
        LoginDao loginDao;

        public bool CheckLogin(string email, string password)
        {
            // Check if email and password are correct
            return email == "admin@inholland.nl" && password == "admin";
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
