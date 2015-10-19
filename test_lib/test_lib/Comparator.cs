using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_lib
{
    class Comparator<T> : IComparer<T> where T : UserType
    {
        public int Compare(T first, T second)
        {
            return first.IntValue.CompareTo(second.IntValue);
        }
    }
}
