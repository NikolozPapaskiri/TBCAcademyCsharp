﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class PlayAgain
    {
        public static bool Ask()
        {
            Console.Write("\nDo you want to play again? (y/n): ");
            string input = Console.ReadLine();
            return input.Equals("y", StringComparison.OrdinalIgnoreCase);
        }
    }
}
