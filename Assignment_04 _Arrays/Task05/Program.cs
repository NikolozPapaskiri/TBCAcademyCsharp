using System;

namespace Task05
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("== Determinant Calculator ==");

            int choice = UserInputUtils.GetChoice("Choose matrix size:\n1. 2 x 2\n2. 3 x 3\n");

            int[,] matrix;

            if (choice == 1)
            {
                matrix = UserInputUtils.GetMatrixElements(2, 2);
            }
            else
            {
                matrix = UserInputUtils.GetMatrixElements(3, 3);
            }

            Console.WriteLine("You entered matrix:");
            MatrixUtils.PrintMatrix(matrix);

            int determinant = MatrixUtils.CalculateDeterminant(matrix);
            Console.WriteLine("Determinant is: " + determinant);
        }
    }

}
