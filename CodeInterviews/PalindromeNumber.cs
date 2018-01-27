using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeInterviews
{
    class PalindromeNumber
    {

        public static bool isPalindrome(int number) {

            int div = 1;
            int result_division = 0;
            while ((result_division = (number / div)) >= 10) {
                div = div * 10;
            }
            while (number > 0) {

                int left = number / div;
                int right = number % 10;
                if (left != right)
                    return false;

                number = number % div / 10;


                div = div / 100;

            }
            return true;

        }

        public static bool isPalindrome2(int number)
        {

            int div = 1;
            while (number / div>=10) {
                div = div * 10;
            }
            // 2 5 2
            while (number > 0) {

                int right = number % 10;
                int left = number / div;
                if (right != left)
                    return false;

                number = number % div / 10;
                div = div / 100;  // accounts for left and right 
            }


            //Console.WriteLine(div);


            return true;

        }

    }
}
