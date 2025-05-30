using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class SelectionGenSort : SortStrategy
    {
        Subject subject = new Subject();
        public override void Sort(List<Book> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].GetGen().CompareTo(list[j].GetGen()) > 0)
                        (list[i], list[j]) = (list[j], list[i]);
                }
            }
            subject.NotifyAll(this, EventArgs.Empty);
        }
    }
}
