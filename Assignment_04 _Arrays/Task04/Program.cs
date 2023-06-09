using System;

namespace Task04
{
    class Program
    {
        static void Main()
        {
            int size = 0;
            bool isValidSize = false;

            while (!isValidSize)
            {
                Console.Write("Enter the size of the array: ");
                isValidSize = int.TryParse(Console.ReadLine(), out size);

                if (!isValidSize || size <= 0)
                {
                    Console.WriteLine("Invalid size. Please enter a positive integer.");
                    isValidSize = false;
                }
            }

            int[] array = new int[size];

            Console.WriteLine($"Enter {size} numbers:");

            for (int i = 0; i < size; i++)
            {
                bool isValidNumber = false;

                while (!isValidNumber)
                {
                    Console.Write($"Enter number {i + 1}: ");
                    isValidNumber = int.TryParse(Console.ReadLine(), out int number);

                    if (!isValidNumber)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                    }
                    else
                    {
                        array[i] = number;
                    }
                }
            }

            LongestIncreasingSequenceFinder finder = new LongestIncreasingSequenceFinder();
            int[] longestSequence = finder.FindLongestIncreasingSequence(array);

            Console.Write("Longest increasing sequence: ");
            foreach (int num in longestSequence)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            }
    }
}

