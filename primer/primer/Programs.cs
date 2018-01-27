using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer
{
    class Programs
    {
        public static void callRemoveChar()
        {

            string c = RemoveCharsFromStringB.removeChars("cat","late");
            Console.WriteLine("Result is :  {0}", c);

        }
        public static void callFindFirstNotRepeated() {

            char c = FindFirstNonRepeatingChar.findFirstNonRepeatingChar2("abadbc");
            Console.WriteLine("First {0}",c);

        }

        public static void callPrintAll() {

            printAllSubstrings.printall("abc");
            //StringBuilder buffer = new StringBuilder("   ");
            char [] buffer = new char[2];
            bool[] visited = new bool[2];
            printAllSubstrings.printAllPermutations("AB", buffer, 0,visited,2);
           
        }

        public static void callLongestPalindrome()
        {

            int max = FindLongestPalindrome.findLongestPalindrome("casaasac123");

            Console.WriteLine(  "longest {0}",max);

        }

    }
}
