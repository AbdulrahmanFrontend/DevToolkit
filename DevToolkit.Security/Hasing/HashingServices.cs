using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Security.Hasing
{
    public class HashingServices
    {
        public static string Hash(string input)
        {
            using (SHA256 sHA256 = SHA256.Create())
            {
                Byte[] hashBytes = sHA256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
    }
}
