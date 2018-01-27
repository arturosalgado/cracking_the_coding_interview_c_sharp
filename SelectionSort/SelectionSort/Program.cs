using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a = { 5,-40,3,1,-10,255,8,47};
            print(a);
            selectionSort(a);
            print(a);
            Console.ReadKey();
        }

        public static void selectionSort(int []a)
        {
            int smallest = 0;
            int position = 0;
            for (int i = 0; i < a.Length; i++)
            {
                smallest = getSmallest(a,i,a.Length-1,out position);
                Console.WriteLine("Found smallest {0} at position {1}",smallest,position);
                Console.WriteLine("Swaping {0} with {1}", smallest, a[i]);
                swapMe(a, i, position);
                print(a);
                Console.WriteLine();
                Console.ReadKey();
            }
        
        }
            

        public static void swapMe(int[] a, int pos, int dest)
        { 
            int temp = a[pos];
            a[pos] = a[dest];
            a[dest] = temp;
        }
        public static int getSmallest(int[] a, int leftWall, int rightWall, out int position)
        {
            int min = a[leftWall];
            position = leftWall;
            for (int i = leftWall; i <= rightWall; i++)
            {
                if (a[i] < min)
                { 
                    min = a[i];
                    position = i;
                }

            }

            return min;
        }

        static void print(int []a)
        {
            foreach (int x in a)
            {
                Console.Write(" ["+x+"]");

            }
            Console.WriteLine();
        }
    }
}
