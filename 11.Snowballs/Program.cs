using System;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());

            int bestSnowballValue = int.MinValue;
            int bestSnowballSnow = 0;
            int bestSnowballTime = 0;
            int bestSnowballQuality = 0;

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                int snowballValue = (int)Math.Pow(snowballSnow / (double)snowballTime, snowballQuality);

                if (snowballValue > bestSnowballValue)
                {
                    bestSnowballValue = snowballValue;

                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowballValue} ({bestSnowballQuality})");
        }
    }
}
