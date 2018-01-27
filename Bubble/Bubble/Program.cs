using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 6,5,4};
            bubble(a);
            Console.WriteLine(string.Join(",",a));
            Console.ReadKey();
        }

        static void bubble(int[] a) {

            for (int k = a.Length-1; k>=0;k--)
            {
                for (int i = 0; i < k; i++)
                {
                    if (a[i] > a[i + 1])
                        swap(a, i, i + 1);
                }
            }

        }

        static void swap(int[]a , int i, int j) {

            int t = a[i];
            a[i] = a[j];
            a[j] = t;

        }


    }
}
