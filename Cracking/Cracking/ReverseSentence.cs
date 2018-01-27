using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class ReverseSentence
    {

        public static string reverseSentence(string sentence)
        {

            string s1 = reverse(sentence);

            string [] words = s1.Split(' ');

            StringBuilder result = new StringBuilder();
            foreach (string word in words) {
                result.Append(reverse(word));
                result.Append(' ');
            }
            return result.ToString();

        }

        public static string reverse(string word) {

            int start = 0;
            int end = word.Length - 1;
            char[] s = word.ToCharArray();
            while (start < end) {

                swap(s, start, end);
                start++;
                end--;
            }
            return new string(s);

        }

        public static void swap(char[] s, int i, int j)
        {
            char temp = s[i];
            s[i] = s[j];
            s[j] = temp;

        }

    }
}
