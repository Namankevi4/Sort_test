using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_lib
{
    class Bubble<T> : IType_of_sorts<T> where T : IComparable<T>
    {
        public IEnumerable<T> sort(IEnumerable<T> mass)
        {
            T[] mass2 = mass.ToArray<T>();
            T temp;
            for (int i = 0; i < mass2.Length - 1; i++)
            {
                for (int j = i + 1; j < mass2.Length; j++)
                {
                    if (mass2[i].CompareTo(mass2[j])>0)
                    {
                        temp = mass2[i];
                        mass2[i] = mass2[j];
                        mass2[j] = temp;
                    }
                }
            }
            return mass2;

                 
        }
    }
}
