using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShiftElements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a = { 4, 8, 50,7, 3, 6, 2, 1,10,8,20,0,0,0 };
            print(a);

            int position = 2;
            int val = 88;

            for (int k = a.Length - 2; k >= position; k--)
            {
                Console.WriteLine("K is [{0}]",k); Console.ReadKey();
                Console.WriteLine("K +1  is [{0}]", k + 1); Console.ReadKey();
                Console.WriteLine("a[K ] is [{0}]", a[k]); Console.ReadKey();
                Console.WriteLine("a[K +1] is [{0}]", a[k + 1]); Console.ReadKey();

                a[k + 1] = a[k];
                print(a);
            }
            a[position] = val;
            print(a);

                Console.ReadKey();
                Console.ReadKey();
                Console.ReadKey();
        }
        static void print(int []a)
        {
            
            foreach(int x in a ){
                Console.Write("[{0:D2}] ",x);
            
            }
            Console.WriteLine();

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("|{0:D2}| ", i);  
            }
            Console.WriteLine("");
            Console.WriteLine("");


        }


    }
}
