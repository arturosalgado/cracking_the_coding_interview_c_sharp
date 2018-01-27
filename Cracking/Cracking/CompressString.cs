using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class CompressString
    {

        public static string Compress(string str) {
            int length = str.Length;
            int countConsecutive = 0;
            StringBuilder compressed = new StringBuilder();
            for (int i = 0; i < length;  i++) {
                countConsecutive++;
                if (i+1 == str.Length || str[i]!= str[i + 1]) {
                    compressed.Append(str[i]);
                    compressed.Append(countConsecutive);
                }

            }
            return compressed.ToString();
        }
        public static string Compress2(string str)
        {
            int length = str.Length;
            int countConsecutive = 0;
            StringBuilder compressed = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                countConsecutive++;
                if (i + 1 == str.Length||str[i]!=str[i+1])
                {
                    compressed.Append(str[i]);
                    compressed.Append(countConsecutive);
                    countConsecutive = 0;
                }

            }
            return compressed.ToString();
        }

    }
}
