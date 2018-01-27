using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class Tests
    {

        public static void testModulo(int lenght, int n)
        {
            
            n = n % lenght;

            Console.WriteLine( "n is {0}, length is {1}",n,lenght);


        }

        public static void testReverse()
        {

            int[] a = { 1,2,3,4};
            Utils.print_r(a);
            Utils.Reverse(a, 0, a.Length-1);

            Utils.print_r(a);

        }
        public static void test1() {

            string explodeme = "1,2,3,4,5";

            string[] pieces = explodeme.Split(',');
            
            Console.WriteLine(string.Join(":",pieces));
        }

        public static int[] BubbleSort(int[] nums , int n)
        {

            for (int i = 0; i < n; i++) {
                for (int j = i+1; j < n; j++)
                {
                    if (nums[i]>nums[j])//both reach the end
                    Utils.swap(nums, i, j);
                }
            }

            return nums;
        }
    }
}
