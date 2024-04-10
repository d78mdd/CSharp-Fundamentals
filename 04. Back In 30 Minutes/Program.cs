using System;

namespace _04.Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            m += 30;
            if (m >= 59)
            {
                m = m % 60;
                h += 1;
            }

            if (h >= 23)
            {
                h = 0;
            }

            Console.WriteLine($"{h}:{m:D2}");
        }
    }
}
