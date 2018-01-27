using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "awaglknagawunagwkwagl";
            inputString = "abcd";
            int num = 3;
            string clean_string = removeDups(inputString);
            char[] c = clean_string.ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < clean_string.Length - 1; i++) {

                
                sb.Append(c[i]);
                for (int k = i + 1; k < 3; k++) {
                    sb.Append(c[k]);
                }

                Console.WriteLine(  sb.ToString());
                

            }
               
           

            Console.ReadKey();
        }

       


        static void printAllKLength(char []set, int k)
        {
            int n = set.Length;
            printAllKLengthRec(set, "", n, k);
        }

        static void printAllKLengthRec(char []set, String prefix, int n, int k)
        {

            // Base case: k is 0, print prefix
            if (k == 0)
            {
                Console.WriteLine(prefix);
                return;
            }

            // One by one add all characters from set and recursively 
            // call for k equals to k-1
            for (int i = 0; i < n; ++i)
            {

                // Next character of input added
                String newPrefix = prefix + set[i];
                
                // k is decreased, because we have added a new character

                set = copy_r(set, i+1);
                printAllKLengthRec(set, newPrefix, n, k - 1);
            }
        }

        static char[]  copy_r(char[] a, int k) {
            char[] b = new char[a.Length-1];
            for (int i = 0; i < a.Length-1; i++) {
                b[i] = a[i + 1];
            }
            return b;
        }



        public static string removeDups(string s){
            HashSet<char> set = new HashSet<char>();
            for (int i = 0; i < s.Length; i++) {

                if (!set.Contains(s[i]))
                {
                    set.Add(s[i]);
                }
               

            }
            StringBuilder sb = new StringBuilder();
            foreach (var kp in set) {

                {
                    sb.Append(kp);
                }

            }

            return sb.ToString();
        }
    }
}
