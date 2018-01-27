using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeInterviews
{
    class Node
    {
        public int Value;
        public Node Next;
        public Node(int Value)
        {
            this.Value = Value;   
        }
        public override string ToString()
        {
            return this.Value+"->";
        }


        public static Node createList(int n) {

            Node p=null;
            Node head = null ;
            for (int i = 0; i < n; i++) {

                Node node = new Node(i);

                    if (i == 0)
                    {
                        head = node;
                        p = node;
                    }
                    else {
                    p.Next = node;
                   
                    p = p.Next;

                }
            }

            return head;

        }

        public static Node createList(int[] array)
        {

            Node p = null;
            Node head = null;
            for (int i = 0; i < array.Length; i++)
            {

                Node node = new Node(array[i]);

                if (i == 0)
                {
                    head = node;
                    p = node;
                }
                else
                {
                    p.Next = node;

                    p = p.Next;

                }
            }

            return head;

        }

        public static void traverse(Node node) {

            Node p = node;
            while (p != null) {

                Console.Write(p);
                p = p.Next;
            }



        }

    }

    
}
