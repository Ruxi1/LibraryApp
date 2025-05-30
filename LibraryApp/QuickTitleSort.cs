using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class QuickTitleSort : SortStrategy
    {
        Subject subject = new Subject();
        public override void Sort(List<Book> list)
        {

            Sort(list, 0, list.Count - 1);
            subject.NotifyAll(this, EventArgs.Empty);
        }

        private static void Sort(List<Book> list, int left, int right)
        {
            int lhold = left;
            int rhold = right;
            var random = new Random();
            int pivot = random.Next(left, right);
            Swap(list, pivot, left);
            pivot = left;
            left++;
            while (right >= left)
            {
                int compareleft = list[left].GetTitle().CompareTo(list[pivot].GetTitle());
                int compareright = list[right].GetTitle().CompareTo(list[pivot].GetTitle());
                if ((compareleft >= 0) && (compareright < 0))
                {
                    Swap(list, left, right);
                }
                else
                {
                    if (compareleft >= 0)
                    {
                        right--;
                    }
                    else
                    {
                        if (compareright < 0)
                        {
                            left++;
                        }
                        else
                        {
                            right--;
                            left++;
                        }
                    }
                }
            }
            Swap(list, pivot, right);
            pivot = right;
            if (pivot > lhold) Sort(list, lhold, pivot);
            if (rhold > pivot + 1) Sort(list, pivot + 1, rhold);
        }

        private static void Swap(List<Book> list, int left, int right)
        {

            (list[left], list[right]) = (list[right], list[left]);
        }
    }

}
