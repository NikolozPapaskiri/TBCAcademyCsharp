using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class FillArray
    {
        public static char[] FillArrayFromConsole()
        {
            Console.Write("Enter the size of the array: ");
            int size;

            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer for the array size.");
            }

            char[] array = new char[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element at index {i}: ");
                char element;

                while (!char.TryParse(Console.ReadLine(), out element))
                {
                    Console.WriteLine("Invalid input. Please enter a single character.");
                }

                array[i] = element;
            }

            return array;
        }
    }
}
