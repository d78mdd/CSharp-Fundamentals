using System;

namespace _06.BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int bracketsSum = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input.Length == 1)
                {
                    if (char.Parse(input) == '(')
                    {
                        bracketsSum++;
                    }
                    if (char.Parse(input) == ')')
                    {
                        bracketsSum--;
                    }
                }

                if (bracketsSum < 0)
                {
                    break;
                }
            }

            string result;

            if (bracketsSum == 0)
            {
                result = "BALANCED";
            }
            else
            {
                result = "UNBALANCED";
            }

            Console.WriteLine(result);
        }
    }
}
