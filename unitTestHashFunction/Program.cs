using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashPasswords;

/// <summary>
/// Copyright < ChillMouse > 2022.
/// В этом модуле проводится UNIT-тестирование функции, которая хеширует байт-массив методом SHA-256.
/// </summary>

namespace UnitTestHashFunction {
    internal class Program {
        public static void Main() {
            // UNIT тесты.
            GetHashPasswordTest("123", "a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3".ToUpper());
            GetHashPasswordTest("Passw0rdFinTech%123--1", "22add8a8852e0060962900543ad77c4383d38ccd1c1f5178f8290ba329e37009".ToUpper());
            GetHashPasswordTest("i-love-k-pop-lol", "378b380805b64c853c2bdf647f6fb74ef0a4d9a5c23a53896a035ccba6b0dd55".ToUpper());
            GetHashPasswordTest("", "".ToUpper());
            Console.Read();  // Нужно, чтобы не закрывалась консоль
        }
        /// <summary>
        /// Проводит тестирование функции на основе значения и ожидаемого результата
        /// </summary>
        /// <param name="testValue">Строка, которую нужно хэшировать</param>
        /// <param name="waitValue">Ожидаемый результат программы</param>
        public static void GetHashPasswordTest(string testValue, string waitValue) {
            string result = Hash.GetHashPassword(testValue);

            // Информация
            Console.WriteLine("UNIT TEST:\n");
            Console.WriteLine($"Тестовое значение на входе:    {testValue}");
            Console.WriteLine($"Ожидаемый результат:           {waitValue}");
            Console.WriteLine($"Выходное значение:             {result}");

            // Проверка результата
            if (result.Equals(waitValue)) {
                Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
                Console.WriteLine($"\nSUCCESS");
                Console.ResetColor(); // сбрасываем в стандартный
            } else {
                Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                Console.WriteLine($"\n### FAIL ###");
                Console.ResetColor(); // сбрасываем в стандартный
            }

            Console.Write("\n\n");
        }
    }
}
