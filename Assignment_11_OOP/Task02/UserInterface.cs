using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public static class UserInterface
    {
        public static void Run(Storage<string> storage)
        {
            while (true)
            {
                Console.WriteLine("Storage Operations");
                Console.WriteLine("------------------");
                Console.WriteLine("1. Add item");
                Console.WriteLine("2. Remove item");
                Console.WriteLine("3. Update item");
                Console.WriteLine("4. Show list");
                Console.WriteLine("5. Exit");
                Console.WriteLine();

                Console.Write("Enter your choice (1-4): ");
                string choiceStr = Console.ReadLine();
                int choice;

                if (int.TryParse(choiceStr, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter the item to add: ");
                            string itemToAdd = Console.ReadLine();
                            storage.Add(itemToAdd);
                            break;
                        case 2:
                            Console.Write("Enter the item to remove: ");
                            string itemToRemove = Console.ReadLine();
                            storage.Remove(itemToRemove);
                            break;
                        case 3:
                            Console.Write("Enter the item to update: ");
                            string itemToUpdate = Console.ReadLine();
                            if (storage.Contains(itemToUpdate))
                            {
                                Console.Write("Enter the new value for the item: ");
                                string newItemValue = Console.ReadLine();
                                storage.Update(itemToUpdate, newItemValue);
                            }
                            else
                            {
                                Console.WriteLine("Item not found in the storage.");
                            }
                            break;
                        case 4:
                            storage.ShowList();
                            break;
                        case 5:
                            Console.WriteLine("Exiting the program...");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                }

                Console.WriteLine();
            }
        }
    }
}
