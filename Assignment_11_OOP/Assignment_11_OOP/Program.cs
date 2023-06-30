namespace Assignment_11_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integer Calculator:");
            ICalculator<int> integerCalculator = new IntegerCalculator();
            CalculatorOperations.PerformCalculations(integerCalculator);

            Console.WriteLine("\nDecimal Calculator:");
            ICalculator<decimal> decimalCalculator = new DecimalCalculator();
            CalculatorOperations.PerformCalculations(decimalCalculator);

            Console.ReadLine();
        }
    }
}