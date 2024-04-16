using System;

namespace _03.Elevator2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal people = int.Parse(Console.ReadLine());
            decimal capacity = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Ceiling(people / capacity));
        }
    }
}
