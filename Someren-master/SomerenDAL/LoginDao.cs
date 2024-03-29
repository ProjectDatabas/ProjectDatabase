﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class LoginDao : BaseDao
    {
        public List<Login> GetAllLogins()
        {
            string query = "SELECT UserID, LoginEmail, PasswordHash, IsAdmin, SaltyUser FROM [User]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Login> ReadTables(DataTable dataTable)
        {
            List<Login> logins = new List<Login>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int userID = (int)dr["UserID"];
                string loginEmail = (string)dr["LoginEmail"];
                byte[] passwordHashByte = (byte[])dr["PasswordHash"];
                string passwordHash = Convert.ToBase64String(passwordHashByte);
                bool isAdmin = (bool)dr["IsAdmin"];
                string saltyUser = (string)dr["SaltyUser"];

                logins.Add(new Login(userID, loginEmail, passwordHash, isAdmin, saltyUser));
            }
            return logins;
        }


        public void AddNewUser(string email, byte[] passwordHash, string saltyUser)
        {
            //foreach (Login L in GetAllLogins())
            //{
            //    if (email == L.Email)
            //    {
            //        throw new Exception("User already exists");
            //    }
            //}            

            string query = "INSERT INTO [user](LoginEmail, IsAdmin, PasswordHash, SaltyUser) VALUES(@LoginEmail, @IsAdmin, @PasswordHash, @SaltyUser); ";

            SqlParameter[] sqlParameters = { new SqlParameter("@LoginEmail", SqlDbType.NVarChar) { Value = email },
                                             new SqlParameter("@IsAdmin", SqlDbType.Bit) { Value = false },
                                             new SqlParameter("@PasswordHash", SqlDbType.Binary) { Value = passwordHash },
                                             new SqlParameter("@SaltyUser", SqlDbType.NVarChar) { Value = saltyUser } };

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
