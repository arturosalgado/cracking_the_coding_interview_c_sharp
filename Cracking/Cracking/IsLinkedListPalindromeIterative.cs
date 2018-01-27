using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class IsLinkedListPalindromeIterative
    {

        public static bool isPalindrome(Node head) {

            Node slow = head;
            Node fast = head;
            Stack<int> stack = new Stack<int>();
            while (fast != null && fast.Next != null) {

                stack.Push(slow.Value);
                fast = fast.Next.Next;
                slow = slow.Next;

            }
            if (fast != null) // is odd;
            {
                slow = slow.Next; // move to center
            }
            // now advance the last middle of the list
            while (slow != null) {
                if (slow.Value != stack.Pop()) {
                    return false;
                }
                slow = slow.Next;
            }

            return true;
        } 

    }
}
