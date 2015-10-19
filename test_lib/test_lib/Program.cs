using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sort_Library;
using Sort_Library.Type_of_sorts;

namespace test_lib
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            l.Add(2);
            l.Add(3);
            l.Add(7);
            l.Add(1);
            List<string> str = new List<string>() { "acbj", "bgf", "xcv", "ab" };

            List<UserType> ut = new List<UserType>();
            IComparer<UserType> comparator = new Comparator<UserType>();
            IComparer<string> strcomparator = new DefaultComparator<String>();
            

            IType_of_sorts<string> bubble_sort = new Bubble<string>();
            List<string> e = (List<string>)bubble_sort.sort(str, strcomparator);
            foreach (string d in e)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine();

            //IType_of_sorts<string> shake_sort = new Shake<string>();
            //e = (List<string>)bubble_sort.sort(str);
            //foreach (string d in e)
            //{
            //    Console.WriteLine(d);
            //}
            //Console.WriteLine();

            //IType_of_sorts<string> heap_sort = new Heap<string>();
            //e = (List<string>)bubble_sort.sort(str);
            //foreach (string d in e)
            //{
            //    Console.WriteLine(d);
            //}
            //Console.WriteLine();
        }
    }
}
