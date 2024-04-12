using System;

namespace _11.Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier > 10)
            {
                int result = number * multiplier;
                Console.WriteLine(number + " X " + multiplier + " = " + result);
                return;
            }

            for (int i = multiplier; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine(number + " X " + i + " = " + result);
            }
        }
    }
}
