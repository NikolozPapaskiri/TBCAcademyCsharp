using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public static class ArrayInput
    {
        public static int[] GetIntArrayInput(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    Console.Write($"Enter element {i + 1}: ");
                }
            }

            return array;
        }
    }
}