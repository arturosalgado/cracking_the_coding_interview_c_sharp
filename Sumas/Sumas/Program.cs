using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sumas
{
    class Program
    {
        static void Main(string[] args)
        {

            string q = "";
            int a;
            int b;
            int c;
            Random r = new Random();
            

            while (q != "q")
            {
                a = r.Next(0,50);
                b = r.Next(0,50);
                
                Console.WriteLine(a);
                Console.WriteLine("Mas");
                Console.WriteLine(b);

                Console.WriteLine("{0} + {1} = ",a,b);


                q = Console.ReadLine();

                int ans = Convert.ToInt16(q);
                if (ans == (a + b))
                {
                    Console.WriteLine("Muy Bien!!!!");
                }
                else
                {
                    Console.WriteLine("Intentemos con otra ");
                }



            }

        }
    }
}
