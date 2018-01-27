using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer
{
    class FindLongestPalindrome
    {

        public static int findLongestPalindrome(string str) {
            int max1 = 0;
            int max2 = 0;
            for (int pos= 0; pos< str.Length;pos++) {

                int left = pos - 1;
                int right = pos + 1;
                int length1 = 1;
                int length2 = 2;
                while (left>= 0 && right <str.Length) {
                    if (str[left] != str[right]) {
                        break;
                    }
                    left--;
                    right++;
                    length1 += 2;
                }
                if (length1 > max1) {
                    max1 = length1;
                }
                // check evens 

                if ( pos+1<str.Length && str[pos] == str[pos + 1] ) {

                    left = pos - 1;
                    right = pos + 2;
                    length2 =2;
                    while (left >= 0 && right < str.Length) {

                        if (str[left] != str[right]) {
                            break;
                        }

                        length2 += 2;
                        left--;
                        right++;
                    }

                    if (length2 > max2) {
                        max2 = length2;
                    }
                }

            }

            return Math.Max(max1,max2);
        }

    }
}
