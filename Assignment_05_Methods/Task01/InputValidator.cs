using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public class InputValidator
    {
        public static int ReadIndex(int length)
        {
            int index;

            while (true)
            {
                Console.WriteLine($"Enter the index (0 to {length - 1}):");
                string input = Console.ReadLine();

                if (int.TryParse(input, out index) && index >= 0 && index < length)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid index.");
                }
            }

            return index;
        }
    }
}
