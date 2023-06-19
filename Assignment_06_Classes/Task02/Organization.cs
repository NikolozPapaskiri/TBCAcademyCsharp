using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListImplementation
{
    public class Organization
    {
        private string name;
        private string address;

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

        public string Address
        {
            get { return address; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    address = value;
                else//throw new ArgumentException არმინდა რო დაიქრაშოს აპლიკაცია როცა ერორზე გავა ვალიდაცია
                   // throw new ArgumentException("Address cannot be null or empty.");
                    Console.WriteLine("Error: Address cannot be null, empty, or whitespace.");
            }
        }

        public Organization(string name, string address)
        {
            Name = name;
            Address = address;
        }

    }
}
