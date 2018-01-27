using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTops2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> options = new Dictionary<string, int>();

            options.Add("HackerBook", 777444);
            //options.Add("RankBook", 3);
            //options.Add("TheBook", 777);
            //options.Add("BestBook", 47);
            options.Add("BestBook1", 44771);

            string res  = laptop(options);
            Console.WriteLine(res);
            Console.ReadKey();

        }


        static string laptop(Dictionary<string,int> options ) {

            int lowest = 100000;
            string laptop = "-1";
            foreach (var lap in options) {

                if (analyze(lap.Value)) {
                    if (lap.Value < lowest)
                    {
                        lowest = lap.Value;
                        laptop = lap.Key;

                    }
                        
                        
                }


            }

            return laptop;

        }

        static bool analyze(int price) {

            int sevens = 0;
            int fours = 0;
            string p= Convert.ToString(price);

            foreach (char c in p) {

                if (c == '7')
                    sevens++;
                if (c == '4')
                    fours++;

            }

            if (sevens == fours && sevens != 0)
                return true;
            return false;

        }

    }
}
