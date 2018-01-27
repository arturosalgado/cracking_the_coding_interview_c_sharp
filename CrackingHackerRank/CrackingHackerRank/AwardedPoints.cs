using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingHackerRank
{
    class AwardedPoints
    {
       
            public static int[] points(int a0, int a1, int a2, int b0, int b1, int b2)
            {
                int[] res = new int[2];
                int alice_points = 0;
                int bob_points = 0;
                if (a0 > b0)
                {
                    alice_points++;
                }
                else if (a0 < b0)
                {
                    bob_points++;
                }
                if (a1 > b1)
                {
                    alice_points++;
                }
                else if (a1 < b1)
                {
                    bob_points++;
                }
                if (a2 > b2)
                {
                    alice_points++;
                }
                else if (a2 < b2)
                {
                    bob_points++;
                }

                res[0] = alice_points;
                res[1] = bob_points;

                return res;
            }

        
    }
}
