using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class LinkedList1
    {
        public Node head = null;

        public  Node insertHead(int value)
        {

            Node node = new Node(value);
            node.Next = head;
            head = node;

            return head;
        }

        public Node insert(int[] arr) {

            foreach (var i in arr) {
                insertLast(i);
            }
            return this.head;
        }

        public Node insertLast(int value)
        {

            Node node = new Node(value);
            Node temp = head;
            if (head == null) {
                head = node;
                return head;
            }

            while ( temp.Next != null) {
                temp = temp.Next;
            }
            temp.Next = node;

            return head;
        }

        public void removeFirst() {

            head = head.Next;

        }

        public void removeLast()
        {
            Node temp = head;
            Node back = null;
            while (temp.Next!=null) {
                back = temp;
                temp = temp.Next;

            }
            back.Next = null;
        }

        public override string ToString()
        {
            Node h = this.head;
            String output = "";
            while (h != null) {

                output+= h+" ";
                h = h.Next;
            }
            return output;
        }



    }
}
