using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public class DigitSumCalculator
    {
        public static int CalculateDigitSum(int[] numbers, int index)
        {
            int number = numbers[index];
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }
}
