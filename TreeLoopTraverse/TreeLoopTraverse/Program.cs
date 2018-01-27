using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeLoopTraverse
{
    class Program
    {
        static void Main(string[] args)
        {

            Node root = buildTree();


            traversal(root);
            



        }

        public static void traversal(Node root)
        {

            Stack<Node> stack = new Stack<Node>();

            stack.Push(root);

            while (stack.Count > 0)
            {
                Node curr = stack.Pop();
                Console.WriteLine("STACK:");
                Console.WriteLine(v(stack));
                Console.WriteLine("STACKEND:");

                Console.WriteLine(" printing :: " + curr.Value);
                Node n = curr.right;
                if (n != null) stack.Push(n);
                n = curr.left;
                if (n != null) stack.Push(n);

                Console.WriteLine("STACK:");
                Console.WriteLine(v(stack));
                Console.WriteLine("STACKEND:");

            }


            Console.ReadKey();
        }

        public static void traversal2(Node root)
        {

            Stack<Node> stack = new Stack<Node>();

            stack.Push(root);

            while (stack.Count > 0)
            {

                
                Node curr = stack.Pop();
             

               
                Node n = curr.right;
                if (n != null)
                {
                    stack.Push(n);
                 


                }
                Console.WriteLine(curr.Value);

                n = curr.left;
                if (n != null) stack.Push(n);

                
            }


            Console.ReadKey();
        }


        public static string v(Stack<Node> stack)
        {
            string s = "";    

                foreach (Node n in stack)
                {
                   s += "stack val "+n.Value+ " \n";
                }
        
            return s;
        }
        public static Node buildTree()
        {

            Node n100 = new Node(100);
            Node n50 = new Node(50);
            Node n150 = new Node(150);
            Node n25 = new Node(25);
            Node n75 = new Node(75);
            Node n125 = new Node(125);
            Node n175 = new Node(175);
            Node n110 = new Node(110);

            n100.left = n50;
            n100.right = n150;

            n50.left = n25;
            n50.right = n75;

            n150.left = n125;
            n150.right = n175;

            n125.left = n110;





            return n100;

        
        }
    }
}
