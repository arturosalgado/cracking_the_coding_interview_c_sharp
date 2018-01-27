using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = build();
            print(head);
            head = reversepairs(head);
            Console.WriteLine();
            print(head);
            Console.ReadKey();
        }

        static Node reversepairs(Node head) {

            Node t = head;
            Node p = head;
            Node q = head;
            Node new_head = null;
          
            while (p != null && p.next != null) {

                q = p.next;
                t = q.next;
                q.next = p;
                p.next = t;
                if (new_head == null) {
                    new_head = q;
                }
                p = p.next.next;

            }

            return head;
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
        static Node print(Node head)
        {


            Node currNode = head;
          

            while (currNode != null)
            {
                Console.Write(currNode.value+" ");
                currNode = currNode.next;

            }
           
            return null;


        }
        static Node reverse(Node head){
           
            
                Node currNode = head;
                Node nextNode = null;
                Node prevNode = null;

                while (currNode != null)
                {
                    nextNode = currNode.next;
                    currNode.next = prevNode;
                    prevNode = currNode;
                    currNode = nextNode;
                    
                }
                head = prevNode;
                return head;
            

        }
        
    }

    class Node {
        public Node next; 
        public char value;
        public Node(char value) {

            this.value = value;
        }

    }
}
