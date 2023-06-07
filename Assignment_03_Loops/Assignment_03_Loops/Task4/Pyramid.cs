using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Pyramid
    {
        public static void GeneratePyramid(int number) 
        {
            for (int i = 1; i <= number; i++)
            {
                for (int k = 1; k <= number - i; k++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
