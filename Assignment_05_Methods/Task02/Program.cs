using System.Xml.Linq;

namespace Task02
{
    public static class Program
    {
        public static void Main(String[] args)
        {
            char[] chars = FillArray.FillArrayFromConsole();

            //მოსაძებნი სიმბოლოს ინფუთი ცალკე მქონდა მარა ბოლოს Count() მეთოდში მომინდა გადამეცა ესე ფუნქციათ მეორე პარამეტრში და ასევე მესამე პარამეტრად out char symbol დავამატე რო Mainშიც მივწვდე და ვიცოდე ამ ფუნქციაში შეყვანილი სიმბოლო
            //მაინც მეთოდების და ფუნქციების დავალებაა :დ
            int count = CountOccurrencesInArray.Count(chars, () =>
            {
                char symbol;
                Console.Write("Enter symbol to count in the array: ");
                while (!char.TryParse(Console.ReadLine(), out symbol))
                {
                    Console.Write("Invalid input. Please enter a single character: ");
                }
                return symbol;
            }, out char symbol);

            PrintResult.Print(symbol, count);
        }
    }
}