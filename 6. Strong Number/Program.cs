using System;

namespace _6.Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string numString = num.ToString();

            int sum = 0;

            foreach (char symbol in numString)
            {
                int digit = int.Parse(symbol.ToString());

                int digitFactoriel = 1;
                for (int i = digit; i >= 1; i--)
                {
                    digitFactoriel *= i;
                }

                sum += digitFactoriel;
            }

            if (sum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
