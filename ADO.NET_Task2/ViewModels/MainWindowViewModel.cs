using ADO.NET_Task2.Commands;
using ADO.NET_Task2.Helpers;
using ADO.NET_Task2.Models;
using ADO.NET_Task2.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ADO.NET_Task2.ViewModels
{
    internal class MainWindowViewModel : BaseViewModel
    {
        public RelayCommand DeleteCommmand { get; set; }
        public RelayCommand RefreshCommand { get; set; }
        public RelayCommand AddAuthorCommand { get; set; }
        public RelayCommand SaveChangesCommand { get; set; }

        public MainWindowViewModel()
        {
            AddAuthorCommand = new RelayCommand((a) =>
            {
                var addWindow = new AddAuthorWindow();
                var addWindowViewModel = new AddAuthorViewModel();
                addWindow.DataContext = addWindowViewModel;
                App.ChildWindow = addWindow;
                addWindow.Show();
            });

            RefreshCommand = new RelayCommand((r) =>
            {
                DatabaseHelper.GetAuthorsFromDb();
                MessageBox.Show(App.Current.MainWindow, "Successfully refreshed!", "Success!", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.RightAlign);
            });

            DeleteCommmand = new RelayCommand((d) =>
            {
                if (App.AuthorsDataGrid.Items[0] is NoResultFoundUC)
                    return;

                var IDs = new List<string>();
                if (App.AuthorsDataGrid.Items.Count != 1)
                {
                    foreach (var item in App.AuthorsDataGrid.SelectedItems)
                    {
                        DataRowView myRow = (DataRowView)item;
                        //string myvalue = Convert.ToInt32(myRow);
                        var id = myRow.Row.ItemArray[0].ToString().Trim();
                        IDs.Add(id);
                    }
                }
                if (IDs.Count == 0)
                {
                    MessageBox.Show(App.Current.MainWindow, "Please, check author!", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK, MessageBoxOptions.RightAlign);
                    return;
                }
                DatabaseHelper.DeleteAuthorsByID(IDs);
                DatabaseHelper.GetAuthorsFromDb();
            });

            SaveChangesCommand = new RelayCommand((s) =>
            {
                //SqlCommand command = new SqlCommand("SELECT * FROM Authors", DatabaseHelper.conn);
                //DatabaseHelper.da.Update(DatabaseHelper.set,"Authors");
                //DatabaseHelper.da.SelectCommand = command;
                //DatabaseHelper.set.Clear();
                //DatabaseHelper.da.Fill(DatabaseHelper.set,"Authors");

                DatabaseHelper.SaveChangesToDatabase();
            });
        }
    }
}
