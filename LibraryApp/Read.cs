using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public class Read
    {
        public static List<string> ReadFromFile(string fisier)
        {
            try
            {
                return File.ReadAllLines(fisier).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

        }
        public static Book ParseBook(string line)
        {
            Book book = null;

            try
            {
                var values = line.Split(',');
                var title = values[0];
                var author = values[1];
                var gen = values[2];
                var available = Convert.ToBoolean(values[3]);
                book = new Book(title, author, gen, available);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return book;
        }

        public static Client ParseClient(string line)
        {
            Client client = null;

            try
            {
                var values = line.Split(',');
                var name = values[0];
                var email = values[1];
                var subscription = Convert.ToBoolean(values[2]);
                var unreturnedBooks = Convert.ToInt16(values[3]);
                client = new Client(name, email, subscription, unreturnedBooks);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return client;
        }
    }
}
