using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11_OOP
{
    public static class CalculatorOperations
    {
        public static void PerformCalculations(ICalculator<int> calculator)
        {
            int a = calculator.ReadInput("Enter the first number: ");
            int b = calculator.ReadInput("Enter the second number: ");

            int result = calculator.Add(a, b);
            Console.WriteLine($"Addition: {a} + {b} = {result}");

            result = calculator.Subtract(a, b);
            Console.WriteLine($"Subtraction: {a} - {b} = {result}");

            result = calculator.Multiply(a, b);
            Console.WriteLine($"Multiplication: {a} * {b} = {result}");

        }

        public static void PerformCalculations(ICalculator<decimal> calculator)
        {
            decimal a = calculator.ReadInput("Enter the first number: ");
            decimal b = calculator.ReadInput("Enter the second number: ");

            decimal result = calculator.Add(a, b);
            Console.WriteLine($"Addition: {a} + {b} = {result}");

            result = calculator.Subtract(a, b);
            Console.WriteLine($"Subtraction: {a} - {b} = {result}");

            result = calculator.Multiply(a, b);
            Console.WriteLine($"Multiplication: {a} * {b} = {result}");
        }
    }

}
