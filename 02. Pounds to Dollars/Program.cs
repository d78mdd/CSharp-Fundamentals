using System;

namespace _02.Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double britishPounds = double.Parse(Console.ReadLine());

            double usDollars = britishPounds * 1.31;

            Console.WriteLine($"{usDollars:F3}");
        }
    }
}
