using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeInterviews
{
    class Nullify
    {
        

        public static int[,] createMatrix(int n) {
            Random r = new Random();
            int[,] m = new int[n,n];

            for (int i = 0; i < n; i++) {

                for (int j = 0; j < n; j++)
                {
                    m[i, j] = r.Next(0,10);

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

        public static void nullify(int[,] m) {

            bool[] rowsWithZero = new bool[m.GetLength(0)];
            bool[] colsWithZero = new bool[m.GetLength(1)];

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {

                    if (m[i, j] == 0) {

                        rowsWithZero[i] = true;
                        colsWithZero[j] = true;

                    }

                }
            }
            nullifyRow(m,rowsWithZero);
            nullifyCol(m, colsWithZero);
                



        }

        public static void nullifyRow(int[,]m, bool[] row) {

            for (int i= 0; i < row.Length; i++){

                if (row[i]) {

                    for (int j = 0; j < m.GetLength(1); j++) {
                        m[i, j] = 0;
                    }

                }

            }

        }
        public static void nullifyCol(int[,] m, bool[] col)
        {

            for (int i = 0; i < col.Length; i++)
            {

                if (col[i])
                {

                    for (int j = 0; j < m.GetLength(0); j++)
                    {
                        m[ j,i] = 0;
                    }

                }

            }

        }

    }
}
