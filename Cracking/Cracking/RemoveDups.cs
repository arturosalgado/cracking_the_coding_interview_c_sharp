using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class RemoveDups
    {

        public static Node deleteDups(Node head) {

            HashSet<int> set = new HashSet<int>();
            Node previous = null;
            Node n = head;
            while (n != null) {

                if (set.Contains(n.Value))
                {
                    previous.Next = n.Next;// skip to the next node
                }
                else {
                    previous = n;
                    set.Add(n.Value);
                }
                n = n.Next;
            }
            return head;
        }

    }
}
