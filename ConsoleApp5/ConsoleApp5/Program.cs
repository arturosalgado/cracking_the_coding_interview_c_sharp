using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            Node head = build();
            print(head);
            head = changeLinkedList(head);
            print(head);
            Console.ReadKey();
        }

        static Node changeLinkedList(Node head)
        {
            HashSet<Node> hash = new HashSet<Node>();
            int n = 0; 
            while (head != null)
            {

                hash.Add(head);
                head = head.next;
                n++;
            }
            Node head2 = null ;
            Node glue = null;
            for (int i = 0; i < n-1; i++) {

                

                Node x = hash.ElementAt(i);
              
                Node y = hash.ElementAt(i + 1);

                if (glue != null)
                    glue.next = y;
                y.next = x;
                if (i == 0) {
                    head2 = y;
                }
                glue = x;



            }
            return head2;
        }

        static void print(Node head) {
            Node t = head;
            while (t != null) {
                Console.Write("{0} ",t);
                t = t.next;
            }

        }
        static Node build() {

            Node na = new Node('a');
            Node nb = new Node('b');
            Node nc = new Node('c');
            Node nd = new Node('d');

            na.next = nb;
            nb.next = nc;
            nc.next = nd;
            return na;
        }

    }

    class Node {
        public char val;
        public Node next = null;
        public Node(char val) {

            this.val = val;
        }

        public override string ToString()
        {
            return this.val.ToString();
        }
    }
}
