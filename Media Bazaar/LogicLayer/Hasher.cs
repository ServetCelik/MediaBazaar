using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public static class Hasher
    {/// <summary>
    /// this method hashes given string
    /// </summary>
    /// <param name="passwordAndSalt"></param>
    /// <returns></returns>
        public static string PasswordHasher(string passwordAndSalt)
        {
            StringBuilder Sb = new StringBuilder();

            using (var hash = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(passwordAndSalt));

                foreach (byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }
    }
}
