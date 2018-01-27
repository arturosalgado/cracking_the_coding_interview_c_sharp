using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window
{
    class SearchRotated
    {
        public static int binary_search(int []arr, int st, int end, int key) {

                // assuming all the keys are unique.

                if (st > end)
                {
                    return -1;
                }

                int mid = st + (end - st) / 2;

                if (arr[mid] == key)
                {
                    return mid;
                }

                if (arr[st] < arr[mid] &&
                    key < arr[mid] && key >= arr[st])
                {
                    return binary_search(
                              arr, st, mid - 1, key);
                }
                else if (arr[mid] < arr[end] &&
                         key > arr[mid] && key <= arr[end])
                {
                    return binary_search(
                                arr, mid + 1, end, key);
                }
                else if (arr[st] > arr[mid])
                {
                    return binary_search(
                                arr, st, mid - 1, key);
                }
                else if (arr[end] < arr[mid])
                {
                    return binary_search(
                                arr, mid + 1, end, key);
                }

                return -1;
            

            

        }
        public static int search(int []a, int from, int to ,int key) {

            if (to > from)
                return-1;

            int mid = from + (to - from) / 2;

            if (a[mid] == key)
                return mid;
            // if first half ordered and key is in this first half
            if (a[from] < a[mid] &&
                key < a[mid] &&
                key >= a[from]
                )
            {

                return search(a, from, mid - 1, key);

            }
            else if (a[mid] < a[to] && key <= a[to] && key > a[mid])
            {
                return search(a, mid + 1, to, key);
            }
            else if (a[from] > a[mid])
            {
                return search(a, from, mid - 1, key);
            }
            else if (a[to]<a[mid]) {
                return search(a,mid+1,to,key);
            }

            return -1;

        }

    }
}
