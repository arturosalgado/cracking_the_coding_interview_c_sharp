using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CyclicList
{
    class Program
    {
        static void Main(string[] args)
        {

            Node a = new Node() { Value = 5};
            Node b = new Node() { Value = 10 };
            Node c = new Node() { Value = 15 };
            Node d = new Node() { Value = 20 };
            Node e = new Node() { Value = 25 };
            Node f = new Node() { Value = 30 };
            Node g = new Node() { Value = 35 };
            Node h = new Node() { Value = 40 };
            Node i = new Node() { Value = 45 };
            Node j = new Node() { Value = 50 };
            Node k = new Node() { Value = 55 };
            Node l = new Node() { Value = 60 };
            
            a.Next = b;

            b.Next = c;

            c.Next = d;

            d.Next = e;

            e.Next = f;

            f.Next = g;

            g.Next = h;

            h.Next = i;
            i.Next = j;
            j.Next = k;
            k.Next = l;
            l.Next = a;





            Console.WriteLine("List is Cyclic ? "+isCyclic(a));
           
        }

        public static bool isCyclic(Node head)
        {
            Node q;
            Node p; 

            p = head;
            q = head.Next;
            

            while (true)
            {
                Console.WriteLine("P is in " + p.Value);
                Console.WriteLine("Q is in " + q.Value);
                Console.ReadKey();



                if (q == null || q.Next == null)
                    return false;

                if (p == q || p == q.Next)
                {
                    Console.WriteLine("P--- is in " + p.Value);
                    Console.WriteLine("Q---- is in " + q.Value);
                    Console.ReadKey();

                    return true; // it is the same , even when q was ahead
                }
                else
                {
                    p = p.Next;
                    q = q.Next.Next;
                }
            }


            
        }


    }
}
