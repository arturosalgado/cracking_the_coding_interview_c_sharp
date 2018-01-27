using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class PartitionLinkedList
    {


        public static Node partition(Node node, int x) {

            Node head = node;
            Node tail = node;

            while (node != null) {
                Node next = node.Next;// save the next 
                if (node.Value < x)
                {
                    node.Next = head;
                    head = node;
                }
                else {
                    tail.Next = node;
                    tail = node;
                }
                node = next;
            }
            tail.Next = null;//tail may be pointing somewhere and we need to point it to null

            return head;

        }


    }
}
