using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicTree
{
    class Program
    {
        static void Main(string[] args)
        {

            Tree t = buildTree();
            Console.WriteLine("Original Tree");
            t.print();
            int remove = 6;
            t.remove(remove,t.root,null);
            Console.WriteLine("After Remove");
            t.print();
            Console.ReadKey();
        }


        public static Tree buildTree()
        {
            Tree t = new Tree();
            t.insert(new Node(4));
            t.insert(new Node(2));
            t.insert(new Node(1));
            t.insert(new Node(3));
            t.insert(new Node(6));
            t.insert(new Node(5));
            t.insert(new Node(7));
            t.insert(new Node(8));
            return t;
            
        }



    }
}
