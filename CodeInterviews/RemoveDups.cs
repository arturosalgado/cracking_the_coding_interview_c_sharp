using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeInterviews
{
    class RemoveDups
    {
        public static Node remove(Node node)
        {

            HashSet<int> hash = new HashSet<int>();
            Node h = node;
            Node p = node;
            while (h != null)
            {

                if (!hash.Contains(h.Value))
                {
                    hash.Add(h.Value);
                }



                h = h.Next;
            }


            Node newNode = null;
            Node q = null;
            for (int i = 0; i < hash.Count; i++)
            {
                Node m = new Node(hash.ElementAt(i));
                if (i == 0)
                {
                    newNode = m;
                    q = m;
                }
                else
                {
                    q.Next = m;
                    q = q.Next;

                }

            }

            return newNode;

        }
        public static Node remove2(Node node)
        {
            HashSet<int> hash = new HashSet<int>();

            Node newNode = node;
            Node p = node;
            Node q = node;

            while (p != null ) {
               // Console.Write("p is "+p);
                if (!hash.Contains(p.Value))
                {
                    hash.Add(p.Value);
                    q = p;
                }
                else {

                    q.Next = p.Next; // pierde un nodo
                }
                p = p.Next;
            }


           
            return newNode;

        }

        /*no hash set, then it 
         * is like a nested loop, instead of arrays this is with nodes
         */
        public static Node remove3(Node node)
        {
            Node head = node;
            Node n = node;
            Node m = node;

            while (n != null) {
                Console.Write(n);
                
                m = n;
                while (m.Next!= null) {
                    if (m.Next.Value == n.Value)
                    {

                        m.Next = m.Next.Next;
                    }
                    else {

                        m = m.Next;
                    }
                }

                n = n.Next;

            }
            return head;
        }


    }
}
