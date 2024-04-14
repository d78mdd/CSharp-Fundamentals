using System;

namespace _06.ReversedChars4
{
    class Program
    {
        static void Main(string[] args)
        {
            string concatenated = "";

            int n = 3;

            for (int i = 0; i < n; i++)
            {
                concatenated = concatenated + Console.ReadLine();
            }

            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write($"{concatenated[i]} ");
            }

        }
    }
}
