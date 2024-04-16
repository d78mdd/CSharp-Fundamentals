using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine()); //N
            int distance = int.Parse(Console.ReadLine()); //M
            int exhaustionFactor = int.Parse(Console.ReadLine()); //Y

            int originalPokePower = pokePower;

            int pokedTargets = 0;

            for (; ; )
            {
                if (pokePower >= distance)
                {
                    pokePower -= distance;
                    pokedTargets++;
                }
                else
                {
                    break;
                }

                if (pokePower * 2 == originalPokePower)
                {
                    pokePower /= exhaustionFactor;
                }

            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokedTargets);
        }
    }
}
