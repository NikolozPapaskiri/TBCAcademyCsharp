﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class TryAgain
    {
        public static bool Ask()
        {
            Console.Write("\nDo you want to play again? (y/n): ");
            string input = Console.ReadLine();
            return input.Equals("y", StringComparison.OrdinalIgnoreCase);
        }
    }
}
