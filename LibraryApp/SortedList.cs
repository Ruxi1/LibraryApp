using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class SortedList : List<Book>
    {
        private List<Book> list = new List<Book>();
        private SortStrategy sortstrategy;

        public void SetSortStrategy(SortStrategy sortstrategy)
        {
            this.sortstrategy = sortstrategy;
        }

        public void Add(Book book)
        {

            list.Add(new Book(book.GetTitle(), book.GetAuthor(), book.GetGen(), book.GetAvailable()));
        }
        public void Sort()
        {
            sortstrategy.Sort(list);
        }
        public DataTable PopulateTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Titlu");
            table.Columns.Add("Autor");
            table.Columns.Add("Gen");
            table.Columns.Add("Disponibilitate");
            for (int i = 0; i < list.Count; i++)
            {
                table.Rows.Add(list[i].GetTitle(), list[i].GetAuthor(), list[i].GetGen(), Convert.ToString(list[i].GetAvailable()));
            }
            return table;
        }

    }
}
