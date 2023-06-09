using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public static class ArrayHelper
    {
        public static string[] CombineArrays(string[] array1, int[] array2)
        {
            int maxLength = Math.Max(array1.Length, array2.Length);
            string[] combinedArray = new string[maxLength];

            for (int i = 0; i < maxLength; i++)
            {
                if (i < array1.Length)
                {
                    combinedArray[i] = array1[i];
                }

                if (i < array2.Length)
                {
                    combinedArray[i] += " " + array2[i];
                }
            }

            return combinedArray;
        }
    }

}
