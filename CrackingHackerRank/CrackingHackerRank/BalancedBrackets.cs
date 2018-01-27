using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingHackerRank
{
    class BalancedBrackets
    {
            public static void run(string[] cases) {

                foreach (string c in cases) {
                    if (balanced_deletion(c))
                    {
                        Console.WriteLine("YES");

                    }
                    else {
                        Console.WriteLine("NO");    
                    }
                }

            }

            // no pasa los tests cases , doesnt pass test cases
            public static bool balanced_deletion(string s)
            {

                string e = s;
                while (e.Length > 0) {

                    e = e.Replace("()","");
                    e = e.Replace("{}","");
                    e = e.Replace("[]","");

                    if (e == s) {
                        return false;
                    }

                }

                return true;
           
            }

        public static bool balanced(string s) {

            Stack<char> stack = new Stack<char>();
            foreach (char c in s) {

                if (c == '(')
                {
                    stack.Push(')');
                }
                else if (c == '[')
                {

                    stack.Push(']');
                }
                else if (c == '{')
                {

                    stack.Push('}');
                }
                else {

                    if (stack.Count == 0 && c != stack.Pop()) {
                        return false;
                    }
                }

            }

            if (stack.Count == 0)
                return true;
            else
                return false;
        }
    }
}
