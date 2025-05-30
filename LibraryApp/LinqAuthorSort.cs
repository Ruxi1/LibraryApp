using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class LinqAuthorSort : SortStrategy
    {
        Subject subject = new Subject();
        public override void Sort(List<Book> list)
        {
            var newlist = list.OrderBy(x => x.GetAuthor()).ThenBy(x => x.GetTitle()).ToList();
            list.Clear();
            for (int i = 0; i < newlist.Count; i++)
            {

                list.Add(newlist[i]);
            }
            subject.NotifyAll(this, EventArgs.Empty);
        }
    }
}
