using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeInterviews
{
    public class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public int value;
        public TreeNode(int val) {
            this.value = val;
        }

        public static TreeNode insert(TreeNode root, int val) {

            if (root == null)
            {
                root = new TreeNode(val);
            }
            else {

                if (val < root.value)
                {

                    root.left = insert(root.left, val);

                }
                else {

                    root.right = insert(root.right, val);

                }

            }
            return root;

        }

        public static TreeNode find(TreeNode root, int value)
        {

            if (root == null || root.value == value)
            {
                return root;
            }
            else {
                if (value < root.value)
                    return find(root.left, value);
                else
                    return find(root.right, value);
            }

        }
        public static void traverse(TreeNode root, int level)
        {

            if (root == null) {
                return;
            }
            traverse(root.left, level + 1);
            Console.WriteLine(root.value + " level {0}", level);
            traverse(root.right, level + 1);


        }

        public static TreeNode findParent(TreeNode root, TreeNode target) {

           
            if (root == target) {
                return null;
            }
            while (root.left!=target && root.right!=target) {

                if (target.value < root.value)
                {
                    root = root.left;
                }
                else {
                    root = root.right;
                }

            }
            return root;

        }


        public static TreeNode findSuccesor(TreeNode root, TreeNode target)
        {

            if (target.right != null) {
                return minValue(target.right);
            }

            TreeNode parent = TreeNode.findParent(root,target);
            Console.WriteLine("Parent found is {0}",parent);
            while (parent != null && parent.right == target) {

                target = parent;
                parent = TreeNode.findParent(root,parent);

            }

            return parent;
            
        }

        public static TreeNode minValue(TreeNode root) {

            TreeNode curr = root;
            while(curr.left != null)
            {

                curr = curr.left;
            }
            return curr;

        }

        public static void traverseIterative(TreeNode root,int level)
        {

            while (root!=null) {

                Console.WriteLine("Iter Node {0}, level {1}",root.value,level);
                root = root.right;
                level++;

            }        
        
            

        }

        public override string ToString()
        {
            return value.ToString();
        }



    }



}
