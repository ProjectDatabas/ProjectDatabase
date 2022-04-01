using System;
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
            string query = "SELECT UserID, LoginEmail, PasswordHash, IsAdmin FROM User";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Login> ReadTables(DataTable dataTable)
        {
            List<Login> logins = new List<Login>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Login login = new Login()
                {
                    UserId = (int)dr["UserID"],
                    Email = (string)dr["LoginEmail"],
                    Password = (string)dr["PasswordHash"],
                    AdminStatus = (bool)dr["IsAdmin"]
                };
                logins.Add(login);
            }
            return logins;
        }


        public void AddNewUser(string email, string passwordHash)
        {
            foreach (Login L in GetAllLogins())
            {
                if (email == L.Email)
                {
                    throw new Exception("User already exists");
                }
            }

            string query = "INSERT INTO User(LoginEmail, IsAdmin, PasswordHash, SaltyUser) VALUES(@LoginEmail, @IsAdmin, @PasswordHash, @SaltyUser); ";

            SqlParameter[] sqlParameters = { new SqlParameter("@LoginEmail", SqlDbType.NVarChar) { Value = email },
                                             new SqlParameter("@IsAdmin", SqlDbType.Bit) { Value = false },
                                             new SqlParameter("@PasswordHash", SqlDbType.NVarChar) { Value = passwordHash },
                                             new SqlParameter("@SaltyUser", SqlDbType.NVarChar) { Value = saltyUser } };

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
