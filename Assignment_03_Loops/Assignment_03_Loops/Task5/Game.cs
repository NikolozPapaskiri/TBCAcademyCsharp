using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Game
    {
        public static void PlayGame(int min, int max)
        {
            Random random = new Random();
            int randNum = random.Next(min, max);

            while (true)
            {
                Console.Write("Guess the number: ");

                if (int.TryParse(Console.ReadLine(), out int num) && num > -1)
                {
                    if(num == randNum)
                    {
                        Console.WriteLine($"Congrats, you guessed the number! It was {randNum}");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a positive integer");
                }
                
            }
        }
    }
}
