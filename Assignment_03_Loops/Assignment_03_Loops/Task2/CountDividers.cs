using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class CountDividers
    {
        public static int GetNumberOfDividers(int number) 
        {
            int count = 0;
            for(int i = 1; i <= number; i++)
            {
                if(number % i == 0)
                    count++;
            }
            return count;
        }
    }
}
