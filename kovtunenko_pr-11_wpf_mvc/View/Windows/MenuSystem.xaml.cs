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
using System.Windows.Shapes;

namespace KovtunenkoWpfMvc.View.Windows {
    /// <summary>
    /// Логика взаимодействия для MenuSystem.xaml
    /// </summary>
    public partial class MenuSystem : Window {
        public MenuSystem() {
            InitializeComponent();
        }

        private void Frame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e) {

        }

        private void btnUsers_Click(object sender, RoutedEventArgs e) {
            Pages.Users listUsers = new Pages.Users();
            MainFrame.Navigate(listUsers);
        }
    }
}
