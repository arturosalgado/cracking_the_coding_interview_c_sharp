using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeInterviews
{
    class Strings1
    {

        public static bool repeatedString(string s) {

            bool[] done = new bool[128];
            if (s.Length > 128)
            {
                return true;
            }
            else {

                foreach (var c in s) {
                    if (done[c])
                    {
                        return true;
                    }
                    else {

                        done[c] = true;
                    }
                }

            }
            return false;


        }
        /*sort the strings , then loop, if two same together return yes
         there are duplicates
             */

        public static bool duplicateChars(string a ) {

            char []s = a.ToCharArray();
            Array.Sort(s);
            Utils.print_c(s);  // por referencia, s = casa results in aacs
            int i = s.Length-1;
            //Console.Write("Length of i is {0}",i);
            int p = s.Length - 2;
            while (i > 0) {
                if (s[i] == s[p]) {
                    return true;
                }
                p--;
                i--;
            }


            


            return false;
        }

        /*
         *sort and then check  
         */
        public static bool isPermutation(string s1, string s2) {

            // first check size

            if (s1.Length != s2.Length)
                return false;


            char[] c1 = s1.ToCharArray();
            char[] c2 = s2.ToCharArray();

            Array.Sort(c1);
            Array.Sort(c2);

            return c1 == c2;



        }
        /*
        here the approach is to count in one pass the number of chars, 
        then count back, if at some point the array element is 
        negative : break as it is a different count
             
        */

        public static bool isPermutation2(string s1, string s2) {

            int[] counts = new int[128];

            foreach (char c1 in s1) {

                Console.WriteLine("char c1 {0} has value {1}",c1,(int)c1);
                counts[c1]++;

            }
            foreach (char c2 in s2)
            {

                ///Console.WriteLine("char c1 {0} has value {1}", c1, (int)c1);
                counts[c2]--;
                if (counts[c2] < 0)
                    return false;
            }


            return true;
        }


        public static bool isPalindromePermutation(string s) {

            Console.WriteLine("String is "+s);
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in s) {
                if (c == ' ') continue;
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else {
                    dict.Add(c,1);
                }
            }
            bool found = false;
            foreach (KeyValuePair<char, int> p in dict) {

                int val = p.Value;

                if (val % 2 == 1)
                {
                    if (found)
                    {
                        return false;
                    }
                    found = true;
                }

            }


            return true;


        }

        

    }
}
