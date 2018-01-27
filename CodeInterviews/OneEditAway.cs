using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CodeInterviews
{
    class OneEditAway
    {

        public static bool oneEdit(string first, string second) {

            if (first.Length == second.Length)
            {

                return oneReplace(first, second);

            }
            else if (first.Length + 1 == second.Length) {

                return oneDiff(first, second);

            }
            else if (first.Length == second.Length+1)
            {
                return oneDiff(second,first);
            }
            return false;
        }

        static bool oneReplace(string first, string second) {
            bool oneDiff = false;
            for (int i = 0; i<first.Length;i++) {

                if (first[i] != second[i]) {
                    if (oneDiff) {
                        return false;
                    }
                    oneDiff = true;
                }
                        
            }
            return true;
        }
        static bool oneDiff(string short_string, string longer_string)
        {
            int indexShort = 0;
            int indexLong = 0;
            while (indexShort<short_string.Length && indexLong<longer_string.Length)
            {
                if (short_string[indexShort] == longer_string[indexLong])
                {
                    indexShort++;
                    indexLong++;
                }
                else {

                    if (indexShort == indexLong)
                    {
                        indexLong++;
                    }
                    else {

                        return false; // index different and letter different
                    }

                }

            }

            return true;

        }

        public static void CheckDiff(string s1, string s2) {

            int i1 = 0;
            int i2 = 0;

            while (i1 < s1.Length || i2 < s2.Length) {

                Console.WriteLine("s1 {0} s2 {1}",s1[i1],s2[i2]);

                i1++;
                i2++;

                Thread.Sleep(2000);

            }

        }

    }
}
