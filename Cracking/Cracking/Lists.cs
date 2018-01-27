using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class Lists
    {
        public static void testList()
        {
            List<int> list1 = new List<int>(new int[] { 1, 2, 3 });

            foreach (var e in list1) {

                if (list1.Contains(3)) {
                    Console.WriteLine("Yes, it contains 3");
                }
                if (e == 3) {
                    Console.WriteLine("Yes , this is three ");
                }
                Console.WriteLine(e);
            }
            for (int i = 1; i < 100; i++) {

                list1.Add(i);

            }

            foreach (var e in list1) {
                Console.WriteLine( e);
            }

            Console.WriteLine( "size is {0}",list1.Count);
        }

        
    }
}
