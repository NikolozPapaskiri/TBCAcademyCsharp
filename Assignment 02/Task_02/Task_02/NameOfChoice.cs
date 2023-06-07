using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    public class NameOfChoice
    {
        public static string GetNameOfChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    return "Paper";
                case 2:
                    return "Rock";
                case 3:
                    return "Scissors";
                default:
                    return string.Empty;
            }
        }
    }
}
