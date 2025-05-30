using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class EligibleToLoan
    {
        Client client;
        Subscription subscription = new Subscription();
        Loan loan = new Loan();

        public bool IsEligibleToLoan(Visitor visitor, List<Client> clients)
        {
            bool eligible = true;
            client = visitor.IsClient(clients);
            if (client == null)
                eligible = false;
            else if (!subscription.IsSubscribed(client))
                eligible = false;
            else if (loan.HasManyUnreturnedBooks(client, 2))
                eligible = false;
            return eligible;
        }

    }
}
