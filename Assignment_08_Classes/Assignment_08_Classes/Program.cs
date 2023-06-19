using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            int power;

            Console.WriteLine("Calculator App");
            Console.WriteLine("-----------------");

            a = TryAgainUtility.ReadDouble("Enter the first number: ");
            b = TryAgainUtility.ReadDouble("Enter the second number: ");

            Console.WriteLine();
            Console.WriteLine("Results:");
            Console.WriteLine($"Addition: {a} + {b} = {Calculator.Add(a, b)}");
            Console.WriteLine($"Subtraction: {a} - {b} = {Calculator.Subtract(a, b)}");
            Console.WriteLine($"Multiplication: {a} * {b} = {Calculator.Multiply(a, b)}");

            if (b != 0)
            {
                Console.WriteLine($"Division: {a} / {b} = {Calculator.Divide(a, b)}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }

            power = TryAgainUtility.ReadNonNegativeInt("Enter the power: ");

            Console.WriteLine($"Power: {a} ^ {power} = {Calculator.Pow(a, power)}");

            if (a >= 0)
            {
                Console.WriteLine($"Square Root of {a}: {Calculator.Sqrt(a)}");
            }
            else
            {
                Console.WriteLine("Cannot calculate square root of a negative number.");
            }

            Console.ReadLine();
        }
    }
}
