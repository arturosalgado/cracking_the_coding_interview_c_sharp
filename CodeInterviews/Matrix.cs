using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeInterviews
{
    class Matrix
    {
        public static void rotate(int[,] m)
        {
            int n = m.GetLength(0);
            Console.WriteLine("Length is {0}",n);
            for (int t = 0; t < (n / 2); t++) {
                Console.Write(t+" ");
            }

        }
        public static void reach(int[,] m)
        {
            int n = m.GetLength(0);
            Console.WriteLine("Length is {0}", n);
            Console.WriteLine("{0}/2={1}",n, n/2);

            Console.WriteLine("Reach ");

            for (int t = 0; t < (n / 2); t++)
            {
                Console.Write(t + " ");
            }

        }
        public static void rotate2(int [,]matrix)
        {
            int x = matrix.GetLength(0);
            int y = matrix.GetLength(1);


            int layer = 0;
            int last = 0;
            int first = 0;
            for (layer = 0; layer < x; layer++)
            {

                last = (x - 1) - layer; // last iteration 3 - 3 = 0
                //Console.WriteLine("Last {0} ",last);
                first = layer;
                //Console.WriteLine("First {0} ", first);
                for (int k = first; k < last; k++)
                {

                    int offset = k - first;
                    int last_offset = last - offset;

                    Console.WriteLine("first{0}, k{1} , last_offset{2}, last {3}",first,k,last_offset,last);
                    int top = matrix[first,k];
                    matrix[first, k] = matrix[last_offset, first];
                    matrix[last_offset, first] = matrix[last, last_offset];
                    matrix[last, last_offset] = matrix[k, last];
                    matrix[k, last]=top;

                }


            }

        }
        public static void rotate3(int[,] matrix)
        {
            int x = matrix.GetLength(0);
            int y = matrix.GetLength(1);


            int layer = 0;
            int last = 0;
            int first = 0;
            for (layer = 0; layer < x; layer++)
            {

                last = (x - 1) - layer; // last iteration 3 - 3 = 0
                //Console.WriteLine("Last {0} ",last);
                first = layer;
                //Console.WriteLine("First {0} ", first);
                for (int k = first; k < last; k++)
                {

                    int offset = k - first;
                    int last_offset = last - offset;

                    Console.WriteLine("offset {0}", offset);
                    

                }


            }

        }
        public static void sequence1(int x, int y=0)
        {
            Console.WriteLine("Received {0}",x);

            int layer = 0;
            int last = 0;
            int first = 0;
            for ( layer=0; layer<x; layer++) {

                last = (x -1) - layer  ; // last iteration 3 - 3 = 0
                //Console.WriteLine("Last {0} ",last);
                first = layer;
                //Console.WriteLine("First {0} ", first);
                for (int k = first; k< last; k++) {

                    int offset = k - first;

                    Console.WriteLine(" {0},{1}");

                }


            }

        }

        public static void upanddown(int x=4, int y = 4)
        {
            for (int i = 0; i<x; i++) {

                int down1 = (x - 1) - i;
                Console.Write("i- {0}  ", i);
                for (int j = i; j < down1; j++) {
                    //Console.WriteLine("i {0} down {1} j {2}  ", i, down1,j);
                    Console.WriteLine("i {0} ",i);
                }
            }

        }

        public static int[,] createMatrix(int n) {
            Random r = new Random();
            int[,] m = new int[n,n];

            for (int i = 0; i < n; i++) {

                for (int j = 0; j < n; j++)
                {
                    m[i, j] = r.Next(1,10);

                }
            }
            return m;
        }

        public static void PrintMatrix(int [,]matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
           
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {

                    Console.Write("{0} ",matrix[i,j]);


                }
                Console.WriteLine("");

            }

        }
        public static void swap(int[,] m, int x, int y)
        {

            int t = m[x, y];
            m[x, y] = m[y, x];
            m[y, x] = t;


        }
        public static void rotateN(int[,] m) {
            Console.WriteLine("Rotating ... ");
            int N = m.GetLength(0);

            for (int i = 0; i <= N - 2; i++)
                for (int j = i + 1; j <= N - 1; j++) {

                    //Console.WriteLine("{0} {1}",i,j);
                    Matrix.swap(m,i,j);
                }
                

        }
        public static void rotate_(int[,] m)
        {
            int N = m.GetLength(0);
            int ceil =(int)Math.Ceiling((float)N/2);
            int flor =(int) Math.Floor((float)N/2);
            Console.WriteLine("floor is {0}, ceil is {1} ddd",flor,ceil);
            for (int x = 0; x< flor; x++) {

                for (int y = 0; y < ceil; y++)
                {
                    int temp = m[x,y];
                    //m[i,j]= 
                    m[x, y] = m[y,N-1-x];
                    m[y, N - 1 - x]= m[N- 1 - x, N - 1 - y];
                    m[N - 1 - x, N - 1 - y] = m[ N - 1 - y,x];
                    m[N - 1 - y, x]= temp;
                   

                }

            }



        }
    }
}
