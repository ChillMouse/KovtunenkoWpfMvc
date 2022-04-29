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
    /// Логика взаимодействия для TableOfProducts.xaml
    /// </summary>
    public partial class TableOfProducts : Page {
        public TableOfProducts() {
            InitializeComponent();
            LoadData();
        }
        public void LoadData() {
            Model.ShopEntities db = new Model.ShopEntities();
            var prods = db.Products.ToList();
            gridProducts.ItemsSource = prods;
        }
    }
}
