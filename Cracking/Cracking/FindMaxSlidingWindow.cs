using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class FindMaxSlidingWindow
    {
        public static void find(int [] a, int windowSize=3) {

           // Console.WriteLine("array is "+string.Join(",",a));

            // first validation, if array size is smaller than window return 
            // arr[1] , window size 4 , nothing to do 
            if (a.Length < windowSize)
            {
                Console.WriteLine("array smaller than window size");
                return;
            }

            LinkedList<int> window = new LinkedList<int>();

            for (int i = 0; i < windowSize; i++) {
                //Console.WriteLine("i = {0}",i);

                while (window.Count>0 && 
                    a[i]>=a[window.Last()]) {
                    window.RemoveLast();
                }
                window.AddLast(i);

            }

            // print the first item

            Console.WriteLine("first max {0}",a[window.First()]);

            // from where we let off to the end

            for(int i=windowSize; i< a.Length; i++)
            {

                while (window.Count > 0 && 
                       a[i] >= a[window.Last()])
                {
                    window.RemoveLast();
                }

                if (window.Count > 0 && window.First() <= i-windowSize) {
                    window.RemoveFirst();
                }

                window.AddLast(i);

                Console.WriteLine("max {0}",a[window.First()]);
            }


        }

    }
}
