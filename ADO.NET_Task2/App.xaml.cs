using ADO.NET_Task2.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ADO.NET_Task2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Window ChildWindow { get; internal set; }
        public static DataGrid AuthorsDataGrid { get; internal set; }
    }
}
