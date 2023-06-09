using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    public static class UserInputUtils
    {
        public static int GetChoice(string message)
        {
            int choice = default;
            bool isValidChoice = false;

            while (!isValidChoice)
            {
                Console.Write(message);
                string choiceInput = Console.ReadLine();
                isValidChoice = int.TryParse(choiceInput, out choice);

                if (!isValidChoice)
                {
                    Console.WriteLine("Invalid choice. Please enter a valid integer.");
                }
            }

            return choice;
        }

        public static int[,] GetMatrixElements(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            Console.WriteLine("Enter matrix elements:");

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