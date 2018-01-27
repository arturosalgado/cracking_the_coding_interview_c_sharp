using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeInterviews
{
    class Programs
    {


        public static void callTree() {

            TreeNode root= buildTree2();


            TreeNode target = root.left.left;

            TreeNode succ1 = TreeNode.findSuccesor(root,target);
            Console.WriteLine(succ1);

           
        }
        public static TreeNode buildTree1() {

            TreeNode root = new TreeNode(5);
            TreeNode left = new TreeNode(7);

            TreeNode n9 = new TreeNode(9);
            TreeNode n7 = new TreeNode(7);
            TreeNode n6 = new TreeNode(6);


            root.left = left;
            root.right = n9;

            n9.left = n7;
            n7.left = n6;

            return root;
        }

        public static TreeNode buildTree2()
        {

            TreeNode n1 = new TreeNode(1);
            TreeNode n2 = new TreeNode(2);

            TreeNode n4 = new TreeNode(4);
            TreeNode n5 = new TreeNode(5);
            TreeNode n7 = new TreeNode(7);

            n5.left = n2;
            n2.left = n1;
            n2.right = n4;

            n5.right = n7;


            
            return n5;
        }


        public static void callDeleteNode()
        {

            int [] nodes = { 1,2,3,4,5,6};
            Node head = Node.createList(nodes);
            Console.WriteLine("Before delete");
            Node.traverse(head);
            Node mid = head.Next.Next;

            DeleteMiddleNode.deleteMiddleNode(mid);
            Console.WriteLine("After delete");
            Node.traverse(head);

        }



        public static void callPalindromeNumber() {


            int number = 5678765;
            bool b =  PalindromeNumber.isPalindrome(number);
            Console.WriteLine("{0},{1}",number,b);


        }
        public static void callPalindromeNumber2(int number)
        {


            //int number = 252;
            bool b = PalindromeNumber.isPalindrome2(number);
            Console.WriteLine("{0},{1}", number, b);


        }


        public static void callKthToLast()
        {

            
            int[] array = { 1, 1, 2, 3, 4, 4, 5, 6, 4, 7 };
            Node list = Node.createList(array);
            Console.Write("List is : \n");
            Node.traverse(list);
            Console.Write(" \n");
            Console.Write("NOded ");

            int k = 3;
            Node found = null;
            int visited = KthToLast.kthToLast2(list,k,out found);
            if (found != null) { 
                Console.Write("Found {0}",found);

            }
            Console.WriteLine();

           


        }



        public static void callRemove()
        {

            //Node list = Node.createList(10);
            //Node.traverse(list);
            //Console.WriteLine();
            int[] array = { 1, 1, 2, 3, 4, 4, 5, 6, 4, 7 };
            Node list2 = Node.createList(array);

            Node.traverse(list2);

            list2 = RemoveDups.remove3(list2);

            Console.WriteLine();

            Node.traverse(list2);


        }

        public static void callIsRotation() {

            string s1 = "watterbottle";
            string s2 = "houes";

            bool  rotation = IsRotation.isRotation(s1,s2);
            Console.Write(" is rotation {0} {1} {2}",s1,s2,rotation);




        }


        public static void callMatrix()
        {
            int[,] m = { { 1,2} ,
                         { 3,4 }};

            int[,] m2 = { { 1,2,3} ,
                          { 4,5,6},
                          { 7,8,9}

                        };


            m = Nullify.createMatrix(5);
            Nullify.PrintMatrix(m);
            Console.WriteLine();
            Nullify.nullify(m);
            Nullify.PrintMatrix(m);

            Console.WriteLine();
           
           
                





            Console.ReadKey();

        }

        public static void call() {
            string s1 = "Papas";
            string s2 = "Pap";
            Console.WriteLine("One edit away {0} {1}",s1,s2);
            Console.WriteLine(OneEditAway.oneEdit(s1,s2));
            Console.ReadKey();

        }
        public static void call2()
        {
            string s1 = "Papas";
            string s2 = "Pap";
            OneEditAway.CheckDiff(s1, s2);
            Console.ReadKey();

        }
        public static void call3()
        {
            string s1 = "Casaaaaaaaaaaaaaaaaaaaaaaaa";

            int compressed = StringCompress.countCompress2(s1);
            int not_compressed = s1.Length;

            if (not_compressed <= compressed)
            {
                Console.WriteLine("No need to  compress");
                Console.Write(s1);
            }
            else {

                Console.Write("We will compress");
                Console.Write(StringCompress.compress(s1, compressed));
            }

            //Console.WriteLine("Lenght {0}", compressed);

        }
        public static void comp()
        {
           Console.Write( Utils.compareStringContent("casa","casa"));
        }

        public static void strings() {

            string[] strings = { "casa","abc","aa","c",""};
            foreach (var s in strings)
            {
                Console.WriteLine(Strings1.duplicateChars(s));
            }


        }

       

    }
}
