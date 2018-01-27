using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking
{
    class MatrixRotation
    {

        public static int[,] rotate(int[,] matrix) {
            int n = matrix.GetLength(0);
            for (int x = 0; x <= (int)Math.Ceiling((float)n / 2)-1; x++)
            {
                for (int y = 0; y <= (int)Math.Floor((float)n / 2)-1; y++)
                {
                    int temp = matrix[x, y];
                    matrix[x, y] = matrix[n-1-y,x];
                    matrix[n - 1 - y, x] = matrix[n-1-x, n-1-y];
                    matrix[n - 1 - x, n - 1 - y] = matrix[y, n-1-x];
                    matrix[y, n - 1 - x] = temp;
                }
                
            }
            return matrix;
        }
        public static int[,] rotate2(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i <= (int)Math.Ceiling((float)n / 2) - 1; i++)
            {
                for (int j = 0; j <= (int)Math.Floor((float)n / 2) - 1; j++)
                {
                    int[] temp = { -1, -1, -1, -1 };
                    int current_i = i;
                    int current_j = j;
                    for (int k = 0; k <= 3; k++)
                    {
                        temp[k] = matrix[current_i, current_j];
                        current_i = rotatesub_i(current_i, current_j, n);
                        current_j = rotatesub_j(current_i, current_j, n);
                    }
                    for (int k = 0; k <= 3; k++)
                    {
                        matrix[current_i, current_j] = temp[k];
                        current_i = rotatesub_i(current_i, current_j, n);
                        current_j = rotatesub_j(current_i, current_j, n);
                    }

                }


            }
            return matrix;
        }
        static int rotatesub_i(int i, int j, int n) {
            return j;
        }
        static int rotatesub_j(int i, int j, int n)
        {
            return n-1-i;
        }
    }
}
