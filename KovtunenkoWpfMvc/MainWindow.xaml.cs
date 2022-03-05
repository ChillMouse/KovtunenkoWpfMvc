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
            View.MenuSystem windowMenuSystem = new View.MenuSystem();
            windowMenuSystem.Show();
        }
/// <summary>
/// Отслеживания нажатия на кнопку "Нажать".
/// Происходит отображение содержимого Content в кнопке.
/// </summary>
/// <param name="sender">Объект инициатора вызова функции</param>
/// <param name="e"></param>
        private void EventClickTest(object sender, RoutedEventArgs e) {
            if (sender is Button btnAuthorization) {
                MessageBox.Show($"Нажата кнопка \"{btnAuthorization.Content}\"");
            }
        }
    }

}
