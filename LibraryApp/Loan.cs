using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Loan
    {
        public bool HasManyUnreturnedBooks(Client client, int nr)
        {
            if (client.GetUnreturnedBooks() > nr)
                return true;
            return false;
        }
    }
}
