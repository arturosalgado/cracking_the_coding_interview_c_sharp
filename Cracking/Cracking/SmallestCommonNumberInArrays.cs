using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class SmallestCommonNumberInArrays
    {
        /*returns an array out of two sorted arrays */
        public static int common(int []a , int []b) {


            int pointer1 = 0;
            int pointer2 = 0;

            while (pointer1 < a.Length && pointer2 < b.Length) {


                if (a[pointer1] == b[pointer2])
                {
                    return a[pointer1];
                }

                if (a[pointer1] < b[pointer2])
                {
                    pointer1++;
                }
                else {
                    pointer2++;
                }


            }


            return -1;
        }

    }
}
