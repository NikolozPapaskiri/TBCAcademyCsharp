using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public class TryAgain
    {
        public static bool Ask()
        {
            while (true)
            {
                Console.WriteLine("Do you want to try again? (Y/N)");
                string input = Console.ReadLine();

                if (string.Equals(input, "Y", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else if (string.Equals(input, "N", StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'Y' for Yes or 'N' for No.");
                }
            }
        }
    }
}
