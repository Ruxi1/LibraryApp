using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Visitor
    {
        private string Name;
        private string Email;
        public Visitor(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public string GetName()
        { return Name; }
        public string GetEmail()
        { return Email; }
        public Client IsClient(List<Client> clients)
        {
            return clients.FirstOrDefault(x => x.GetName() == this.Name && x.GetEmail() == this.Email);
        }
    }
}
