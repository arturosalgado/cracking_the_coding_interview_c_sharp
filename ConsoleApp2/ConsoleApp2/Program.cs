using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = { "david","bellissa","mahetzi"};

            foreach (var name in names) {
                Console.WriteLine(name);
            }
            Console.Write(names.Rank);

            string[,] t = { { "pepe", "papa" }, { "casa", "hijos" } };

            foreach (var row in t) {
                
                Console.WriteLine(row);
            }

            for(int k = 0; k<t.GetLength(0); k++)
            {
                for (int j = 0; j < t.GetLength(1); j++) {

                    Console.Write("{0} -> ",t[k,j]);

                }
                Console.WriteLine("");

            }

            Console.ReadKey();
        }
    }
    class Book {

        private string title = "";
        public Book(string title) {
            this.title = title;
        }
        public string Title {

            get {
                Console.WriteLine("title was requested");
                return title;
            }
            set {

                this.title = Title;
                Console.WriteLine(  "title was updated");


            }

        }

        public override string ToString()
        {
            return this.Title;


        }


    }
}
