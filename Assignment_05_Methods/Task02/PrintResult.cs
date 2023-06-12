using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class PrintResult
    {
        public static void Print(char symbol, int count)
        {
            Console.WriteLine($"Symbol '{symbol}' appears {count} times in the array.");
        }
    }
}
