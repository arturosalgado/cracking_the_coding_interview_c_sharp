using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class StringRotation
    {
        public static bool isRotation(string s1, string s2) {

            string s1s1 = s1 + s1;
            if (s1s1.Contains(s2))
                return true;
            return false;
        }


    }
}
