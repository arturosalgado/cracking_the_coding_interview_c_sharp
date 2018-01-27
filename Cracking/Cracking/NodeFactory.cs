using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class NodeFactory
    {

        public static Node createList() {

            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);

            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n5;

            return n1;
        }

        public static Node createList(int [] a)
        {
            Node head = null;
            Node tail = null;
            
            for (int i = 0; i<a.Length; i++) {
                Node n = new Node(a[i]);
                if (head == null)
                {
                    head = n;
                    tail = n;
                }
                else {
                    tail.Next = n;
                    tail = n;
                }

            }
            return head;
        }

        public static Node createUnsortedList()
        {

            Node n1 = new Node(3);
            Node n2 = new Node(4);
            Node n3 = new Node(5);
            Node n4 = new Node(1);
            Node n5 = new Node(0);

            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n5;

            return n1;
        }
        public static Node createListDups()
        {

            Node n1 = new Node(1);
            Node n2 = new Node(1);
            Node n3 = new Node(1);
            Node n4 = new Node(4);
            Node n5 = new Node(5);

            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n5;

            return n1;
        }

        public static void traverseList(Node head) {

            Node n = head;

            while (n != null) {

                Console.Write(n);
                n = n.Next;
            }
            Console.WriteLine();

        }

        public static void print(Node head)
        {

            Node n = head;

            while (n != null)
            {

                Console.Write(n);
                n = n.Next;
            }
            Console.WriteLine();

        }

    }
}
