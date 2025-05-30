using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class Form1 : Form
    {
        public List<Book> books = new List<Book>();
        public SortedList sbooks = new SortedList();
        public Form1()
        {
            InitializeComponent();
            var lines = Read.ReadFromFile("BookData.txt");
            books = lines.Select(x => Read.ParseBook(x)).Where(x => x != null).ToList();
            PopulateDataGridView(books);

            foreach (Book book in books)
                sbooks.Add(book);

        }

        private void PopulateDataGridView(List<Book> books)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Titlu");
            table.Columns.Add("Autor");
            table.Columns.Add("Gen");
            table.Columns.Add("Disponibilitate");
            for (int i = 0; i < books.Count; i++)
            {
                table.Rows.Add(books[i].GetTitle(), books[i].GetAuthor(), books[i].GetGen(), Convert.ToString(books[i].GetAvailable()));
            }
            dataGridView1.DataSource = table;
        }

        

        private void btnTitlu_Click(object sender, EventArgs e)
        {
            sbooks.SetSortStrategy(new QuickTitleSort());
            sbooks.Sort();
            dataGridView1.DataSource = sbooks.PopulateTable();
        }


        private void btnEligible_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btnAutor_Click_1(object sender, EventArgs e)
        {
            sbooks.SetSortStrategy(new LinqAuthorSort());
            sbooks.Sort();
            dataGridView1.DataSource = sbooks.PopulateTable();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            sbooks.SetSortStrategy(new SelectionGenSort());
            sbooks.Sort();
            dataGridView1.DataSource = sbooks.PopulateTable();
        }
    }
}
