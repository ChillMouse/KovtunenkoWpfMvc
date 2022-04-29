using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HashPasswords;

/// <summary>
/// Автор ChillMouse
/// </summary>

namespace KovtunenkoWpfMvc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {
            this.InitializeComponent();
        }
        /// <summary>
        /// Отслеживания нажатия на кнопку "Авторизация".
        /// Происходит отображение нового окна.
        /// </summary>
        /// <param name="sender">Объект инициатора вызова</param>
        /// <param name="e"></param>
        private void AuthInApp(object sender, RoutedEventArgs e) {
            string login = txtBoxLogin.Text;
            string password = txtBoxPassword.Password;
            string targetWindow = "";
            responseLabel.Content = "Вход...";

            string userRole = UserSelect(login, password);

            switch (userRole) {
                case "user":
                    targetWindow = "user";
                    break;
                case "admin":
                    targetWindow = "admin";
                    break;
            }

            switch (targetWindow) {
                case "user":
                    responseLabel.Content = "Успешно";
                    Window uw = new View.UserWindow();
                    uw.Show();
                    break;
                case "admin":
                    responseLabel.Content = "Успешно";
                    Window aw = new View.AdminWindow();
                    aw.Show();
                    break;
                default:
                    responseLabel.Content = "Такого пользователя нет";
                    Console.WriteLine("Целевое окно перехода после авторизации не задано.");
                    break;
            }
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
    }

}
