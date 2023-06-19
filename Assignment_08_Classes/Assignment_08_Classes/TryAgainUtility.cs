using System;

namespace CalculatorApp
{
    public static class TryAgainUtility
    {
        public static double ReadDouble(string prompt)
        {
            double result;
            bool isValidInput = false;

            do
            {
                Console.Write(prompt);

                if (double.TryParse(Console.ReadLine(), out result))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

            } while (!isValidInput);

            return result;
        }

        public static int ReadNonNegativeInt(string prompt)
        {
            int result;
            bool isValidInput = false;

            do
            {
                Console.Write(prompt);

                if (int.TryParse(Console.ReadLine(), out result) && result >= 0)
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a non-negative integer.");
                }

            } while (!isValidInput);

            return result;
        }
    }
}
