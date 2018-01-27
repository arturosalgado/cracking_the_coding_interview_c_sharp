using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class Utils
    {
        public static void swap(int [] a, int i , int j) {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }

        public static int[,] generateRadomIntMatrix(int size)
        {
            int[,] matrix = new int[size,size];
            Random r = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = r.Next(0,9);
                }
            }
            return matrix;
        }

        public static void printMatrix(int[,] matrix)
        {

            int size = matrix.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);    
                }
                Console.WriteLine();
            }
            
        }

        public static void Reverse(int [] a, int i, int j) {

            while (i < j) {

                swap(a, i, j);
                i++;
                j--;

            }


        }

        public static void print_r(int [] a) {
            Console.WriteLine(string.Join(",",a));
        }

    }
}
