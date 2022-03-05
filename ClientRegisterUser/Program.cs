using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashPasswords;
using DbApiCore;
using System.Configuration;
/// <summary>
/// Copyright ChillMouse 2022
/// Клиент, который выполняет регистрацию пользователя
/// </summary>

namespace ClientRegisterUser {
    internal class Program {
        public static void Main() {
            string login, password;
            Console.Write("Введите логин: ");
            login = Console.ReadLine();
            Console.Write("Введите пароль: ");
            password = Console.ReadLine();
            Console.WriteLine($"{login}, {password} => {Hash.GetHashPassword(password)}");

            password = Hash.GetHashPassword(password);

            int result = DbCrud.UserInsert(login, password, "", "");
            Console.WriteLine(result);

            Console.Read();
        }
    }
}
