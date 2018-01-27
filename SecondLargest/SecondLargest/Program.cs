using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLargest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1,2,3,4,5};
            Console.WriteLine(find(a));
            Console.ReadKey();
        }

        static int find(int[] a) {
            int second = -1;
            int largest = -1;

            foreach (var current in a) {
                if (largest == -1)
                {
                    largest = current;
                }
                else if (current > largest)
                {

                    second = largest;
                    largest = current;
                }
                else if (second == -1)
                {
                    second = current;

                }
                else if (current > second) {
                    second = current;
                }
            }

            return second;
        }
    }
}
