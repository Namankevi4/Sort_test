using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sort_Library;
using Sort_Library.Type_of_sorts;
using System.Diagnostics;
namespace test_lib
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = new List<double>();
            Random random = new Random();
            for (int i = 0; i < 10000; i++)
            {
                list.Add(random.NextDouble());
            }
    
            SortList(list, new Heap<double>(), new DefaultComparator<double>());
            SortList(list, new Shake<double>(), new DefaultComparator<double>());
            SortList(list, new Bubble<double>(), new DefaultComparator<double>());
        }

        static void SortList<T>(List<T> list, IType_of_sorts<T> sortable, IComparer<T> comp )
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            sortable.sort(list, comp);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine(sortable.GetType().Name + " RunTime " + elapsedTime + "\n");
        }
            
            

           
    }      
    }

