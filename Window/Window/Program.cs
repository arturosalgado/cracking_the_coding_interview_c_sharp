using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 4,5,6,1,2,3 };
            int index = SearchRotated.search(a,0,a.Length-1,6);
            Console.WriteLine(index);
            Console.WriteLine(SearchRotated.binary_search(a,0,a.Length-1,6));
            Console.ReadKey();
        }

        public static void mywindow(int [] a , int windowSize) {

            if (a.Length < windowSize) {
                return;
            }

            LinkedList<int> window = new LinkedList<int>();
            for (int i = 0; i < windowSize; i++)
            {
                while (window.Count != 0 && a[i] > a[window.Last()]) {
                    window.RemoveLast();
                }

                window.AddLast(i);

            }
          //  Console.WriteLine("{0}",a[window.First()]);

            for (int i = windowSize; i < a.Length; i++)
            {
                while (window.Count != 0 && a[i] > a[window.Last()])
                {
                    window.RemoveLast();
                }

                if (window.Count > 0 && window.First() <= i -windowSize) {
                    window.RemoveFirst();
                }

                window.AddLast(i);
                Console.WriteLine("{0}", a[window.First()]);
            }

        }
    }
}
