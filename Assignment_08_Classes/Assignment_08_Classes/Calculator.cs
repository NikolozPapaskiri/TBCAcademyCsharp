using System;

namespace CalculatorApp
{
    public static class Calculator
    {
        private const double Epsilon = 1e-15;

        public static double Add(double a, double b) => RoundToTwoDecimals(a + b);

        public static double Subtract(double a, double b) => RoundToTwoDecimals(a - b);

        public static double Multiply(double a, double b) => RoundToTwoDecimals(a * b);

        public static double Divide(double a, double b)
        {
            if (Math.Abs(b) < Epsilon)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }

            return RoundToTwoDecimals(a / b);
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

            return RoundToTwoDecimals(result);
        }

        public static double Sqrt(double number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Cannot calculate square root of a negative number.");
            }

            double result = number;

            while (Math.Abs(result - number / result) > Epsilon * result)
            {
                result = (result + number / result) / 2;
            }

            return RoundToTwoDecimals(result);
        }

        private static double RoundToTwoDecimals(double number)
        {
            return Math.Round(number, 2);
        }
    }
}
