using System;

namespace _01.DataTypeFinder3
{
    class Program
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


                bool hasOnlyNumberSymbols =
                    digitsCount + minusesCount + dotsCount == input.Length;

                bool hasInitialMinus =
                    (firstMinusIndex == 0 && minusesCount == 1);

                bool hasNoMinus =
                    firstMinusIndex == -1 && minusesCount == 0;


                bool hasValidDot =
                    dotsCount == 1 && firstDotIndex < input.Length - 1;

                bool hasNoDot =
                    dotsCount == 0;


                bool seemsNumber =
                    (hasInitialMinus || hasNoMinus) &&
                    hasOnlyNumberSymbols;


                bool isEmpty =
                    input.Length == 0;

                bool is1Symbol =
                    input.Length == 1;


                bool is1Digit =
                    input[0] >= '0' && input[0] <= '9';


                if ((is1Symbol && !is1Digit) || isEmpty)
                {
                    type = "character";
                }
                else if (seemsNumber)
                {
                    if (hasValidDot)
                    {
                        type = "floating point";
                    }
                    else if (hasNoDot)
                    {
                        type = "integer";
                    }
                }
                else
                {
                    // not a number

                    if (input.ToLower() == "true" || input.ToLower() == "false")
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
