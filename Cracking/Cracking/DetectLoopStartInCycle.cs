using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class DetectLoopStartInCycle
    {

        public static Node detect(Node head) {
            Console.WriteLine("in detect");
           
            Node slow = head;
            Node fast = head;
            while (fast != null && fast.Next != null) {
                slow = slow.Next;
                fast = fast.Next.Next;
                if (slow == fast) {
                    break;
                    //Console.WriteLine("Cycle detected");
                    //return null;
                }
            }
            Console.WriteLine("Done");

            if (fast == null || fast.Next == null) {
                return null;
            }

            /// start is K nodes from the begininng 

            slow = head;

            while (slow != fast) {
                slow = slow.Next;
                fast = fast.Next;

            }
            return fast;






        }

    }
}
