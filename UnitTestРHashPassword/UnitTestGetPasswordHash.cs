using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HashPasswords;

/// <summary>
/// Copyright ChillMouse 2022.
/// Проведение UNIT-тестов для правильности хэширования пароля
/// </summary>

namespace UnitTestHashPassword {
    [TestClass]
    public class UnitTestInputHashPassword {
        
        [TestMethod]
        public void TestEmptyPassword() {
            Assert.AreEqual("", Hash.GetHashPassword(""), "GetHashPassword: хеш пустой строки должен быть пустым.");
        }
        
        [TestMethod]
        public void TestIntegerPassword() {
            Assert.AreEqual("a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3".ToUpper(), Hash.GetHashPassword("123"), "TestIntegerPassword: 123 => error. \"123\" было неверно хешировано.");
        }
        
        [TestMethod]
        public void TestStrOnePassword() {
            Assert.AreEqual("22add8a8852e0060962900543ad77c4383d38ccd1c1f5178f8290ba329e37009".ToUpper(), Hash.GetHashPassword("Passw0rdFinTech%123--1"), "TestStrOnePassword: Passw0rdFinTech%123--1 => error. \"Passw0rdFinTech%123--1\" было неверно хешировано.");
        }

        [TestMethod]
        public void TestStrTwoPassword() {
            Assert.AreEqual("378b380805b64c853c2bdf647f6fb74ef0a4d9a5c23a53896a035ccba6b0dd55".ToUpper(), Hash.GetHashPassword("i-love-k-pop-lol"), "TestStrTwoPassword: i-love-k-pop-lol => error. \"i-love-k-pop-lol\" было неверно хешировано.");
        }


    }
}
