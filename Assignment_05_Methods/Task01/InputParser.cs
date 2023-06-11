using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public class InputParser
    {
        public static int[] ParseInput(string input)
        {
            int[] numbers;

            while (true)
            {
                string[] tokens = input.Split(' ');
                numbers = new int[tokens.Length];

                bool validInput = true;

                for (int i = 0; i < tokens.Length; i++)
                {
                    if (int.TryParse(tokens[i], out int number))
                    {
                        numbers[i] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input: '{tokens[i]}' is not a valid integer.");
                        validInput = false;
                        break;
                    }
                }

                if (validInput)
                {
                    break;
                }

                Console.WriteLine("Please try again. Enter a list of integers separated by spaces:");
                input = Console.ReadLine();
            }

            return numbers;
        }
    }
}
