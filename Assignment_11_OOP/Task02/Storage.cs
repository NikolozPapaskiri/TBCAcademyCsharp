using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class Storage<T> : IStorage<T>
    {
        private List<T> items;

        public Storage()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
            Console.WriteLine("Item added to the storage.");
        }

        public void Remove(T item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
                Console.WriteLine("Item removed from the storage.");
            }
            else
            {
                Console.WriteLine("Item not found in the storage.");
            }
        }

        public bool Contains(T item)
        {
            return items.Contains(item);
        }

        public void Update(T item, T newValue)
        {
            int index = items.IndexOf(item);
            if (index != -1)
            {
                items[index] = newValue;
                Console.WriteLine("Item updated successfully.");
            }
            else
            {
                Console.WriteLine("Item not found in the storage.");
            }
        }

        public void ShowList()
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }

}
