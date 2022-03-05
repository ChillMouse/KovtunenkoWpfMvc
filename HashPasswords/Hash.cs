using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace HashPasswords {
    public class Hash {
        /// <summary>
        /// Эта функция хэширует передаваемую строку в качестве аргумента методом SHA-256 и возвращает хэш.
        /// </summary>
        /// <example>
        /// Например:
        /// <code>
        /// GetHashPassword("123);
        /// </code>
        /// в результате функция вернёт нам строку вида: "A23H899SDF787S7DF87DF..."
        /// </example>
        /// <param name="password">Строка, пароль пользователя</param>
        /// <returns>Хэшированную строку, пароль пользователя</returns>
        public static string GetHashPassword (string password) {
            using (SHA256 sha256 = SHA256.Create()) {
                byte[] bytePassword = Encoding.UTF8.GetBytes(password);
                byte[] hashBytePassword = sha256.ComputeHash(bytePassword);
                string hashPassword = BitConverter.ToString(hashBytePassword).Replace("-", string.Empty);
                return hashPassword;
            }
        }
    }
}
