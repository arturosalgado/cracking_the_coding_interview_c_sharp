using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeInterviews
{
    class StringCompress
    {


        public static int countCompress(string s) {

            int compressedLength = 0;
            int consecutive = 0;


            for (int t = 0; t < s.Length; t++) {

                consecutive++;
                Console.WriteLine("Con"+consecutive);
                string a = Convert.ToString(t);
                Console.WriteLine(a);

                if (t + 1 >= s.Length) {
                    string c = Convert.ToString(consecutive); 
                    compressedLength += 1 + c.Length;
                }

            }

            return compressedLength;

        }


        public static int countCompress2(string s)
        {

            int finalLength = 0;
            int consecutive = 0;

            for (int i = 0; i < s.Length; i++) {
                consecutive++;
                if (i + 1 >= s.Length || s[i]!=s[i+1])
                {
                    string conseq = Convert.ToString(consecutive);
                    finalLength = finalLength + 1 + conseq.Length;
                    consecutive = 0;
                }
                

            }
            return finalLength;

        }
        public static string  compress(string s,int length)
        {
            StringBuilder r = new StringBuilder(length);

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in s) {

                if (dict.ContainsKey(c))
                {

                    dict[c]++;

                }
                else {

                    dict[c] = 1;

                }
                dict = dict;
                
            }
            foreach (var kvp in dict)
            {

                r.Append(kvp.Key);
                r.Append(Convert.ToString(kvp.Value));

            }


            return r.ToString();

        }
    }
}
