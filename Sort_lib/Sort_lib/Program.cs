using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Sort_lib
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> e;
            List<int> l = new List<int>();
            l.Add(6);
            l.Add(6);
            l.Add(8);
            l.Add(4);
            
            
            IType_of_sorts<int> bubble_sort = new Bubble<int>();
            e = bubble_sort.sort(l);
            foreach (int d in e)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine();

            IType_of_sorts<int> shake_sort = new Shake<int>();
            e = shake_sort.sort(l);
            foreach (int d in e)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine();

            IType_of_sorts<int> heap_sort = new Shake<int>();
            e = shake_sort.sort(l);
            foreach (int d in e)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine();

        }
    }
}
