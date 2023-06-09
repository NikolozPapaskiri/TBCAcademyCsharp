using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public static class ArrayConcatenator
    {
        public static int[] ConcatenateArrays(int[] array1, int[] array2)
        {
            int[] combinedArray = new int[array1.Length + array2.Length];
            int index = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                combinedArray[index] = array1[i];
                index++;
            }

            for (int i = 0; i < array2.Length; i++)
            {
                combinedArray[index] = array2[i];
                index++;
            }

            return combinedArray;
        }
    }
}
