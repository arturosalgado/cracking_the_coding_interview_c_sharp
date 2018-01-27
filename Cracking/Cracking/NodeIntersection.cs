using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class NodeIntersection
    {

        public static Node find(Node list1, Node list2) {

            if (list1 == null || list2 == null) {
                return null;
            }

            Result r1 = getTailAndSize(list1);
            Result r2 = getTailAndSize(list2);

            if (r1.tail != r2.tail) {
                return null;// not equal
            }

            // determine which is short and which is long 

            Node shorter = r1.size < r2.size ? list1:list2;
            Node longer = r2.size > r1.size ? list2 : list1;
            // no sabemos a quien la asignamos asi que tiene que ser 
            // a la que no ess
            // move longer forward 
            longer = getKthNode(longer,Math.Abs(r1.size-r2.size));

            while (longer != shorter) {
                longer = longer.Next;
                shorter = shorter.Next;
            }


            return longer;// no intersection
        }

        public static Result getTailAndSize(Node head) {
            if (head == null) {
                return new Result(null,0);
            }
            int size = 1;
            Node current = head;
            while (current.Next != null) {
                current = current.Next;
                size++;
            }

            Result r = new Result(current,size);
            return r;
        }

        public static Node getKthNode(Node head, int k) {

            Node current = head;

            while (current != null && k > 0) {
                k--;
                current = current.Next;
            }
            return current;// if null , returns null

        }

    }

    class Result {
        public int size = 0;
        public Node tail = null;
        public Result(Node tail, int size) {
            this.tail = tail;
            this.size = size;
        }

    }
}
