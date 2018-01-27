using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static Node build() {

            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;

            return n1;

        }

    }

    class Node {

        public Node(int Value) {
            this.Value = Value;
        }
        public int Value;
        public Node next;

        public override string ToString()
        {
            return Value;
        }
    }
}
