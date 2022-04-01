using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        private static void TestPasswordHasher()
        {
            PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();
            HashWithSalt hashResultSha256 = pwHasher.HashWithSalt("ultra_safe_P455w0rD", 64, SHA256.Create());
            HashWithSalt hashResultSha512 = pwHasher.HashWithSalt("ultra_safe_P455w0rD", 64, SHA512.Create());
            HashWithSalt unHashedResultSha256 = pwHasher.HashWithSalt("ultra_safe_P455w0rD", 64, SHA256.Create());

            Console.WriteLine(hashResultSha256.Salt);
            Console.WriteLine(hashResultSha256.Digest);
            Console.WriteLine();
            Console.WriteLine(hashResultSha512.Salt);
            Console.WriteLine(hashResultSha512.Digest);
        }
    }
}
