using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicTree
{
    class Tree
    {

        public Node root = null;

        public Node insert(Node n)
        {


            if (root == null)
            {
                root = n;
                return n;
            }
            else
            {
                //Console.WriteLine("root is "+root);
                //Console.WriteLine("n is " + n);

                _insert(root,n);
            
            }

            return n;
            



        }

        public Node _insert(Node root, Node n)
        {

            if (root == null)
            return n;

            if (root.Value > n.Value)
            {
                if (root.left != null)
                {
                    _insert(root.left,n);
                }
                else{
                    root.left = n;
                }
            }
            else {

                if (root.right != null)
                {
                    _insert(root.right, n);
                }
                else
                {
                    root.right = n;
                }
            }

            return n;
        }


        public void  print()
        {

            Node temp = root;
            int row = 0;
            visit(temp,row);


        }


        public void visit(Node n, int row) {

            if (n == null) return;
            Console.WriteLine("ROW::" + row);
            Console.WriteLine(n);
            row++;
            visit(n.left, row);
            visit(n.right, row);
       
           
        
        }

        public void remove(int value, Node n,  Node parent)
        {

            Console.WriteLine("IN remove to delete [{0}]",value);

            if (n == null)
            {
                Console.WriteLine("Doesn't exist");
                return;
            }
            if (value < n.Value)
            {
                Console.WriteLine("Value is less. value {0} n.Value {1}",value,n.Value);
                remove(value, n.left,n);
            }
            else if (value > n.Value)
            {
                Console.WriteLine("Value is more. value {0} n.Value {1}", value, n.Value);
                remove(value, n.right,n);
            }
            else {
                Console.WriteLine("Same Value N:"+n);
                if (n.left != null && n.right != null)
                {
                    Console.WriteLine("Has left and Right Children");
                    Node maxLeft = findMax(n.left);
                    Console.WriteLine("Max is "+maxLeft);
                    n.Value = maxLeft.Value;
                    remove(maxLeft.Value,n.left,n);
                }
                else if (n.left != null)
                {
                    Console.WriteLine("Left Child is not null");
                    Node trash = n;
                    n = n.left;
                    trash = null;
                }
                else if (n.right != null)
                {
                    Console.WriteLine("Right child  is not null");
                    Node trash = n;
                    n = n.right;
                    trash = null;
                }
                else {
                    Console.WriteLine("It is null leaf, just make it null n:"+n);
                  
                    parent.left = null;
                }

                
            }





        }


        public Node findMax(Node n)
        {
            if (n.left != null)
               return findMax(n.left);
            else
                return n;

        }


    }
}
