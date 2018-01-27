using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class Programs
    {
        public static void callListOfStacks() {

            ListOfStacks stack = new ListOfStacks(2);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);
            stack.Push(10);
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();

        }
        public static void callNodeDetectLoopStart()
        {

            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);


            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n5;
            n5.Next = n6;
            n6.Next = n4;

            Node n = DetectLoopStartInCycle.detect(n1);
            Console.WriteLine("Detect loop starts at {0}",n);
            //NodeFactory.print(n);






        }

        public static void callNodeIntersection() {

            Node n1 = new Node(5);
            Node m1 = new Node(10);
            Node m2 = new Node(15);
            Node m3 = new Node(20);

            n1.Next = m3;
            m1.Next = m2;
            m2.Next = m3;

            Node list1 = n1;
            Node list2 = m1;


            Node intersection = NodeIntersection.find(list1,list2);

            NodeFactory.print(intersection);



        }

        public static void callIsPalindrome()
        {
            int[] a = { 1, 2, 3,2,1, };
            Node head = NodeFactory.createList(a);
            NodeFactory.print(head);
            bool result = IsLinkedListPalindromeIterative.isPalindrome(head);
            Console.WriteLine("is palindrome returned {0}",result);
        }
        public static void callFastLow() {
            int[] a = { 1, 2, 3};
            Node head = NodeFactory.createList(a);
            NodeFactory.print(head);
            SlowFastRunner.Run(head);

        }
        public static void callPartition() {

            Node n = NodeFactory.createUnsortedList();
            NodeFactory.print(n);
            Node t = PartitionLinkedList.partition(n,2);
            NodeFactory.print(t);
        }


        public static void callArrayHighLowIndex() {

            int[] a = { 1,2,5,5,5,5,5,6};
            int low = ArrayLowHighIndex.find_low(a,5);
            Console.WriteLine("low is {0}",low);

        }

        public static void callRotateArray()
        {

            int []a = {1,2,3,4,5,6 };
            Utils.print_r(a);
            a = RotateArray.rotate(a,9);
            Utils.print_r(a);

        }
        public static void callTestReverse() {

            Tests.testReverse();

        }
        public static void callPartitionPivot()
        {
            int[] a = { 4,6,7,5,1,2,3};
            int []r = PartitionAroundPivot.partition2(a,0,a.Length-1);
            Console.WriteLine(string.Join(",",r));

        }
        public static void callFindMinimum() {

            int[] a = { -1,0,1,2,3,4,5,5,6,6};
            int[] b = { 2,3,4,5,6,7,8,9};

            int smallest = SmallestCommonNumberInArrays.common(a,b);

            Console.WriteLine(smallest);

        }
        public static void callSlidingWindow() {
            Console.WriteLine("calling sliding window..");
            int[] a = { -4,2,-5,1,-1,6};
            //int a[] = { -4, 2, -5, 1, -1, 6 };
            int windowSize = 3;
            FindMaxSlidingWindow.find(a, windowSize);
        }
        public static void callTestLinkedList() {
            TestLinkedList.testLinkedList();
        }

        public static void callSearchRotated()
        {
            int [] a = { 1,2,3,4,5,6,6,6};
            int r = SearchRotatedArray.searchRotated(a,0,a.Length-1,6);
            Console.WriteLine("search rotated result {0}",r);

        }

            public static void callRotateMatrix()
        {
            int[,] m = Utils.generateRadomIntMatrix(4);
            Utils.printMatrix(m);
            int[,] k = MatrixRotation.rotate(m);
            Console.WriteLine("rotated");
            Utils.printMatrix(k);

            int[,] n = Utils.generateRadomIntMatrix(5);
            Utils.printMatrix(n);
            n =  MatrixRotation.rotate(n);
            Console.WriteLine("rotated");
            Utils.printMatrix(n);
        }


        public static void callCompress() {

            string compressed = CompressString.Compress2("aaabbbbc");
            Console.WriteLine(compressed);
        }

        public static void callTestSort()
        {
            int[] nums = { 5,4,3,2,1};
            nums = Tests.BubbleSort(nums, nums.Length);
            Console.WriteLine(string.Join(",",nums));
        }
        public static void callTest()
        {
            Tests.test1();
        }
        public static void callUrilify()
        {

            //string s = Urilify.urilify("el sol");
            string s = Urilify.urilify2("el sol");
            Console.WriteLine(s);
        }
        public static void callReverseString() {

            string s = ReverseSentence.reverseSentence("el sol");
            Console.WriteLine(s);
        }

        public static void callGraph()
        {
            Graph graph = new Graph(20);
            graph.addVertex("cs1");
            graph.addVertex("cs2");
            graph.addVertex("ds");
            graph.addVertex("os");
            graph.addVertex("alg");
            graph.addVertex("AL");

            graph.addEdge(0,1);
            graph.addEdge(1,2);
            graph.addEdge(1,5);
            graph.addEdge(2,3);
            graph.addEdge(2,4);

            graph.dsf();


           // graph.deleteVertex(3);
        }

        public static void callLinkedList()
        {

            int[] a = { 1,2,3,4,5,6,7,8,9};
            LinkedList1 l1 = new LinkedList1();
            l1.insert(a);
            Console.WriteLine(l1);

        }
        public static void callTestList() {

            Lists.testList();

        }

        public static void callIsRotation() {

            string s1 = "casa";
            string s2 = "saca";
            Console.WriteLine(  StringRotation.isRotation(s1,s2));


        }

        public static void callRemoveDups() {

            Node head = NodeFactory.createListDups();
            NodeFactory.traverseList(head);
           
            RemoveDups.deleteDups(head);
            NodeFactory.traverseList(head);
        }

    }
}
