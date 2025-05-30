using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Book
    {
        private string title;
        private string author;
        private string gen;
        private bool available;

        public Book(string title, string author, string gen, bool available)
        {
            this.title = title;
            this.author = author;
            this.gen = gen;
            this.available = available;
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetAuthor()
        {
            return author;
        }
        public string GetGen()
        {
            return gen;
        }
        public bool GetAvailable()
        {
            return available;
        }
    }
}
