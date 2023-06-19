using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListImplementation
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
                else//throw new ArgumentException არმინდა რო დაიქრაშოს აპლიკაცია როცა ერორზე გავა ვალიდაცია
                    //throw new ArgumentException("Name cannot be null or empty.");
                    Console.WriteLine("Error: Name cannot be null, empty, or whitespace.");
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;
                else//throw new ArgumentException არმინდა რო დაიქრაშოს აპლიკაცია როცა ერორზე გავა ვალიდაცია
                    //throw new ArgumentException("Age cannot be negative.");
                    Console.WriteLine("Error: Age cannot be than 0.");
            }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }
}