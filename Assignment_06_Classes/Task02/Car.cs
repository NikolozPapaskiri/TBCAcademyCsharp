using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListImplementation
{
    public class Car
    {
        private const int MinimumYear = 1900;
        private const int MaximumYear = 2023;

        private string brand;
        private string model;
        private int year;
        private string type;

        private static readonly string[] ValidTypes = { "Sedan", "SUV", "Sports Car", "Hatchback", "Convertible" };

        public string Brand
        {
            get { return brand; }
            set
            {
                if (ValidateString(value))
                    brand = value;
                else//throw new ArgumentException არმინდა რო დაიქრაშოს აპლიკაცია როცა ერორზე გავა ვალიდაცია
                    //throw new ArgumentException("Error: Brand cannot be null, empty, or whitespace.");
                    Console.WriteLine("Error: Brand cannot be null, empty, or whitespace.");
            }
        }

        public string Model
        {
            get { return model; }
            set
            {
                if (ValidateString(value))
                    model = value;
                else//throw new ArgumentException არმინდა რო დაიქრაშოს აპლიკაცია როცა ერორზე გავა ვალიდაცია
                    //throw new ArgumentException("Invalid model.");
                    Console.WriteLine("Error: Model cannot be null, empty, or whitespace.");
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (ValidateYear(value))
                    year = value;
                else//throw new ArgumentException არმინდა რო დაიქრაშოს აპლიკაცია როცა ერორზე გავა ვალიდაცია
                    //throw new ArgumentException("Invalid year.");
                    Console.WriteLine("Error: Year has to be between 1900 and 2023.");
            }
        }

        public string Type
        {
            get { return type; }
            set
            {
                if (ValidateType(value))
                    type = value;
                else//throw new ArgumentException არმინდა რო დაიქრაშოს აპლიკაცია როცა ერორზე გავა ვალიდაცია
                    //throw new ArgumentException("Invalid car type.");
                    type = "Unknown";
            }
        }

        public Car(string brand, string model, int year, string type)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Type = type;
        }

        private bool ValidateString(string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        private bool ValidateYear(int year)
        {
            return year >= MinimumYear && year <= MaximumYear;
        }

        private bool ValidateType(string type)
        {
            return ValidTypes.Contains(type);
        }
    }
}
