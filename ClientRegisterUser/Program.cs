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
            string login, password, name, surname;
            Console.Write("Введите логин: ");
            login = Console.ReadLine();
            Console.Write("Введите пароль: ");
            password = Console.ReadLine();
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            surname = Console.ReadLine();

            // Console.WriteLine($"{login}, {password} => {Hash.GetHashPassword(password)}");

            password = Hash.GetHashPassword(password);

            int result = DbCrud.UserInsert(login, password, name, surname);

            if (result == 1) {
                Console.WriteLine($"Хэш пароля: {password}\nРегистрация нового пользователя проведена успешно");
            } else {
                Console.WriteLine("Регистрация провалена");
            }

            Console.Read();
        }
    }
}
