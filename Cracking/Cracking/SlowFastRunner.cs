using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class SlowFastRunner
    {

        public static void Run(Node node) {

            Node fast = node;
            Node slow = node;

            while (fast != null && fast.Next != null) {

                //Console.WriteLine("slow:" + slow);
                //Console.WriteLine("fast:" + fast);

                slow = slow.Next;
                fast = fast.Next.Next;

                
            }
            Console.WriteLine("slow:" + slow);
            Console.WriteLine("fast:" + fast);
            Console.WriteLine("Done");
        }

    }
}
