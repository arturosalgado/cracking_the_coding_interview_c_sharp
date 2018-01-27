using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingHackerRank
{
    class Programs
    {

        public static void callPoints() {

            int[,] points = { {5, 6, 7 },
                             { 3, 6, 10 } };

            int [] res = AwardedPoints.points(points[0,0],points[0,1],points[0,2],
                                 points[1, 0], points[1, 1], points[1, 2]
                );

            Console.WriteLine(string.Join(" ",res));

        }
        public static void callBalanced() {

            string[] expressions = { "{[()]}",
                                      "{[(])}",
                                      "{{[[(())]]}}"
                                   };

            BalancedBrackets.run(expressions);

        }

        public static void callRansomeTests() {

            string[,] tests = {
                                { "hello world", "hello"},
                                { "hello World", "hello world"},
                                 { "give me one grand today night", "give one grand today"},
                                  { "two times three is not four", "two times two is four"},
                              };
            string[] results = { "Y","N","Y","N"};

            for (int i = 0; i<tests.GetLength(0);i++) {


                string a = (tests[i,0]);
                string b = (tests[i, 1]);
                string r = callRansom(a,b);
                Tests.Equal(r, results[i]);
            }



        }

        public static string callRansom(string magazine, string note) {
            //Console.WriteLine("Calling with {0} {1}",magazine,note);

            if (Ransome.canMakeNote(magazine, note))
            {
                return "Y";
            }
            else {
                return "N";
            }


        }


        public static void callAnagramMaker()
        {
            string a = "";
            string b = "";
            //List<List<string>> cases = new List<List<string>>();

            a = "imkhnpqnhlvaxlmrsskbyyrhwfvgteubrelgubvdmrdmesfxkpykprunzpustowmvhupkqsyjxmnptkcilmzcinbzjwvxshubeln";
            b = "wfnfdassvfugqjfuruwrdumdmvxpbjcxorettxmpcivurcolxmeagsdundjronoehtyaskpwumqmpgzmtdmbvsykxhblxspgnpgfzydukvizbhlwmaajuytrhxeepvmcltjmroibjsdkbqjnqjwmhsfopjvehhiuctgthrxqjaclqnyjwxxfpdueorkvaspdnywupvmy";

            //a = "aabcc";
            //b = "abbcd";




            //a = "abc";
            //b = "cde";

            
            a = "abfgh";
            b = "fg";
            int removals = AnagramMaker.removals(a, b);
            

            Console.WriteLine("removals returned "+removals);


           



        }



        public static void callLeftRotation()
        {

            

        int[] a = { 1, 2, 3, 4, 5 };

        Console.WriteLine(string.Join(",", a));

        a = LeftRotationPartition.leftRotation(a, 2);

        Console.WriteLine(string.Join(",", a));





        }

    }
}
