using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int capacity = 255;

            int pouredLiters = 0;

            for (int i = 0; i < n; i++)
            {
                int litersToPour = int.Parse(Console.ReadLine());
                
                if (capacity >= pouredLiters + litersToPour)
                {
                    pouredLiters += litersToPour;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(pouredLiters);

        }
    }
}
