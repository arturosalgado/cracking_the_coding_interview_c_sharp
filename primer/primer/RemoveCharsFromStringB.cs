using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer
{
    class RemoveCharsFromStringB
    {

        public static string removeChars(string s1, string s2) {
            char[] c1 = s1.ToCharArray();
            char[] c2 = s2.ToCharArray();
            HashSet<char> dict = new HashSet<char>();
            foreach (var c in c1) {
                if (!dict.Contains(c)) {
                    dict.Add(c);
                }
            }
            StringBuilder result = new StringBuilder();
            foreach (var c in c2) {
                if (!dict.Contains(c)) {
                    result.Append(c);
                }
            }

            return result.ToString();
        }

    }
}
