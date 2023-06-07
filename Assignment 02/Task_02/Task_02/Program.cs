namespace Task_02
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----------Rock/Paper/Scissor----------");
            Console.WriteLine(" 1 - Paper, 2 - Rock, 3 - Scissors");

            while (true)
            {
                Console.Write("Enter Player choice: ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int userChoice))
                {
                    if (userChoice >= 1 && userChoice <= 3)
                    {
                        // Generate computer's choice
                        int computerChoice = GenerateRandNum.RandNum();

                        // Compare choices
                        Console.WriteLine($"Computer: {NameOfChoice.GetNameOfChoice(computerChoice)}");
                        Console.WriteLine($"Player: {NameOfChoice.GetNameOfChoice(userChoice)}");

                        // Determine the winner
                        Winner.GetWinner(computerChoice, userChoice);
                    }
                    else
                    {
                        Console.WriteLine("Please choose 1, 2, or 3.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }

                if (!PlayAgain.Ask())
                {
                    break;
                }
            }

            Console.WriteLine("\nQuitting...");
        }
    }
}