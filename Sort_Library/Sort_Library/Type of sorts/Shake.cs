using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Library.Type_of_sorts
{
    public class Shake<T> : IType_of_sorts<T>
    {
        public IList<T> sort(IList<T> mass2, IComparer<T> comparator)
        {

            for (int i = 0; i < mass2.Count() / 2; i++)
            {
                int beg = 0;
                int end = mass2.Count() - 1;

                do
                {
                    if (comparator.Compare(mass2[beg], mass2[beg + 1]) == 1)
                    {
                        Swap(mass2, beg, beg + 1);
                    }
                    beg++;

                    if (comparator.Compare(mass2[end - 1], mass2[end]) == 1)
                    {
                        Swap(mass2, end - 1, end);
                    }
                    end--;

                } while (beg <= end);
            }
            return mass2;
        }
        private void Swap(IList<T> collection, int i, int j)
        {
            T item = collection[i];
            collection[i] = collection[j];
            collection[j] = item;
        }
    }
}
