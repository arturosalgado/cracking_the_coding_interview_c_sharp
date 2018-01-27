using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            List<int> mylist = new List<int>();

            for (int i = 0; i < 100; i++) {
                mylist.Add(r.Next(0,100));
            }

            foreach (var e in mylist) {
                Console.WriteLine(e);
            }

            int[] a = mylist.ToArray();
            // selection sort 
            for (int i = 0; i < a.Length; i++) {

                for (int k = i + 1; k < a.Length; k++)// continue to 1
                {
                    if (a[k] < a[i]) {
                        swap(a, k, i);
                    }
                }
            }
            Console.Write("sorted :" );
            Console.WriteLine(string.Join(",",a));
            Console.ReadKey();

        }

        static void swap(int[] a, int i, int j) {

            int t = a[i];
            a[i] = a[j];
            a[j] = t; 
        }
    }
}
