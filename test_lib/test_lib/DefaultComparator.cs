using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_lib
{
    class DefaultComparator<T> : IComparer<T> where T : IComparable
    {
        public int Compare(T first, T second)
        {
            return first.CompareTo(second);
        }
    }
}
