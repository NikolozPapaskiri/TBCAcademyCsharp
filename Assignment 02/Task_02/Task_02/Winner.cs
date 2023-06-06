using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    public class Winner
    {
        public static void GetWinner(int computer, int user)
        {
            if (user == computer)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((user == 1 && computer == 3) ||
                     (user == 1 && computer == 2) ||
                     (user == 3 && computer == 2))
            {
                Console.WriteLine("Computer won!");
            }
            else
            {
                Console.WriteLine("Player won!");
            }
        }
    }
}
