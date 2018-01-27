using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInRotatedArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr= { 4,5,6,1,2,3};
            int key = 5;
            int res = binary_search_rotated(arr,key);
            Console.WriteLine("result is {0}",res);
            Console.ReadKey();
        }

        static int binary_search(int[] arr,int st, int end, int key) {

            if (st > end)// start ya paso a end, no estuvo
            {
                return -1;
            }

            int mid = st + (end - st) / 2;
            Console.WriteLine("mid is {0}",mid);
            if (arr[mid] == key)
            {
                return mid;
            }

            if (arr[st] < arr[mid] && //si la primera mitad esta ordenada y si la llave esta entre esa mitad
                key < arr[mid] && key >= arr[st])
            {
                return binary_search(
                          arr, st, mid - 1, key);// llama a binary search con la primera mitad
            }
            else if (arr[mid] < arr[end] &&//si la segunda mitad esta ordenada y si la llave queda dentro de la segunda mitad
                     key > arr[mid] && key <= arr[end])
            {
                return binary_search(
                            arr, mid + 1, end, key);// llamaa con la segunad mitad
            }
            else if (arr[st] > arr[mid])// caso 4 ,5 , 1 2,3,  // search in left part , as if it was regular array
            {
                return binary_search(
                            arr, st, mid - 1, key);
            }
            else if ( arr[mid]> arr[end])//   3 ,4, 5, 1, 2 // search in this right part 
            {
                return binary_search(
                            arr, mid + 1, end, key);
            }

            return -1;

        }

        static int binary_search_rotated(
        int[] arr,
        int key)
        {
            return binary_search(
                      arr, 0, arr.Length - 1, key);
        }
    }
}
