using ADO.NET_Task2.Commands;
using ADO.NET_Task2.Helpers;
using ADO.NET_Task2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ADO.NET_Task2.ViewModels
{
    public class AddAuthorViewModel : BaseViewModel
    {
        public RelayCommand AddAuthorCommand { get; set; }

        private string firstname = String.Empty;

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; OnPropertyChanged(); }
        }

        private string lastname = String.Empty;

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; OnPropertyChanged(); }
        }

        public AddAuthorViewModel()
        {
            AddAuthorCommand = new RelayCommand((a) =>
            {
                if (Firstname.Trim() == string.Empty)
                {
                    MessageBox.Show("Please, add author firstname!");
                    return;
                }
                if (Lastname.Trim() == string.Empty)
                {
                    MessageBox.Show("Please, add author lastname!", "Warning!");
                    return;
                }

                var author = new Author()
                {
                    FirstName = this.Firstname,
                    LastName = this.Lastname,
                    Id = GetID()
                };
                DatabaseHelper.AddAuthorToDatabase(author);
                DatabaseHelper.GetAuthorsFromDb();
                //(App.Current.MainWindow.DataContext as MainWindowViewModel).AddAuthorsToView(DatabaseHelper.GetAuthorsFromDb());
                App.ChildWindow.Close();
                App.ChildWindow = null;
            });
        }

        private string GetID()
        {
            var list = App.AuthorsDataGrid.GetItemsInColumn(0).ToList();

            int _id = 0;

            foreach (var item in list)
            {
                string text = (item as TextBlock).Text;
                if (!string.IsNullOrEmpty(text))
                {
                    var id = int.Parse(text);
                    if (id > _id)
                    {
                        _id = id;
                    }
                }
            }
            ++_id;
            return _id.ToString();
        }
    }
}
