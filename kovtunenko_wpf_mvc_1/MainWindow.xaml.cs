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

namespace kovtunenko_wpf_mvc_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {
            InitializeComponent();
        }
        private void btnAuth_Click(object sender, RoutedEventArgs e) {
            View.MenuSystem windowMenuSystem = new View.MenuSystem();
            windowMenuSystem.Show();
        }

        private void btnAuthorizationMessageBox(object sender, RoutedEventArgs e) {
            Button btnAuthorization = sender as Button;
            if (btnAuthorization != null) {
                MessageBox.Show($"Нажата кнопка \"{btnAuthorization.Content}\"");
            }
        }
    }

}
