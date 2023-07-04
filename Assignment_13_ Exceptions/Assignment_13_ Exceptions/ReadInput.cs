using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13__Exceptions
{
    public class ReadInput
    {
        public static int ReadPositiveInteger()
        {
            int value;
            while (!int.TryParse(Console.ReadLine(), out value) || value <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer:");
            }
            return value;
        }
    }
}
