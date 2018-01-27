using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace primer
{
    class FindFirstNonRepeatingChar
    {

        public static char findFirstNonRepeatingChar(string str) {

            // first pass , count the chars
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            foreach (char c in str) {

                if (dictionary.ContainsKey(c))
                {
                    dictionary[c]++;
                }
                else {
                    dictionary[c] = 1;
                }

            }

            foreach (var kv in dictionary) {

                if (kv.Value == 1)
                {
                    return kv.Key;
                }
            }



            return '!';

        }

        /*having the numbers in the array, c will be found first, */
        public static char findFirstNonRepeatingChar2(string str)
        {

            // first pass , count the chars
            int[] dictionary = new int[128];
            foreach (char c in str)
            {

                dictionary[c]++;

            }

            for (int t = 0; t < dictionary.Length; t++) {
                if (dictionary[t] == 1)
                    return (char)t;
            }


            return '!';

        }
    }
}
