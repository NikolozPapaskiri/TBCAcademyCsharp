using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class SingleCharInput
    {
        public static char ValidateSingleCharacterInput(string prompt, string errorMessage)
        {
            char symbol;

            Console.Write(prompt);

            while (!char.TryParse(Console.ReadLine(), out symbol))
            {
                Console.Write(errorMessage);
            };

            return symbol;
        }

    }
}
