using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbApiCore {
    public static class DbCrud {
        public static int UserInsert(string login, string password, string name, string surname) {
            string connectionString = @"Data Source=DESKTOP-PEI2NKM;Initial Catalog=Shop;Integrated Security=True";
            int rowChanged = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = $"INSERT INTO [Users] (username, password, name, surname) VALUES ('{login}', '{password}', '{name}', '{surname}');",
                        Connection = connection
                    };
                    rowChanged = cmd.ExecuteNonQuery();
                    connection.Close();
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            }
            return Convert.ToInt32(rowChanged > 0);
        }
    }
}
