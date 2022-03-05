using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashPasswords;

/*
 * @author ChillMouse
 * Copyright <ChillMouse> 2022.
 * В этом модуле проводится UNIT-тестирование функции, которая хеширует байт-массив методом SHA-256.
 */

namespace UnitTestHashFunction {
    internal class Program {
        public static void Main(string[] args) {
            // UNIT тесты.
            GetHashPasswordTest("123", "a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3".ToUpper());
            GetHashPasswordTest("Passw0rdFinTech%123--1", "22add8a8852e0060962900543ad77c4383d38ccd1c1f5178f8290ba329e37009".ToUpper());
            GetHashPasswordTest("i-love-k-pop-lol", "378b380805b64c853c2bdf647f6fb74ef0a4d9a5c23a53896a035ccba6b0dd55".ToUpper());
            Console.Read();  // Нужно, чтобы не закрывалась консоль
        }

        /*
         *  Входящие параметры: две строки. Значение и ожидаемый результат программы.
         *  Выходящие параметры: нет.
         *  Вывод в консоль: информация параметров и результаты тестов.
        */
        public static void GetHashPasswordTest(string testValue, string waitValue) {
            Console.WriteLine("UNIT TEST:\n");
            Console.WriteLine($"Тестовое значение на входе: {testValue}");
            Console.WriteLine($"Ожидаемый результат: {waitValue}");

            string result = Hash.getHashPassword(testValue);

            // Проверка результата
            if (result.Equals(waitValue + "123")) {
                Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
                Console.WriteLine($"\nSUCCESS");
                Console.ResetColor(); // сбрасываем в стандартный
                Console.WriteLine($"\n{result}");
            } else {
                Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                Console.WriteLine($"\n### FAIL ### \n\nПрограмма получила: {result}");
                Console.ResetColor(); // сбрасываем в стандартный
            }
            Console.Write("\n\n");
        }
    }
}
