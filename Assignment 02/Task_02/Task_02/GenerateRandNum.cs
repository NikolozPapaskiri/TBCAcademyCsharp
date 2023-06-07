using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    public class GenerateRandNum
    {
        public static int RandNum()
        {
            Random rand = new Random();
            return rand.Next(1, 4);
        }
    }
}
