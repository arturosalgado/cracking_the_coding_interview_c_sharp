using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class TestLinkedList
    {

        public static void testLinkedList() {

            LinkedList<int> linkedlist = new LinkedList<int>();

            linkedlist.AddFirst(5);
            print(linkedlist);
            linkedlist.AddFirst(6);
            linkedlist.AddFirst(7);
            print(linkedlist);
            linkedlist.RemoveFirst();
            print(linkedlist,"remove first");
            linkedlist.RemoveLast();
            print(linkedlist,"remove last");
            linkedlist.AddFirst(9);
            int last = linkedlist.Last();
            print(linkedlist, "peeked last "+last);
            int first = linkedlist.First();
            print(linkedlist, "peeked first " + first);
        }

        public static void print(LinkedList<int> list,string message="") {

            if (message.Length>0)
                Console.WriteLine(message);
            Console.WriteLine(string.Join(",",list.ToArray()));

        }


    }
}
