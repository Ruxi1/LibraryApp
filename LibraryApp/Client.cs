using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Client
    {
        private string name;
        private string email;
        private bool subscription;
        private int unreturnedBooks;

        public Client(string name, string email, bool subscription, int unreturnedBooks)
        {
            this.name = name;
            this.email = email;
            this.subscription = subscription;
            this.unreturnedBooks = unreturnedBooks;
        }

        public string GetName()
        { return name; }
        public string GetEmail()
        { return email; }
        public bool GetSubscription()
        { return subscription; }
        public int GetUnreturnedBooks()
        { return unreturnedBooks; }
    }
}
