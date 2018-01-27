using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer
{
    class printAllSubstrings
    {

        public static void printall(string s) {

            for (int i = 0; i < s.Length; i++) {

                for (int j = i; j<s.Length;j++) {
                    
                    for (int pos = i; pos <= j; pos++) {
                        Console.Write(s[pos]);
                    }
                    Console.WriteLine();
                }
            }

        }

        public static void printAllPermutations(string str,
            char [] buffer,
            int pos, bool [] visited, int length) {
            if (pos == length) {
              
                Console.WriteLine(buffer);
                return;
            }
            for (int i = 0; i < length; i++) {

                if (visited[i] == false) {
                    buffer[pos] = str[i];
                    visited[i] = true;
                    printAllPermutations(str,buffer,pos+1,visited,length);
                    visited[i] = false;
                }
            }
        }

        


    }
}
