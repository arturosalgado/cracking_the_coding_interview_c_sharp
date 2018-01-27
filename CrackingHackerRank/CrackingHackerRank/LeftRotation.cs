using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingHackerRank
{
    class LeftRotation
    {
        /*this one is of  course n*n time complex  */
        public static int[] leftRotation(int[] a, int d) {

            for (int t = 0; t < d; t++) {
                rotateOnce(a);
            }
            return a;
        }

        static void rotateOnce(int[]a ) {
            int head = 0;
            int tail = a.Length - 1;

            int tempHead = a[head];

            for (int i = 0; i < a.Length - 1; i++)
            {
                a[i] = a[i + 1];
            }

            a[tail] = tempHead;

            

        }
    }
}
