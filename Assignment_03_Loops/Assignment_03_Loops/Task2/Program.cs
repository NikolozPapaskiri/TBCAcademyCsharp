namespace Task2
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
                    if (number > 0)//ამოწმებს რო დადებიტი ინტეჯერი ჩაწერა თუ არა მომხმარებელმა
                    {
                        Console.WriteLine($"Number of dividers for {number} is {CountDividers.GetNumberOfDividers(number)}");
                    }
                    else
                    {
                        Console.WriteLine("Please enter a positive integer.");
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