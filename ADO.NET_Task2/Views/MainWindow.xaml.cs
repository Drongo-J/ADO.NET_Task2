using ADO.NET_Task2.Helpers;
using ADO.NET_Task2.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace ADO.NET_Task2.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var mainWindowViewModel = new MainWindowViewModel();
            App.AuthorsDataGrid = AuthorsDataGrid;
            DatabaseHelper.cs = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            DatabaseHelper.GetAuthorsFromDb();
            this.DataContext = mainWindowViewModel;
        }
    }
}
