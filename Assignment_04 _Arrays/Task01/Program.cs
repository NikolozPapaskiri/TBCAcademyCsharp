using System;

namespace Task01
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the size of the array: ");
            int size;

            while (!int.TryParse(Console.ReadLine(), out size) || size < 1)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive integer.");
                Console.Write("Enter the size of the array: ");
            }

            int[] arr = new int[size];

            Console.WriteLine($"Enter {size} numbers:");

            for (int i = 0; i < size; i++)
            {
                int num;

                Console.Write($"Enter number {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    Console.Write($"Enter number {i + 1}: ");
                }

                arr[i] = num;
            }


            ArraySorter.SortArray(arr);

            Console.WriteLine("\nSorted array:");

            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}
