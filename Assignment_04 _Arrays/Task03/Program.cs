using System;

namespace Task03
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

            int[] array1 = ArrayInput.GetIntArrayInput(size1);

            Console.Write("\nEnter the size of the second array: ");
            int size2;

            while (!int.TryParse(Console.ReadLine(), out size2) || size2 <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive integer.");
                Console.Write("Enter the size of the second array: ");
            }

            int[] array2 = ArrayInput.GetIntArrayInput(size2);

            Console.Write("\nEnter the sort direction (ASC or DESC): ");
            string sortDirection = Console.ReadLine().ToUpper();

            while (sortDirection != "ASC" && sortDirection != "DESC")
            {
                Console.WriteLine("Invalid input. Please enter 'ASC' or 'DESC'.");
                Console.Write("Enter the sort direction (ASC or DESC): ");
                sortDirection = Console.ReadLine().ToUpper();
            }

            int[] combinedArray = ArrayConcatenator.ConcatenateArrays(array1, array2);
            ArraySorter.SortArray(combinedArray, sortDirection);

            Console.WriteLine("\nSorted Concatenated Array:");

            foreach (int element in combinedArray)
            {
                Console.Write(element + " ");
            }
        }
    }
}

