using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeInterviews
{
    class IsRotation
    {

        public static bool isRotation(string s1, string s2) {

            //careful with the concatenation, s1+s2 will always return true which is wrong
            // we need s1+s1 

            string concat = s1 + s1;
            if (concat.Contains(s2)) {
                return true;
            }

            return false;

        }

    }
}
