using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    public class LongestIncreasingSequenceFinder
    {
        public int[] FindLongestIncreasingSequence(int[] array)
        {
            int maxLength = 0;
            int maxStartIndex = 0;
            int currentLength = 1;
            int currentStartIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    currentLength++;

                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        maxStartIndex = currentStartIndex;
                    }
                }
                else
                {
                    currentLength = 1;
                    currentStartIndex = i;
                }
            }

            int[] longestSequence = new int[maxLength];
            Array.Copy(array, maxStartIndex, longestSequence, 0, maxLength);
            return longestSequence;
        }
    }
}
