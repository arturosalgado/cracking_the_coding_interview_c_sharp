using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class PartitionAroundPivot
    {

        public static int [] partition(int [] a, int start, int end) {

            int pivot = start;
            int target = a[pivot];


            int i = start;
            int j = end+1;
            int count = 0; 
            while (i < j) {
                Console.WriteLine("Vuelta {0}",count++);
                do {

                    ++i;
                    Console.WriteLine("increasing i {0}",i);
                } while ( a[i]<target);
                do
                {

                    --j;
                    Console.WriteLine("decreasing j {0}", j);
                } while ( a[j] > target);

                if (i > j) {
                    Console.WriteLine("breaking");
                    break;
                }
                Utils.swap(a, i, j);
            }

            Utils.swap(a,j,start);
            return a;
        }

        public static int[]  partition2(int[] a, int start, int end)
        {
            int left = start;
            int right = end;
            int pivot = start;
            int item = a[start];
            while (left < right)
            {
                while (a[left] <= a[pivot] )
                    left++;
                while (a[right] > a[pivot])
                    right--;
                if (left < right)
                {
                    Utils.swap(a, left, right);
                }

            }
            // this bit moves the 4 to the center and the center to the right

            Utils.swap(a, pivot, right);
            return a;
        }

    }
}
