using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class ArrayLowHighIndex
    {

        public static int find_low(int [] a , int key) {

            int low = 0;
            int high = a.Length - 1;
            int mid = high / 2;

            while (low <= high) {

                int mid_element = a[mid];

                if (mid_element < key)
                {
                    low = mid + 1;
                }
                else if (mid_element>=key) { // reduce the scope towards the low key
                    high = mid - 1;
                }

                mid = low + (high - low) / 2;
            }

            if (a[low] == key) {
                return low;
            }


            return -1;
        }

    }
}
