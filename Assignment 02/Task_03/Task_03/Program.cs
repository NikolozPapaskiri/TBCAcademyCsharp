using System.Reflection;

namespace Task_03
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a year of birth: ");
            if (int.TryParse(Console.ReadLine(), out int year) && year >= 0)
            {
                string luckyYearName = LuckyYear.GetLuckyYearName(year);
                Console.WriteLine($"The lucky year for year {year} is: {luckyYearName}");
            }
            else
            {
                Console.WriteLine("Please enter a valid non-negative year.");
            }
        }
    }
}