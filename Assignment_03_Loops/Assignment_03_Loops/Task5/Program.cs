namespace Task5
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            bool play = true;

            while (play)
            {

                Console.Write("\nEnter 1st number: ");

                if (int.TryParse(Console.ReadLine(), out int firstNumber) && firstNumber >= 0)
                {
                    while (true) //ამ ვაილში ვატრიალებ რო მე2 რიცხვის შეყვანისას ვალიდაციის დარტყმაზე მარტო მე2 რიცხვი შეგაყვანინოს თავიდან და არა 1ლიც
                    {
                        Console.Write("Enter 2nd number: ");

                        if (int.TryParse(Console.ReadLine(), out int secondNumber) && secondNumber > firstNumber)
                        {
                            Console.WriteLine();
                            Game.PlayGame(firstNumber, secondNumber);

                            if (!TryAgain.Ask())
                            {
                                play = false;//ამითი 2ვე ვაილიდან გამოვა და თამაშს მორჩება
                                break;
                            }
                            else
                            {
                                break;//ამითი ამ ვაილიდან გამოვა და თამაშს თავიდან დაიწყებს
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please enter a positive integer that is more than first number.");
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("Please enter a positive integer.");
                }
            }
        }
    }
}