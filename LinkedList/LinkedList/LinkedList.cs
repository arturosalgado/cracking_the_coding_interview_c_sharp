using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace LinkedList
{
    class LinkedList : IEnumerable
    {

        Node head = null;
        Node tail = null;


        public void addF(Node n)
        {

           


            Node t = head;
            
            head = n;

            if (tail == null)// the first element 
            {
                tail = head;
                tail.name = "Tail";
            }


            n.Next = t;
            Console.WriteLine("Value inserted Front "+n.Value);
          
             


        }
         
        // to check what element is in the tail 

        public int  Tail()
        {
            if (tail != null)
                return tail.Value;
            else
                return -1;

        }

        public void addEnd(Node n) 
        {
            Console.WriteLine("Inser at the end..."+n.Value);

            if (head == null)
            {
                head = n;
                tail = n;
            }
            else {

                tail.Next = n;
                tail = tail.Next;


            
            }


        }


        public int removeLast()
        {
            Console.WriteLine("Remove Last");

            if (head == tail && head != null) // this is the first 1 element 
            {
            
                head = null;
                tail = null;
                return head.Value;

            }
            else {

                Node temp = head;

                while (temp != null)
                {
                    if (temp.Next == tail) /*If temp.next == tail */
                    {
                        temp.Next = null;
                        tail = temp;
                        
                       // Console.WriteLine("We found the tail"+temp.Value);
                       // break;
                    }
                    temp = temp.Next;

                }

            
            }

            return -1;


        }

        public IEnumerator GetEnumerator()
        { 
            Node t = head; 
            while (t!=null)
            {
                yield return t;
                t = t.Next;
            }

        }

        public void removeFirst()
        {
            Console.WriteLine("Remove First -----> ");

            if (head == tail && head != null) // this is the first 1 element 
            {
                head = null;
                tail = null;

            }
            else {

                head = head.Next;
                     

            }
            
        }

        public void delete(Node n)
        {
            Console.WriteLine("At deletion");
            if (head.Value == n.Value)
            {
             
                    Console.WriteLine("Delete the first element: "+n.Value);
                    head = head.Next;
                    return;

            }
            else
            {
                Node p = head;
                Node q = head.Next;

              


                while(q!=null)
                {
                    if (q.Value == n.Value)
                    {
                        Console.WriteLine("Found "+n.Value);
                        p.Next = q.Next;
                        q = p.Next;

                        if (p.Next == null)  /*is it the last element? don't lose your reference to the tail*/
                        {
                            tail = p;
                        }
                        return;
                    }
                        p = q;
                        q = q.Next;
                }


            }

        }

        public void insertInfrontOf(Node n, int Value)
        {
            Node newNode = new Node() { Value = Value};

            Console.WriteLine("At insertInfrontOf "+newNode.Value );

            if (head.Value == n.Value)  /*insert at the beginning of the list */
            {
                Console.WriteLine("First Element");

                newNode.Next = head;
                head = newNode;


               

                return;

            }

            Node q;
            Node p; // again use p and q to search/traverse the list 

            p = head;
            q = head.Next;

            while (q != null)
            {
                if (q.Value == n.Value)
                {
                    Console.WriteLine("Found " + n.Value);
                    p.Next = newNode;
                    newNode.Next = q;

                
                    return;
                }
                p = q;
                q = q.Next;
            }



        }

        /*
         advance the nth elements with the for loop , then when the disntace is OK, move the front runner one step ahead
         * and the back runner on step ahead, and so on. -
         */
        public int MthToLast(int m)
        {

            Node t = head;
            Node mBehind; 
            for (int i = 0; i < m; i++)
            {
                t = t.Next;
                if (t.Next == null)
                {
                    return -1; //just a code to let the user now , the measure is greater that the linked list. 
                }
            }

            mBehind = head;

            while(t.Next != null)
            {
                t = t.Next;
                mBehind = mBehind.Next;
            }


            return mBehind.Value;

        }
        public void print()
        {
            Console.WriteLine("Printing -----> ");
            Node t = head;
            while (t!= null)
            {
                Console.WriteLine(t.Value);
                t = t.Next;
            }
            Console.WriteLine(" end Printing -----> ");
        
        }

    }
}
