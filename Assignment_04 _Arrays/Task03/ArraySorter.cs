using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public static class ArraySorter
    {
        public static void SortArray(int[] array, string sortDirection)
        {
            int temp;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if ((sortDirection == "ASC" && array[i] > array[j]) ||
                        (sortDirection == "DESC" && array[i] < array[j]))
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }

}
