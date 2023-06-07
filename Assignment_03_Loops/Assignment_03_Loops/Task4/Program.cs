namespace Task4
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter number: ");

                if(int.TryParse(Console.ReadLine(), out int userInput) && userInput > 0)
                {
                    Pyramid.GeneratePyramid(userInput);
                }
                else
                {
                    Console.WriteLine("Please enter a positive integer.");
                }

                if (!TryAgain.Ask())
                {
                    break;
                }
            }
        }
    }

}