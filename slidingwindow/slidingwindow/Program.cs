using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slidingwindow
{
    class Program
    {
        static void Main(string[] args)
        {
            int []a = {1,-1,2,-3,-5};
            sliding(a,3);
            Console.ReadKey();
        }

        static void sliding(int []a , int windowsize = 3)
        {

            

            LinkedList<int> window = new LinkedList<int>();

            for (int i = 0; i < windowsize; i++) {
                
                while(window.Count!=0 && a[i]>=window.la )

            }


        }
    }
}
