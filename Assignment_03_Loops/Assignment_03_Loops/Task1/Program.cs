using System.Reflection;

namespace Task_01
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a number: ");
                var userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int number))//ამოწმებს რო ინტეჯერი ჩაწერა თუ არა მომხმარებელმა
                {
                    bool isPrime = PrimeNumbers.IsPrime(number);

                    if (isPrime)
                    {
                        Console.WriteLine($"{number} is prime.");
                    }
                    else
                    {
                        Console.WriteLine($"{number} isn't prime.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer.");
                }

                if (!TryAgain.Ask())
                {
                    break;
                }
            }

        }
    }
}