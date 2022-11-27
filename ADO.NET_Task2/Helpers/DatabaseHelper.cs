using ADO.NET_Task2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ADO.NET_Task2.Helpers
{
    public class DatabaseHelper
    {
        public static SqlConnection conn;
        public static string cs = "";
        public static SqlDataAdapter da;
        public static DataSet set;

        public static List<Author> GetAuthorsFromDb()
        {
            var authors = new List<Author>();
            using (conn = new SqlConnection())
            {
                conn.ConnectionString = cs;
                conn.Open();
                set = new DataSet();
                da = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("SELECT * FROM Authors", conn);

                da.SelectCommand = command;
                da.Fill(set, "Authors");
                App.AuthorsDataGrid.ItemsSource = set.Tables["Authors"].DefaultView;
            }

            return authors;
        }

        public static void DeleteAuthorsByID(List<string> IDs)
        {
            using (conn = new SqlConnection())
            {
                conn.ConnectionString = cs;
                conn.Open();

                string s = IDs.Aggregate((i, j) => i + "," + j).ToString();

                string query = $"DELETE FROM S_Cards WHERE Id_Book IN (SELECT Id FROM Books WHERE Id_Author IN ({s}));" +
                                $"DELETE FROM T_Cards WHERE Id_Book IN (SELECT Id FROM Books WHERE Id_Author IN ({s}));" +
                                $"DELETE FROM Books WHERE Id_Author IN ({s});" +
                                $"DELETE FROM Authors WHERE Id IN ({s});";

                set = new DataSet();
                da = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(query, conn);
                da.DeleteCommand = command;
                da.DeleteCommand.ExecuteNonQuery();
                da.SelectCommand = new SqlCommand("SELECT * FROM Authors", conn);

                set.Clear();
                da.Fill(set, "Authors");
                MessageBox.Show(App.Current.MainWindow, $"{IDs.Count} author(s) deleted successfully!", "Success!", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.RightAlign);
            }
        }

        public static void AddAuthorToDatabase(Author author)
        {
            using (conn = new SqlConnection())
            {
                conn.ConnectionString = cs;
                conn.Open();

                da = new SqlDataAdapter();
                set = new DataSet();

                SqlCommand command = new SqlCommand($"INSERT INTO Authors ([Id], [FirstName], [LastName])" +
                    $"VALUES('{author.Id}','{author.FirstName}','{author.LastName}')", conn);

                da.InsertCommand = command;
                da.InsertCommand.ExecuteNonQuery();
                da.SelectCommand = new SqlCommand("SELECT * FROM Authors", conn);

                set.Clear();
                da.Fill(set, "Authors");
                MessageBox.Show(App.Current.MainWindow, $"Author added successfully!", "Success!", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK, MessageBoxOptions.RightAlign);
            }
        }
    }
}
