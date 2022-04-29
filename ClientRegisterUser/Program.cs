using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashPasswords;
using System.Configuration;
/// <summary>
/// Copyright ChillMouse 2022
/// Клиент, который выполняет регистрацию пользователя
/// </summary>

namespace ClientRegisterUser
{
    internal class Program {
        public static void Main() {
            Console.Write("Регистрация - 1\nАвторизация - 2\n\nВыберите: ");
            string userChooseMode = Console.ReadLine();
            Console.WriteLine(userChooseMode);

            switch (userChooseMode) {
                case "1":
                    RegisterNewUser();
                    break;
                case "2":
                    AuthorizationUser();
                    break;
                default:
                    Console.WriteLine("Are you really Nigga?");
                    break;
            }
            Console.Read();
        }
        public static int AuthorizationUser() {
            try {
                string login = Console.ReadLine();
                string password = Console.ReadLine();
                Console.WriteLine($"{UserSelect(login, password)}");

            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }
        public static int RegisterNewUser() {
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
                result = UserInsert(login, password, name, surname);

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
            return result;
        }
        public static string UserSelect(string login, string password) {
            string roleUser = "n/a";
            try {
                Model.ShopEntities db = new Model.ShopEntities();

                string hashedPassword = Hash.GetHashPassword(password);

                var findedUser = db.Users.Where(r => r.username == login).Where(r => r.password == hashedPassword);

                if (findedUser != null) {
                    roleUser = findedUser.First().role;
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return roleUser;
        }
        public static int UserInsert(string login, string password, string name, string surname) {
            int result;
            try {
                Model.ShopEntities db = new Model.ShopEntities();
                var newUser = new Model.Users {
                    username = login,
                    password = password,
                    name = name,
                    surname = surname
                };
                db.Users.Add(newUser);
                db.SaveChanges();
                result = 1;
            } catch (Exception e) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ResetColor();
                result = 0;
            }
            return result;
        }
    }
    }
