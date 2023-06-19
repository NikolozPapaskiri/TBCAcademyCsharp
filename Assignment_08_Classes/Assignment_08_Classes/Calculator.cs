using System;

namespace CalculatorApp
{
    public static class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }

            return a / b;
        }

        public static double Pow(double number, int power)
        {
            if (power < 0)
            {
                throw new ArgumentException("Power must be a non-negative integer.");
            }

            double result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }

        public static double Sqrt(double number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Cannot calculate square root of a negative number.");
            }

            double result = number;
            double epsilon = 1e-15;

            while (Math.Abs(result - number / result) > epsilon * result)
            {
                result = (result + number / result) / 2;
            }

            return result;
        }
    }
}
