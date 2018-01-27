using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNegativesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { -2 ,-1}, 
                         { -1 , 6} };

            Console.WriteLine(count(a));
            Console.ReadKey();

        }

        static int count(int[,] a) {

            int c = 0;
            int rows = 0;
            int cols = a.GetLength(1)-1;
            while (cols>=0 && rows<a.GetLength(0)) {

                if (a[rows, cols] < 0)
                {
                    c = c + cols + 1;
                    rows++;
                }
                else {
                    cols--;
                }
            }


            return c;
        }
    }
}
