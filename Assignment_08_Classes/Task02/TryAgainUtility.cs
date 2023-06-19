using System;

namespace BankingServices
{
    public static class TryAgainUtility
    {
        public static double ReadDouble(string prompt)
        {
            double value;
            bool isValidInput = false;

            do
            {
                Console.Write(prompt);
                isValidInput = double.TryParse(Console.ReadLine(), out value);

                if (!isValidInput)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

            } while (!isValidInput);

            return value;
        }

        public static int ReadNonNegativeInt(string prompt)
        {
            int value;
            bool isValidInput = false;

            do
            {
                Console.Write(prompt);
                isValidInput = int.TryParse(Console.ReadLine(), out value);

                if (!isValidInput || value < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a non-negative integer.");
                    isValidInput = false;
                }

            } while (!isValidInput);

            return value;
        }
    }
}
