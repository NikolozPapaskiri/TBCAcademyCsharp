using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    static class MatrixUtils
    {
        public static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static int CalculateDeterminant(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (rows == 2 && cols == 2)
            {
                int a = matrix[0, 0];
                int b = matrix[0, 1];
                int c = matrix[1, 0];
                int d = matrix[1, 1];

                return (a * d) - (b * c);
            }
            else if (rows == 3 && cols == 3)
            {
                int a = matrix[0, 0];
                int b = matrix[0, 1];
                int c = matrix[0, 2];
                int d = matrix[1, 0];
                int e = matrix[1, 1];
                int f = matrix[1, 2];
                int g = matrix[2, 0];
                int h = matrix[2, 1];
                int i = matrix[2, 2];

                int det = (a * ((e * i) - (f * h))) - (b * ((d * i) - (f * g))) + (c * ((d * h) - (e * g)));
                return det;
            }

            return 0;
        }
    }
}
