using System;

namespace _07.Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentMoney = 0;

            for ( ; ; )
            {
                string input = Console.ReadLine();

                if (input == "Start")
                {
                    break;
                }

                double coin = double.Parse(input);

                if (coin != 0.1 &&
                    coin != 0.2 &&
                    coin != 0.5 &&
                    coin != 1 &&
                    coin != 2)
                {
                    Console.WriteLine($"Cannot accept {coin}");
                    continue;
                }

                currentMoney += coin;
            }

            for ( ; ; )
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string product = input.ToLower();

                switch (product)
                {
                    case "nuts":
                        if (currentMoney >= 2.0)
                        {
                            Console.WriteLine($"Purchased {product}");
                            currentMoney -= 2.0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "water":
                        if (currentMoney >= 0.7)
                        {
                            Console.WriteLine($"Purchased {product}");
                            currentMoney -= 0.7;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "crisps":
                        if (currentMoney >= 1.5)
                        {
                            Console.WriteLine($"Purchased {product}");
                            currentMoney -= 1.5;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "soda":
                        if (currentMoney >= 0.8)
                        {
                            Console.WriteLine($"Purchased {product}");
                            currentMoney -= 0.8;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "coke":
                        if (currentMoney >= 1.0)
                        {
                            Console.WriteLine($"Purchased {product}");
                            currentMoney -= 1.0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
            }

            Console.WriteLine($"Change: {currentMoney:F2}");
        }
    }
}
