using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Library.Type_of_sorts
{
    public class Bubble<T> : IType_of_sorts<T>
    {
        public IList<T> sort(IList<T> mass2, IComparer<T> comparator)
        {
            T temp;
            for (int i = 0; i < mass2.Count - 1; i++)
            {
                for (int j = i + 1; j < mass2.Count; j++)
                {
                    if (comparator.Compare(mass2[i] ,mass2[j]) > 0)
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
