using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThreeHeight
{
    class Program
    {
        static void Main(string[] args)
        {


            Node root = createTree3();

            Console.WriteLine("Tree height is "+treeHeight(root));
            Console.ReadKey();
        }


        public static int treeHeight(Node n)
        {
            if (n == null)
            {
                Console.WriteLine("NULL node found");
                Console.ReadKey();

                return 0;
            }
            Console.WriteLine("I am in NOde "+n.Value);
            Console.ReadKey();

            var left = treeHeight(n.left);
            var right = treeHeight(n.right);

            Console.WriteLine("Left is "+left);
            Console.WriteLine("Right is " + right);

            Console.ReadKey();

            var temp = Math.Max(left,right); 

            Console.WriteLine ("temp is "+temp);
            Console.ReadKey();

            return 1 + temp;

           
        }


        public static Node createTree()
        {
            Node Root = new Node("Root");

            Node a = new Node("a");
            Node b = new Node("b");

            Node c = new Node("c");
            Node d = new Node("d");

            Root.left = a;
            Root.right = b;

            b.right = c;

            c.right = d;



            return Root;
            
        }
        public static Node createTree3()
        {
            Node Root = new Node("Root");

            Node a = new Node("a");
            Node b = new Node("b");

            Node c = new Node("c");
           
            Root.left = a;
            Root.right = b;

            b.right = c;

           



            return Root;

        }

        public static Node createTree1()
        {
            Node Root = new Node("Root");




            return Root;

        }


        public static Node createTree2()
        {
            Node Root = new Node("Root");

            Node a = new Node("a");
         
         
            Root.left = a;
        

      


            return Root;

        }


    }
}
