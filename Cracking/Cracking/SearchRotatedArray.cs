using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class SearchRotatedArray
    {

        public static int searchRotated(int []arr,int low, int high, int key) {

            int mid = low + (high - low) / 2; // low is the offset , high -low (distance) /2
            Console.WriteLine("mid is {0}",mid);
            if (arr[mid] == key)
                return mid;

            if (arr[low] < arr[mid] &&
                key < arr[mid] &&
                key >= arr[low]
                )
            {
                return searchRotated(arr, low, mid - 1, key);
            }
            else if (arr[mid] < arr[high] &&
                     key > arr[mid] &&
                     key <= arr[high]
                    )
            {
                return searchRotated(arr, mid + 1, high, key);

            }
            // now start is out of order
            else if (arr[low] > arr[mid])
            {
                return searchRotated(arr, low, mid - 1, key); // like it is ordered
            }
            else if(arr[high]<arr[mid]){ // high is out of order

                return searchRotated(arr,mid+1,high,key);
            }


            return -1;
        }

    }
}
