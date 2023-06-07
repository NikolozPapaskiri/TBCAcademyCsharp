using System.Diagnostics;

namespace Task3
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                int sum = 0, count = 0;

                Console.Write("Enter a number: ");

                if (int.TryParse(Console.ReadLine(), out int number))//ამოწმებს რო ინტეჯერი ჩაწერა თუ არა მომხმარებელმა
                {
                    Console.WriteLine("______Enter elemets______");

                    for (int i = 0; i < number; i++)
                    {
                        Console.Write($"{Ordinal.getOrdinal(i + 1)} element: ");

                        if (!int.TryParse(Console.ReadLine(), out int element))//ამოწმებს რო ინტეჯერი ჩაწერა თუ არა მომხმარებელმა
                        {
                            Console.WriteLine($"Please enter a valid {Ordinal.getOrdinal(i + 1)} integer.");
                            i--; // ვაკლებ რო ეს ელემენტი თავიდან ჩაწეროს მომხმარებელმა როცა ელემენტს როგორც ინტეჯერს არ შეიყვანს
                            continue;
                        }

                        //ელემენტი თუ უარყოფითია გადააკეთებს დადებითად რადგან ამოცანა დადებითების ჯამს და საშუალოს გვთხოვს
                        element = element < 0
                                ? -element
                                : element;

                        sum += element;
                        count++;
                    }

                    string average = ((double)sum / count).ToString("F2");//Double.ToString("F2") ვიყენებ დასაფორმატებლად რო .-ის მერე მარტო 2 ციფრი იყოს დაბლში ისე დამრგვალდეს

                    Console.WriteLine($"Average: {average}");
                    Console.WriteLine($"Sum: {sum}");
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer.");
                }

                if (!TryAgain.Ask())
                {
                    break;
                }
            }
        }
    }
}