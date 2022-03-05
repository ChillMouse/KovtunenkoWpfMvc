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

namespace ClientRegisterUser
{
    internal class Program
    {
        public static void Main()
        {
            Console.Write("Регистрация нового пользователя\n\n");

            string login, password, name, surname;
            int result;

            Console.Write("Введите логин: ");
            login = Console.ReadLine();
            Console.Write("Введите пароль: ");
            password = Console.ReadLine();
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            surname = Console.ReadLine();

            password = Hash.GetHashPassword(password);

            // Проверка на пустые значения
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(name) &&
                !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(surname)) {
                result = DbCrud.UserInsert(login, password, name, surname);

            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Запрещено вводить пустые значения");
                Console.ResetColor();
                result = 0;
            }

            if (result == 1) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Хэш пароля: {password}\nРегистрация нового пользователя проведена успешно");
                    Console.ResetColor();
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Регистрация провалена");
                Console.ResetColor();
            }
            Console.Read();
            }
        }
    }
