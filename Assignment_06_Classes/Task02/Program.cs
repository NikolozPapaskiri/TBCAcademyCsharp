using CustomListImplementation.CustomListImplementation;
using System;

namespace CustomListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<Person> personList = new CustomList<Person>();
            personList.AddElement(new Person("Nika", 25));//AddElement
            personList.AddElement(new Person("Luka", 30));//AddElement
            personList.AddElement(new Person("Lasha", 35));//AddElement

            Console.WriteLine("Person List:");
            foreach (Person person in personList)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }
            Console.WriteLine();

            CustomList<Organization> organizationList = new CustomList<Organization>();
            organizationList.AddElement(new Organization("ABC Company", "123"));//AddElement
            organizationList.AddElement(new Organization("XYZ Corporation", "456"));//AddElement

            Console.WriteLine("Organization List:");
            foreach (Organization organization in organizationList)
            {
                Console.WriteLine($"{organization.Name}, {organization.Address}");
            }
            Console.WriteLine();

            CustomList<Car> carList = new CustomList<Car>();
            carList.AddElement(new Car("BMW", "M4", 2022, "SUV"));//AddElement
            carList.AddElement(new Car("Mercedes", "c63", 2020, "Sport"));//Brand-ში ჩაუწერს Unknown-ს რადგან ესეთი type არ გვაქ კლასში ტიპის ლისტში

            Console.WriteLine("Car List before adding another list in it:");
            foreach (Car car in carList)
            {
                Console.WriteLine($"{car.Brand}, {car.Model}, {car.Year}, {car.Type}");
            }

            CustomList<Car> anotherCarList = new CustomList<Car>();
            anotherCarList.AddElement(new Car("Honda", "Civic", 2022, "Sedan"));//AddElement
            anotherCarList.AddElement(new Car("Ford", "Mustang", 2020, "Sports Car"));//AddElement

            carList.AddList(anotherCarList);//AddList

            Console.WriteLine("Car List after adding another list in it:");
            foreach (Car car in carList)
            {
                Console.WriteLine($"{car.Brand}, {car.Model}, {car.Year}, {car.Type}");
            }

            Console.WriteLine();

            Car car4 = new Car("Chevrolet", "Cruze", 2023, "Sedan");
            bool isInserted = carList.InsertElement(car4, 2);//InsertElement
            Console.WriteLine("InsertElement: " + isInserted);

            CustomList<Car> additionalCarList = new CustomList<Car>();
            additionalCarList.AddElement(new Car("BMW", "X5", 2022, "SUV"));//AddElement
            additionalCarList.AddElement(new Car("Audi", "A4", 2021, "Sedan"));//AddElement

            bool isListInserted = carList.InsertList(additionalCarList, 4);
            Console.WriteLine("InsertList: " + isListInserted);

            Car retrievedCar = carList.GetElement(3);//GetElement
            Console.WriteLine("GetElement: " + (retrievedCar != null ? retrievedCar.Brand + " " + retrievedCar.Model : "Invalid position"));

            CustomList<Car> sublist = carList.GetList(2, 3);//GetList
            Console.WriteLine("GetList:");
            if (sublist != null)
            {
                foreach (Car car in sublist)
                {
                    Console.WriteLine(car.Brand + " " + car.Model);
                }
            }
            else
            {
                Console.WriteLine("Invalid position");
            }

            Car foundCar = carList.Find(car => car.Brand == "BMW");
            Console.WriteLine("Find: " + (foundCar != null ? foundCar.Brand + " " + foundCar.Model : "Car not found"));

            bool isRemoved = carList.RemoveElement(anotherCarList[1]);
            Console.WriteLine("RemoveElement: " + isRemoved);

            bool isListRemoved = carList.RemoveList(additionalCarList);
            Console.WriteLine("RemoveList: " + isListRemoved);

            carList.Clear();
            Console.WriteLine("Count after clearing: " + carList.Count);

            Console.ReadLine();
        }
    }
}



/*
 * შექმნეთი List-ის იმპლემენტაცია C# ში (CustomList კლასი), გამოიყენეთ კლასი და ინდექსერი. ინდექსერით ემუშავეთ მასივს. List-ი ამუშავებდეს კონკრეტული ტიპის ელემენტებს, მაგალითად, პიროვნებების List-ი (PersonList), ორგანიზაციების List-ი (OrganizationList) და სხვა. 

CustomList კლასში უნდა იყოს შემდეგი მეთოდები, ასევე თქვენს მიერ იმპლემენტირებული:
AddElement - მეთოდი დაამატებს გადაცემულ ელემენტს სიაში ბოლოდან; 
AddList - მეთოდი დაამატებს გადაცემულ სიას არსებულ სიაში ბოლოდან;
InsertElement - მეთოდი დაამატებს გადაცემულ ელემენტის სიაში მითითებულ პოზიციაზე. თუ გადაცემული პოზიცია ცდება სიის ზღვრებს უნდა დაბრუნდეს false, სხვა შემთხვევაში true;
InsertList - მეთოდი დაამატებს გადაცემულ სიას არსებულ სიაში მითითებულ პოზიციაზე. თუ გადაცემული პოზიცია ცდება სიის ზღვრებს უნდა დაბრუნდეს false, სხვა შემთხვევაში true;
GetElement - მეთოდი დააბრუნებს მითითებულ პოზიციაზე მდგომ ელემენტს. თუ გადაცემული პოზიცია ცდება სიის ზღვრებს უნდა დაბრუნდეს false, სხვა შემთხვევაში true;
GetList - მეთოდი დააბრუნებს მითითებული პოზიციიდან ელემენტების მითითებულ რაოდენობას. თუ გადაცემული პოზიცია ცდება სიის ზღვრებს უნდა დაბრუნდეს false, სხვა შემთხვევაში true;
RemoveElement - მეთოდი წაშლის გადაცემულ ელემენტს სიიდან; 
RemoveList - მეთოდი წაშლის გადაცემულ ელემენტებს სიიდან;
Clear - მეთოდი წაშლის სიაში არსებულ ყველა ელემენტს;
Find - მეთოდი გადაცემული პარამეტრით მოძებნის შესაბამის ელემენტს სიაში და დააბრუნებს მას;
List-ს უნდა ქონდეს შემდეგი Property-ები:
Count - 

დაგვიბრუნებს ელემენტების რაოდენობას სიაში;

*/