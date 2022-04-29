using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbApiCore {
    public static class DbCrud {
        public static int UserInsert(string login, string password, string name, string surname) {
            int result;
            try {
                Model.ShopEntities db = new DbApi.Model.ShopEntities();
                var newUser = new DbApi.Model.Users {
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
