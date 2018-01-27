using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 60,80,90,28,56,32,1,8,9,5};
            print(a);
            insertionSort(a);
            print(a);
            Console.ReadKey();
            Console.WriteLine("Done....");
            Console.ReadKey();

        }

        static void insertionSort(int []a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int key = a[i];
                Console.WriteLine("Current  Key is {0} at index {1}",key,i);
                int previ = i - 1;
                int prev = a[previ];
                Console.WriteLine("Previous Key is {0} index {1}", prev,previ);
                while (previ >= 0 && key <prev)
                {
                    a[previ + 1] = a[previ];
                    Console.WriteLine("In WHILE a[Previous + 1] = {0} index {1}", a[previ+1],previ+1);
                    Console.WriteLine("In While a[Previous]    =  {0} index {1}", a[previ],previ);
                    Console.WriteLine("---");
                    print(a);
                    Console.WriteLine("-");

                    previ--;
                }
                Console.WriteLine("Out of while and a looks like this Key {0}",key);
                print(a);
                a[previ+1] = key;
                Console.WriteLine("adjusted array ");
                print(a);

                print(a);
                Console.ReadKey();

            }
        }
        static void print(int [] a)
        {
            foreach (int x in a)
            {
                Console.Write("[{0}] ",x);
            }
            Console.WriteLine("");
        }
    }
}
