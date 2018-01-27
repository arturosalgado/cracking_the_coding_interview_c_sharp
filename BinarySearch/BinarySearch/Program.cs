using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int[] list = { 2,3,4,7,8,14, 21,44,45,54,87};

            print(list);
            int lookfor = 87;

            if (binarySearch(lookfor, list, 0, list.Length - 1) == -1)
                Console.WriteLine("key not fount");

            Console.ReadKey();
        }


        public static int binarySearch(int key, int[] list, int lo, int hi)
        {
            //search for key from list[lo] to list[hi]
            //if found, return its location; otherwise, return -1
            while (lo <= hi)
            {
                Console.WriteLine("Lo [{0}]  hi [{1}]", lo,hi);
                int mid = lo + (hi-lo) / 2;
                Console.WriteLine("Mid index  is [{0}] with value {1}",mid,list[mid]);
                Console.ReadKey();
                if (key == list[mid]){ 
                    Console.WriteLine("KEy FOUND");
                    return mid;
                } // found
                if (key < list[mid])
                {

                    hi = mid - 1;
                    Console.WriteLine("Key is lower ");

                }
                else { 
                    
                    lo = mid + 1;
                    Console.WriteLine("Key is higher ");
                }
            }
            return -1; //lo and hi have crossed; key not found
        }

        public static void print(int []a)
        {
            foreach(int x in a)
            {
                Console.Write("[{0}] ",x);
            }
            Console.WriteLine("");
        }
    }
}
