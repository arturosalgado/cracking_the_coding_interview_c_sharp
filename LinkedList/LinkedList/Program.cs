using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {


            test4();
        }
        static void test4()
        {

            LinkedList l = new LinkedList();
            l.addEnd(new Node() { Value = 1 });
            l.addEnd(new Node() { Value = 2 });
            l.addEnd(new Node() { Value = 3 });
            l.addEnd(new Node() { Value = 4 });
            l.addEnd(new Node() { Value = 5 });
            l.addEnd(new Node() { Value = 6 });
            l.addEnd(new Node() { Value = 7 });
            l.addEnd(new Node() { Value = 8 });
            l.addEnd(new Node() { Value = 9 });
            l.addEnd(new Node() { Value = 10 });
            l.addEnd(new Node() { Value = 11 });
            l.addEnd(new Node() { Value = 12 });

            Console.WriteLine(l.MthToLast(1));


            Console.ReadKey();
        
        }
        static void test2()
        {
            LinkedList l = new LinkedList();
            l.addEnd(new Node() {Value=5 });
            l.addEnd(new Node() { Value = 10 });
            l.addEnd(new Node() { Value = 15 });
            l.addEnd(new Node() { Value = 20 });

            l.print();
            Node a = new Node() { Value=20};
            l.delete(a);
            l.print();

            l.addEnd(new Node() { Value = 100});
            Console.ReadKey();
            l.print();
            Console.ReadKey();

        }
        static void test3()
        {
            LinkedList l = new LinkedList();
            l.addEnd(new Node() { Value = 5 });
            l.addEnd(new Node() { Value = 10 });
            l.addEnd(new Node() { Value = 15 });
            l.addEnd(new Node() { Value = 25 });
            l.addEnd(new Node() { Value = 30 });


           

            l.print();

            Console.WriteLine("Tail is "+ l.Tail());

            l.insertInfrontOf(new Node() { Value=25},20);
            l.print();

            Console.WriteLine("Tail is " + l.Tail());
            Console.ReadKey();

        }

        static void test1() {
            LinkedList l = new LinkedList();


            l.addEnd(new Node() { Value = 5 });
            l.addEnd(new Node() { Value = 10 });
            l.addEnd(new Node() { Value = 15 });
            l.addEnd(new Node() { Value = 20 });
            l.addEnd(new Node() { Value = 100 });

            l.print();

            l.removeLast();
            l.removeLast();
            l.print();

            l.removeFirst();
            l.print();
            l.removeFirst();
            l.print();
            l.addEnd(new Node() { Value = 1000 });

            l.addF(new Node() { Value = 2000 });
            l.addF(new Node() { Value = 500 });
            l.addF(new Node() { Value = 501 });
            l.addEnd(new Node() { Value = 50 });
            l.addEnd(new Node() { Value = 50 });
            l.addEnd(new Node() { Value = 60 });
            l.addEnd(new Node() { Value = 100 });
            l.print();


            /* Console.WriteLine("Enumaration ");
             foreach (var o in l)
             {
                 Node p = (Node)o;
                 Console.WriteLine(o);
                 Console.WriteLine(p.Value);

             }
             */

            l.print();

            Node e = new Node() { Value = 501 };

            l.delete(e);

            l.print();


            Console.ReadKey();
        
        }

    }
}
