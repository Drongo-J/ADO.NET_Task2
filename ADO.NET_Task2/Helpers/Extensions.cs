using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ADO.NET_Task2.Helpers
{
    public static class DataGridExtension
    {
        public static IEnumerable<FrameworkElement> GetItemsInColumn(this DataGrid dg, int col)
        {
            if (dg.Columns.Count <= col)
                throw new IndexOutOfRangeException("Column " + col + " is out range, the datagrid only contains " + dg.Columns.Count + " columns.");
            foreach (object item in dg.Items)
            {
                yield return dg.Columns[col].GetCellContent(item);
            }
        }
    }
}
