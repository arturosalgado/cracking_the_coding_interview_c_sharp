using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingHackerRank
{
    class LeftRotationPartition
    {

        public static int[] leftRotation(int [] a, int d) {

            int[] part1 = copy(a, 0, d-1);
            int[] part2 = copy(a, d,a.Length-1);

            return part2.Concat(part1).ToArray();
        }

        public static int [] copy(int[] a, int x, int y) {

            int diff = (y - x)+1;


            int[] part = new int[diff];
            for (int i = 0; i < diff; i++) {
                part[i] = a[i +x];
            }
            return part;

        }




    }
}
