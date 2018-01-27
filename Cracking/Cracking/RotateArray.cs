using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class RotateArray
    {
        public static int[] rotate(int [] a , int k ) {

            k = k % a.Length;

            reverse(a,0, a.Length-1);
            reverse(a,0,k-1);
            reverse(a,k,a.Length-1);

            return a;
        }

        static void reverse(int [] a , int i, int j) {

            while (i < j) {
                Utils.swap(a, i, j);
                i++;
                j--;
            }

        }
    }
}
