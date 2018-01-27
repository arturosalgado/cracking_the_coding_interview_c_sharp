using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeInterviews
{
    class Utils
    {

        public static void switchme(int[] a, int x, int y)
        {
            int t = a[x];
            a[x] = a[y];
            a[y] = t;
        }
        public static void print_r(int[] a,bool vert=false)
        {
            foreach (var i in a) {
                if (vert)
                Console.Write(i + " ");
                else
                Console.WriteLine(i + " ");
            }
        }

        public static void print_c(char[] a)
        {
            foreach (var i in a)
            {
                Console.Write(i + " ");
            }
        }

        public static void print_m(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {

                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0}  ", a[i, j]);
                }

                Console.Write(" \n");
            }
        }

        public static bool compareStringContent(string s1,string s2)
        {
            return s1 == s2;

        }

    }
}
