using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int minedPerDay = int.Parse(Console.ReadLine());

            int currentYield = 0;
            int daysOperated = 0;

            for ( ; ; )
            {
                if (minedPerDay >= 100)
                {
                    currentYield += minedPerDay;
                    currentYield -= 26;

                    minedPerDay -= 10;
                    daysOperated++;
                }
                else
                {
                    currentYield -= 26;
                    if (currentYield < 0)
                    {
                        currentYield = 0;
                    }
                    break;
                }

            }

            Console.WriteLine(daysOperated);
            Console.WriteLine(currentYield);
        }
    }
}
