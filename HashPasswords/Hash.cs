using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace HashPasswords
{
    public class Hash
    {
        public static string getHashPassword (string password) {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytePassword = Encoding.UTF8.GetBytes(password);
                byte[] hashBytePassword = sha256.ComputeHash(bytePassword);
                string hashPassword = BitConverter.ToString(hashBytePassword).Replace("-", String.Empty);
                return hashPassword;
            }
        }
    }
}
