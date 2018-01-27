using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeInterviews
{
    class DeleteMiddleNode
    {

        public static bool deleteMiddleNode(Node node) {

            if (node == null || node.Next == null)
                return false;

            else {

                Node next = node.Next;
                node.Value = next.Value;
                node.Next = next.Next;
                return true;
            }

        }

    }
}
