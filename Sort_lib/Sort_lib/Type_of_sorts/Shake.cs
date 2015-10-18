using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_lib
{
    class Shake<T> : IType_of_sorts<T> where T : IComparable<T>
    {
        public IEnumerable<T> sort(IEnumerable<T> mass)
        {
            T[] mass2 = mass.ToArray<T>();
            for (int i = 0; i < mass2.Count() / 2; i++)
            {
                int beg = 0;
                int end = mass2.Count() - 1;

                do
                {
                    if (mass2[beg].CompareTo(mass2[beg + 1]) == 1)
                    {
                        Swap(mass2, beg, beg + 1);
                    }
                    beg++;

                    if (mass2[end - 1].CompareTo(mass2[end]) == 1)
                    {
                        Swap(mass2, end - 1, end);
                    }
                    end--;

                } while (beg <= end);
            }
            return mass2;
        }
        private void Swap(T[] collection, int i, int j)
        {
            T item = collection[i];
            collection[i] = collection[j];
            collection[j] = item;
        }
        
        }

    }

