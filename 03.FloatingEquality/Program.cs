using System;

namespace _03.FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {

            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            double eps = 0.000001;

            Console.WriteLine(Math.Abs(number1 - number2) < eps);
        }
    }
}
