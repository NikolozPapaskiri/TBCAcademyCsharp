using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class CountOccurrencesInArray
    {
        public static int Count(char[] array, char symbol)
        {
            int count = 0;

            foreach (char element in array)
            {
                if (element == symbol)
                {
                    count++;
                }
            }

            return count;
        }

    }
}
