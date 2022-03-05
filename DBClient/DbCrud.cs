using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbApiCore {
    public static class DbCrud {
        public static int UserInsert(string login, string password, string name, string surname) {
            string connectionString = @"metadata=res://*/Model.ShopModel.csdl|res://*/Model.ShopModel.ssdl|res://*/Model.ShopModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=DESKTOP-PEI2NKM;initial catalog=Shop;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;";
            int result = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = $"INSERT INTO 'Users' ('login', 'password') VALUES ('{login}', '{password}')",
                        Connection = connection
                    };
                    result = cmd.ExecuteNonQuery();
                    connection.Close();
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            }
            Console.Read();
            return result;
        }
    }
}
