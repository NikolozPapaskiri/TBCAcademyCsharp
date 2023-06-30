using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11_OOP
{
    public class DecimalCalculator : ICalculator<decimal>
    {
        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public decimal Subtract(decimal a, decimal b)
        {
            return a - b;
        }

        public decimal Multiply(decimal a, decimal b)
        {
            return a * b;
        }

        public decimal ReadInput(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (decimal.TryParse(input, out decimal value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
        }
    }
}

