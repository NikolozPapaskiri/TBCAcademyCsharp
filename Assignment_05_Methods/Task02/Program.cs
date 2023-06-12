using System.Xml.Linq;

namespace Task02
{
    public static class Program
    {
        public static void Main(String[] args)
        {
            char[] chars = FillArray.FillArrayFromConsole();

            char symbol = ValidateSymbolInput.GetSymbolFromInput();
            int count = CountOccurrencesInArray.Count(chars, symbol);

            PrintResult.Print(symbol, count);
        }
    }
}