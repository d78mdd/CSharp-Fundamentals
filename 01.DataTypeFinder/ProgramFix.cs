using System;

namespace _01.DataTypeFinder
{
    class ProgramFix
    {
        static void Main(string[] args)
        {

            for (; ; )
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string type = "";

                int minusesCount = 0;
                int firstMinusIndex = -1;

                int dotsCount = 0;
                int firstDotIndex = -1;

                int digitsCount = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == '-')
                    {
                        minusesCount++;
                        if (minusesCount == 1)
                        {
                            firstMinusIndex = j;
                        }
                    }

                    if (input[j] == '.')
                    {
                        dotsCount++;
                        if (dotsCount == 1)
                        {
                            firstDotIndex = j;
                        }
                    }

                    if (input[j] >= '0' && input[j] <= '9')
                    {
                        digitsCount++;
                    }
                }

                if ((dotsCount == 1 && firstDotIndex < input.Length - 1) &&
                    ((firstMinusIndex == 0 && minusesCount == 1) || (firstMinusIndex == -1 && minusesCount == 0)) &&
                    digitsCount + minusesCount + 1 == input.Length)
                {
                    type = "floating point";
                }
                else if (dotsCount == 0 &&
                    ((firstMinusIndex == 0 && minusesCount == 1) || (firstMinusIndex == -1 && minusesCount == 0)) &&
                    digitsCount + minusesCount == input.Length
                    )
                {
                    if ((input.Length == 1 &&
                        (input[0] == '.' || input[0] == '-')) ||
                        input.Length == 0)
                    {
                        type = "string";
                    }
                    else
                    {
                        type = "integer";
                    }

                }
                else
                {
                    // not a number

                    if (input.Length == 1)
                    {
                        type = "character";
                    }
                    else if (input.ToLower() == "true" || input.ToLower() == "false")
                    {
                        type = "boolean";
                    }
                    else
                    {
                        type = "string";
                    }
                }

                Console.WriteLine($"{input} is {type} type");
            }

        }
    }
}
