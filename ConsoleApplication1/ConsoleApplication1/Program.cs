using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static Dictionary<char, int> l = new Dictionary<char, int>();

        static void Main(string[] args)
        {
            list();
            string number = "511s51";
            Console.WriteLine("Original String is "+number);
            
            int? num =  strtoint(number);

            if (num.HasValue)
            {
                Console.WriteLine(num);
            }
            else {
                Console.WriteLine("NUmber {0} is invalid",number);
            }


          

            Console.ReadKey();
        }

        static int? strtoint(string stringNumber)
        {
            bool negative = false;
            Match m = Regex.Match(stringNumber, @"\-");
            Console.WriteLine("m is "+m);
            if (m.Length > 0)
            {
                negative = true;
                stringNumber = new String(stringNumber.ToCharArray(),1,stringNumber.Length-1);
                Console.WriteLine("New string is "+stringNumber);
            }

            int intNumber=0;
            int total = 0;
            char[] number = stringNumber.ToCharArray();
            float power = 0;
            int c;
            for (int i = number.Length-1; i >= 0; i--)
            {
                char ch = number[i];
                Console.WriteLine("char is  is " + ch);
                try
                {
                     c = l[ch];
                }
                catch(Exception e){
                    return null;
                }
                Console.WriteLine("c is "+c+" power is "+power);

                int part = (int)Math.Pow(10,power);
                Console.WriteLine("Part is  " + part);
                Console.WriteLine("c a la power "+(c*part));
                intNumber = c * part;
                Console.WriteLine("Total is  " + intNumber);
                total = total + intNumber;
                power++;
                Console.ReadKey();
            }
            return (negative)?-total:total;
            
        }
        /*init list */
        static void list()
        {

            l.Add('0',0);
            l.Add('1', 1);
            l.Add('2', 2);
            l.Add('3', 3);
            l.Add('4', 4);
            l.Add('5', 5);
            l.Add('6', 6);
            l.Add('7', 7);
            l.Add('8', 8);
            l.Add('9', 9);
            
        }

    }
}
