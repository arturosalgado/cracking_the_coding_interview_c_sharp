using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class TreeFactory
    {

        public static TreeNode createTree() {

            TreeNode n1 = new TreeNode(1);
            TreeNode n2 = new TreeNode(2);
            TreeNode n3 = new TreeNode(3);
            TreeNode n4 = new TreeNode(4);
            TreeNode n5 = new TreeNode(5);
            TreeNode n6 = new TreeNode(6);


            n1.left = n2;
            n1.right = n3;

            n3.left = n4;
            n3.right = n5;

            n2.left = n6;
            
            return n1;
        }

        public static void print(TreeNode root) {

            if (root == null) {
                return;
            }

            print(root.left);
            Console.WriteLine("{0}",root.value);
            print(root.right);
            
        }
    
    }
}
