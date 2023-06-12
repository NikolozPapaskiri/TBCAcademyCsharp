using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class ValidateSymbolInput
    {
        public static char GetSymbolFromInput()
        {
            char symbol;
            bool isValidInput = false;

            do
            {
                Console.Write("Enter symbol to count in the array: ");
                isValidInput = char.TryParse(Console.ReadLine(), out symbol);
                if (!isValidInput)
                {
                    Console.Write("Invalid input. Please enter a single character: ");
                }
            } while (!isValidInput);

            return symbol;
        }
    }
}
