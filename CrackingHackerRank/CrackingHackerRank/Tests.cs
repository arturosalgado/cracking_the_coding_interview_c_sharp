using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingHackerRank
{
    class Tests
    {

        public static bool Equal(string a, string b)
        {

            if (a.Equals(b))
            {

                Console.WriteLine("Test Passed");
                return true;
            }
            else { 
            Console.WriteLine("Test Fails");
            return false;
            }

        }

    }
}
