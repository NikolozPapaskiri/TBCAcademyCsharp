using System;

namespace Task06
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("== Matrix Multiplication ==");

            int rows1 = UserInputUtils.GetPositiveInteger("Enter the number of rows for the first matrix: ");
            int cols1 = UserInputUtils.GetPositiveInteger("Enter the number of columns for the first matrix: ");
            int rows2 = UserInputUtils.GetPositiveInteger("Enter the number of rows for the second matrix: ");
            int cols2 = UserInputUtils.GetPositiveInteger("Enter the number of columns for the second matrix: ");

            if (cols1 != rows2)
            {
                Console.WriteLine("Invalid input. The number of columns in the first matrix must be equal to the number of rows in the second matrix.");
                return;
            }

            int[,] matrix1 = UserInputUtils.GetMatrixElements(rows1, cols1);
            int[,] matrix2 = UserInputUtils.GetMatrixElements(rows2, cols2);

            Console.WriteLine("Matrix 1:");
            MatrixUtils.PrintMatrix(matrix1);

            Console.WriteLine("Matrix 2:");
            MatrixUtils.PrintMatrix(matrix2);

            int[,] product = MatrixUtils.MultiplyMatrices(matrix1, matrix2);

            Console.WriteLine("Product Matrix:");
            MatrixUtils.PrintMatrix(product);
        }
    }
}

