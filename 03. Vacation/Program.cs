using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();

            decimal price = 0;
            decimal priceForPerson = 0;

            switch (day)
            {
                case "Friday":
                    switch (groupType)
                    {
                        case "Students":
                            priceForPerson = 8.45m;
                            break;
                        case "Business":
                            priceForPerson = 10.90m;
                            break;
                        case "Regular":
                            priceForPerson = 15m;
                            break;
                    }
                    break;
                case "Saturday":
                    switch (groupType)
                    {
                        case "Students":
                            priceForPerson = 9.80m;
                            break;
                        case "Business":
                            priceForPerson = 15.60m;
                            break;
                        case "Regular":
                            priceForPerson = 20m;
                            break;
                    }
                    break;
                case "Sunday":
                    switch (groupType)
                    {
                        case "Students":
                            priceForPerson = 10.46m;
                            break;
                        case "Business":
                            priceForPerson = 16m;
                            break;
                        case "Regular":
                            priceForPerson = 22.50m;
                            break;
                    }
                    break;
            }

            price = priceForPerson * people;
            
            switch (groupType)
            {
                case "Students":
                    if (people >= 30)
                    {
                        price -= price * 0.15m;
                    }
                    break;
                case "Business":
                    if (people >= 100)
                    {
                        price -= 10 * priceForPerson;
                    }
                    break;
                case "Regular":
                    if (people >= 10 && people <= 20)
                    {
                        price -= price * 0.05m;
                    }
                    break;
            }

            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}
