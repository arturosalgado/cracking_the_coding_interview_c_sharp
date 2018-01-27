using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeLists
{
    class Program
    {
        static void Main(string[] args)
        {

            int []a = {10,9,8,3,1,-10,-15,-20,-25,-30,-35};

            int []b = {20,15,4,2,-1 ,-2,-3};

            int[] c = merge(a,b);

            Console.WriteLine("a is ");
            print(a);
            Console.WriteLine("b is ");
            print(b);
            Console.WriteLine("c is ");
            print(c);

            Console.ReadKey();


        }


        static int[] merge(int []a, int []b )
        {

            int[] c= new int[18];

            int indexA = 0;
            int indexB = 0;
            int indexC = -1;
            while (indexA < a.Length && indexB < b.Length)
            {

                int topA = a[indexA];
                int topB = b[indexB];

                if (topA > topB)
                {
                    c[++indexC] = topA;
                    indexA++;
                   
                }
                else {
                    c[++indexC] = topB;
                    indexB++;
                }
                
            }

            Console.WriteLine("index b is {0}",indexB);

            if (indexA < a.Length )
            {
                for (int k = indexA; k < a.Length ; k++)
                {
                    c[++indexC] = a[k];
                }
            }
            if (indexB < b.Length )
            {
                
                for (int k = indexB; k < b.Length ; k++)
                {
                    c[++indexC] = b[k];
                }
            }


            return c;
        }

        static void print(int[] a)
        {

            foreach (int x in a)
            {
                Console.Write("[{0:D2}] ", x);

            }
            Console.WriteLine();

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("|{0:D2}| ", i);
            }
            Console.WriteLine();

        }


    }
}
