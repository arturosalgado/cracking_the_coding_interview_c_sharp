using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingHackerRank
{
    class AnagramMaker
    {


       


        public static int removals(string a, string b) {

            char[] ca = a.ToCharArray();
            char[] cb = b.ToCharArray();

            Array.Sort(ca);
            Array.Sort(cb);

            a = new string(ca);
            b = new string(cb);

            //Console.WriteLine("Strings sorted a {0}",a);
            //Console.WriteLine("Strings sorted b {0}", b);
            //Console.WriteLine();

           
                return run(a,b);







        }


        

        public static int run(string x, string y) {
            //Console.WriteLine("in run x {0}",x);
            //Console.WriteLine("in run y {0}",y);

            int index_x = 0;
            int index_y = 0;

            int removes = 0 ;


            while (index_x<x.Length && index_y<y.Length) {

                if (x[index_x] == y[index_y])
                {
                    //Console.WriteLine("avanza las dos, iguales");
                    index_x++;
                    index_y++;
                }
                else if (x[index_x] < y[index_y])
                {
                    //Console.WriteLine("avanza x");
                    index_x++;
                    removes++;
                   
                }
                else if (y[index_y] < x[index_x])
                {
                    //Console.WriteLine("avanza y");
                    removes++;
                    index_y++;
                }
                else {
                    //Console.WriteLine("avanza las dos diferentes");
                    index_x++;
                    index_y++;
                    removes += 2;
                }

            }

            while (index_y < y.Length) {
                removes++;
                index_y++;
            }
            while (index_x < x.Length)
            {
                removes++;
                index_x++;
            }

            return removes;
        }

        /*old -----------------*/
        public static int run_old(string x, string y)
        {
            Console.WriteLine("x {0} y  is {1}", x, y);
            char firstchar = x[0];
            Console.WriteLine("First Char {0}", firstchar);
            int startIndex = y.IndexOf(firstchar);

            Console.WriteLine("index of {0}", startIndex);
            int index_x = 0;
            int index_y = 0;

            int removes = 0;
            if (startIndex != -1)
            {
                removes = startIndex;
                index_y = startIndex;

                while (index_y < y.Length && index_x < x.Length)
                {
                    Console.WriteLine("First Loop");
                    if (y[index_y] == x[index_x])
                    {
                        index_y++;
                        index_x++;
                    }
                    else
                    {
                        index_y++;
                        index_x++;
                        removes += 2;
                    }
                }
                while (index_y < y.Length)
                {
                    Console.WriteLine("Second Loop");
                    index_y++;
                    removes++;
                }
                while (index_x < x.Length)
                {
                    Console.WriteLine("third Loop");
                    index_x++;
                    removes++;
                }
            }



            return removes;
        }
        public static int removalsOld(string a, string b)
        {

            char[] ca = a.ToCharArray();
            char[] cb = b.ToCharArray();

            Array.Sort(ca);
            Array.Sort(cb);

            a = new string(ca);
            b = new string(cb);

            Console.WriteLine("Strings sorted a {0}", a);
            Console.WriteLine("Strings sorted b {0}", b);
            Console.WriteLine();






            if (a[0] < b[0])

                return run(b, a);

            else
                return run(a, b);



        }

    }
}
