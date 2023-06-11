using System.Xml.Linq;

namespace Task02
{
    public static class Program
    {
        public static void Main(String[] args)
        {
            char[] chars = FillArray.FillArrayFromConsole();
            char symbol = default;

            Console.Write("Enter symbol to count in array: ");
            while (!char.TryParse(Console.ReadLine(), out symbol))
            {
                Console.WriteLine("Invalid input. Please enter a single character.");
            }

            int count = CountOccurrencesInArray.Count(chars, symbol);
            PrintResult.Print(symbol, count);
        }
    }
}