using System;

namespace _03.Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());

            double initialBalance = currentBalance;

            for ( ; ; )
            {
                string input = Console.ReadLine();

                double gamePrice = 0;
                string gameName = "";

                if (input == "Game Time")
                {
                    double totalSpent = initialBalance - currentBalance;
                    Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${currentBalance:F2}");
                    return;
                }
                else
                {
                    switch (input)
                    {
                        case "OutFall 4":
                            gamePrice = 39.99;
                            gameName = "OutFall 4";
                            break;
                        case "CS: OG":
                            gamePrice = 15.99;
                            gameName = "CS: OG";
                            break;
                        case "Zplinter Zell":
                            gamePrice = 19.99;
                            gameName = "Zplinter Zell";
                            break;
                        case "Honored 2":
                            gamePrice = 59.99;
                            gameName = "Honored 2";
                            break;
                        case "RoverWatch":
                            gamePrice = 29.99;
                            gameName = "RoverWatch";
                            break;
                        case "RoverWatch Origins Edition":
                            gamePrice = 39.99;
                            gameName = "RoverWatch Origins Edition";
                            break;
                        default:
                            Console.WriteLine("Not Found");
                            break;
                    }
                    
                }

                if (gamePrice > 0)
                {
                    if (currentBalance - gamePrice >= 0)
                    {
                        currentBalance -= gamePrice;
                        Console.WriteLine($"Bought {gameName}");
                    }
                    else if (currentBalance - gamePrice < 0)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }

                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
        }
    }
}
