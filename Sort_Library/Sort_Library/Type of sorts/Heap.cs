using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Library.Type_of_sorts
{
    public class Heap<T> : IType_of_sorts<T> where T : IComparable
    {
        public IList<T> sort(IList<T> mass2)
        {
            for (int i = mass2.Count() / 2 - 1; i >= 0; i--)
            {
                ShiftDown(mass2, i, mass2.Count());
            }
            for (int i = mass2.Count() - 1; i >= 1; i--)
            {
                T temp = mass2[0];
                mass2[0] = mass2[i];
                mass2[i] = temp;

                ShiftDown(mass2, 0, i);
            }
            return mass2;
        }
        private void ShiftDown(IList<T> mass2, int i, int j)
        {
            bool done = false;

            while ((i * 2 + 1 < j) && (!done))
            {
                int maxChild;

                if (i * 2 + 1 == j - 1)
                {
                    maxChild = i * 2 + 1;
                }
                else if (mass2[i * 2 + 1].CompareTo(mass2[i * 2 + 2]) == 1)
                {
                    maxChild = i * 2 + 1;
                }
                else
                {
                    maxChild = i * 2 + 2;
                }
                if (mass2[i].CompareTo(mass2[maxChild]) == -1)
                {
                    T temp = mass2[i];
                    mass2[i] = mass2[maxChild];
                    mass2[maxChild] = temp;
                    i = maxChild;
                }
                else
                {
                    done = true;
                }
            }
        }
    }
}
