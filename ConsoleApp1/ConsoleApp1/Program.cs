using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>(10);

            list.Add(1000);
            list.Add(2000);
            list.Add(3000);
            list.Add(4000);
            list.Insert(1,666);
            list.Insert(5, 666);
            list.Insert(6, 666);
            list.Insert(7, 666);






            Console.ReadKey();
        }


        static float[] runner(int[] arr, int n) {

            float[] result = new float[n];


            List<int> a = new List<int>();



            int index = 0; 
            foreach (var element in arr)
            {

                a.Add(element);
                a.Sort();

                int length = a.Count;
                float med = 0;
                if (length % 2 == 0)
                {

                    //Console.WriteLine("even");
                    int mid1 = (length / 2) - 1;
                    //Console.WriteLine("mid1 {0}", mid1);
                    int mid2 = (length / 2);
                    //Console.WriteLine("mid2 {0}", mid2);
                    med = (float)(a[mid1] + a[mid2]) / 2;
                    //Console.WriteLine("med {0}", med);

                }
                else
                {

                    int mid = (length / 2);
                    med = a[mid];
                }
                result[index++]= med;
            }

            return result;

        }
    }
}
