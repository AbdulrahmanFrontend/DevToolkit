using DevToolkit.Security.Hasing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Security.PasswordHashing
{
    public class PasswordHasher
    {
        public static string HashPassword(string password) => HashingServices.Hash(password);

        public static bool VerifyPassword(string password, string savedHash) 
            => HashPassword(password) == savedHash;
    }
}
