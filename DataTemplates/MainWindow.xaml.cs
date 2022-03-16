using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


namespace DataTemplates
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> productList;

        public MainWindow()
        {
            InitializeComponent();

            const string foodImagePath = "Data/grocery.png";
            const string appliancesImagePath = "Data/appliances.png";

            productList = new ObservableCollection<Product>()
            {
                new Product(){Name="Хлеб", Price=36.40, ImagePath=foodImagePath, ProductType=ProductType.Food},
                new Product(){Name="Утюг", Price=3765.99, ImagePath=appliancesImagePath, ProductType=ProductType.Appliances},
                new Product(){Name="Молоко", Price=59.50, ImagePath=foodImagePath, ProductType=ProductType.Food},
                new Product(){Name="Кофемолка", Price=2266.40, ImagePath=appliancesImagePath, ProductType=ProductType.Appliances},
                new Product(){Name="Микроволновка", Price=7788.30, ImagePath=appliancesImagePath, ProductType=ProductType.Appliances},
                new Product(){Name="Яйца", Price=102.40, ImagePath=foodImagePath, ProductType=ProductType.Food},
                new Product(){Name="Чайник", Price=2300.25, ImagePath=appliancesImagePath, ProductType=ProductType.Appliances},
                new Product(){Name="Морковь", Price=77.40, ImagePath=foodImagePath, ProductType=ProductType.Food},
            };
            listBox.ItemsSource = productList;
        }
    }
}
