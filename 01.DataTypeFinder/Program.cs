using System;

namespace _01.DataTypeFinder
{
    class Program
    {
        static void MainBroken(string[] args)
        {
            for (; ; )
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string type;

                if (input == "true" || input == "false")
                {
                    type = "boolean";
                }
                else
                {
                    bool isNumber = false;
                    bool hasDot = false;

                    for (int i = 0; i < input.Length; i++)
                    {
                        if (i > 0 && input[i] != '-')
                        {
                            if (input[i] == '.')
                            {
                                hasDot = true;
                            }
                            else if (input[i] >= '0' && input[i] <= '9')
                            {
                                isNumber = true;
                            }
                        }
                    }

                    if (isNumber)
                    {
                        if (hasDot)
                        {
                            type = "floating point";
                        }
                        else
                        {
                            type = "integer";
                        }
                    }
                    else
                    {
                        if (input.Length == 1)
                        {
                            type = "character";
                        }
                        else
                        {
                            type = "string";
                        }
                    }
                }

                Console.WriteLine($"{input} is {type} type");
            }
        }
    }
}
