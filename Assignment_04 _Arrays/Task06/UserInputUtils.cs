using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    public static class UserInputUtils
    {
        public static int GetPositiveInteger(string message)
        {
            int number = default;
            bool isValidNumber = false;

            while (!isValidNumber)
            {
                Console.Write(message);
                string numberInput = Console.ReadLine();

                if (!int.TryParse(numberInput, out number) || number <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                }
                else
                {
                    isValidNumber = true;
                }
            }

            return number;
        }

        public static int[,] GetMatrixElements(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            Console.WriteLine($"Enter matrix elements ({rows} x {cols}):");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    bool isValidNumber = false;

                    while (!isValidNumber)
                    {
                        Console.Write($"[{i}][{j}]: ");
                        string numberInput = Console.ReadLine();

                        if (!int.TryParse(numberInput, out int number))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid integer.");
                        }
                        else
                        {
                            matrix[i, j] = number;
                            isValidNumber = true;
                        }
                    }
                }
            }

            return matrix;
        }
    }
}