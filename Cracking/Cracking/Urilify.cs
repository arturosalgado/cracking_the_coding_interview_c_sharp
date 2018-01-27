using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class Urilify
    {

        public static string urilify(string str) {

            int n = str.Length;
            int spaces = 0;
            //first pass count the blanks 
            for (int i = 0; i < str.Length; i++) {
                if (str[i] == ' ') {//use str as char array
                    spaces++;
                }
            }
            // compute the new length
            int newLength = (n + spaces * 2);
            char [] newString = new char[newLength];
            // from tail to head, fill spaces guided by original string
            for (int i = n - 1; i >= 0; i--) {

                if (str[i] == ' ')
                {
                    newString[newLength - 1] = '0';
                    newString[newLength - 2] = '2';
                    newString[newLength - 3] = '%';
                    newLength = newLength - 3;
                }
                else {
                    newString[newLength - 1] = str[i];
                    newLength--;
                }

            }
            return string.Join("", newString);

        }
        public static string urilify2(string str)
        {

            int n = str.Length;
            int spaces = 0;
            //first pass count the blanks 
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {//use str as char array
                    spaces++;
                }
            }
            // compute the new length
            int newLength = 0;
            char[] newString = new char[n+(2*spaces)];
            // from tail to head, fill spaces guided by original string
            for (int i = 0; i<n; i++)
            {

                if (str[i] == ' ')
                {
                    newString[newLength++] = '0';
                    newString[newLength++] = '2';
                    newString[newLength++] = '%';
                   
                }
                else
                {
                    newString[newLength++] = str[i];
                    
                }

            }
            return string.Join("", newString);

        }

    }
}
