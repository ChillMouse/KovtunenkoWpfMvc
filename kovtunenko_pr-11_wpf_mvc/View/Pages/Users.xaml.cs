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

namespace KovtunenkoWpfMvc.View.Pages {
    /// <summary>
    /// Логика взаимодействия для Users.xaml
    /// </summary>
    public partial class Users : Page {
        public Users() {
            InitializeComponent();
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e) {
            var db = new Model.ShopEntities();
            var users = db.Users.ToList();
            gridOnPage.ItemsSource = users;
        }
    }
}
