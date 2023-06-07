namespace Task1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Temperature is: ");
            String userInputString = Console.ReadLine();
            int userInputNum;

            while (String.IsNullOrEmpty(userInputString) || userInputString == " ")
            {
                Console.Write("Input shouldn't be empty. Try again: ");

                userInputString = Console.ReadLine();
            }

            while (!int.TryParse(userInputString, out userInputNum))
            {
                Console.Write("Input has to be integer. Try again: ");

                userInputString = Console.ReadLine();
            }

            switch (userInputNum)
            {
                case <= 0:
                    {
                        Console.WriteLine("Freezing");
                        break;
                    }
                case <= 30:
                    {
                        Console.WriteLine("Great Weather");
                        break;
                    }
                case > 30:
                    {
                        Console.WriteLine("It's Hot");
                        break;
                    }
            }

        }
    }
}