using System;

namespace Task02
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the size of the first array: ");
            int size1;

            while (!int.TryParse(Console.ReadLine(), out size1) || size1 <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive integer.");
                Console.Write("Enter the size of the first array: ");
            }

            string[] array1 = new string[size1];

            Console.WriteLine($"Enter {size1} elements for the first array:");

            for (int i = 0; i < size1; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                array1[i] = Console.ReadLine();
            }

            Console.Write("\nEnter the size of the second array: ");
            int size2;

            while (!int.TryParse(Console.ReadLine(), out size2) || size2 <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive integer.");
                Console.Write("Enter the size of the second array: ");
            }

            int[] array2 = new int[size2];

            Console.WriteLine($"Enter {size2} elements for the second array:");

            for (int i = 0; i < size2; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out array2[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    Console.Write($"Enter element {i + 1}: ");
                }
            }

            string[] combinedArray = ArrayHelper.CombineArrays(array1, array2);

            Console.WriteLine("\nCombined array:");

            foreach (string element in combinedArray)
            {
                Console.Write(element + ", ");
            }
        }
    }
}

