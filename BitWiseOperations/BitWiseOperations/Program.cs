using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int test = 2;
            print(test);
            int res = test << 0;
            print(res);
            Console.WriteLine(res);
            Console.ReadKey();
          
        }

        static void print(int a)
        {
            const int size = 8;
            ulong value =(ulong) a;
            char bit;



            //System.Console.Write("Enter an integer: ");
            // Use long.Parse() so as to support negative numbers
            // Assumes unchecked assignment to ulong.
            //value = (ulong)long.Parse(System.Console.ReadLine());
            //Console.WriteLine("Value us " + value);
            // Set initial mask to 100....
           /// Console.WriteLine("UL is {0}: size is {1}", 1UL, size);

            ulong mask = 1UL << size - 1;
            //Console.WriteLine("Mask is [{0}]", mask);


            for (int count = 0; count < size; count++)
            {
                bit = ((mask & value) != 0) ? '1' : '0';
                System.Console.Write(bit);
                // Shift mask one location over to the right
                mask >>= 1;
            }
            System.Console.WriteLine();
            Console.ReadKey();


        }

    }
}
