using System;

namespace _02.FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                int spaceIndex = input.IndexOf(' ');

                string number1String = input.Substring(0, spaceIndex);
                string number2String = input.Substring(spaceIndex + 1);

                long number1 = long.Parse(number1String);
                long number2 = long.Parse(number2String);

                string numberToSumString;
                if (number1 > number2)
                {
                    numberToSumString = number1String;
                }
                else
                {
                    numberToSumString = number2String;
                }

                int sum = 0;
                foreach (char c in numberToSumString)
                {
                    if (c != '-')
                    {
                        sum += int.Parse(c.ToString());
                    }
                }

                Console.WriteLine(sum);
            }
        }
    }
}
