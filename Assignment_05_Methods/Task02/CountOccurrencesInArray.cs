using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class CountOccurrencesInArray
    {
        public static int Count(char[] array, Func<char> inputSymbolLogic, out char symbol)//გადავცემ ერეის, ფუნქციას რომელიც მოსაძებნი ჩარის შესაყვანდაა საჭირო, და ბოლოს ვაბრუნებ ამ სიმბოლოს რაც შევიყვანეთ ფუნქციით რო მეინშიც მივწვდე ამ სიმბოლოს
        {
            symbol = inputSymbolLogic();
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