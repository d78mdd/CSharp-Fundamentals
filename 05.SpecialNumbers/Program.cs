using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sum = 0;

                bool isSpecial = false;

                int temp = i;
                for ( ; ; )
                {
                    sum += temp % 10;
                    temp /= 10;
                    if (temp == 0)
                    {
                        break;
                    }
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecial = true;
                }

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
