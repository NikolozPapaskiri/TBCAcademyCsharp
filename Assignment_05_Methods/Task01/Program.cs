namespace Task01
{
    public static class Program
    {
        public static void Main(String[] args)
        {
            bool tryAgain = true;

            while (tryAgain)
            {
                Console.WriteLine("Enter a list of integers separated by spaces:");
                string input = Console.ReadLine();

                int[] numbers = InputParser.ParseInput(input);

                Console.WriteLine("Enter the index of the element to calculate the sum of its digits:");
                int index = InputValidator.ReadIndex(numbers.Length);

                int sum = DigitSumCalculator.CalculateDigitSum(numbers, index);
                Console.WriteLine($"The sum of digits of the element at index {index} is: {sum}");

                tryAgain = TryAgain.Ask();
            }

        }
    }
}