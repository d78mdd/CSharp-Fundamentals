﻿using System;

namespace _07.Theatre_Promotion_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string day = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());

            int price = 0;

            switch (day)
            {
                case "weekday":
                    if ((0 <= age && age <= 18) || (64 < age && age <= 122))
                    {
                        price = 12;
                    }
                    else if (18 < age && age <= 64)
                    {
                        price = 18;
                    }
                    break;
                case "weekend":
                    if ((0 <= age && age <= 18) || (64 < age && age <= 122))
                    {
                        price = 15;
                    }
                    else if (18 < age && age <= 64)
                    {
                        price = 20;
                    }
                    break;
                case "holiday":
                    if (0 <= age && age <= 18)
                    {
                        price = 5;
                    }
                    else if (18 < age && age <= 64)
                    {
                        price = 12;
                    }
                    else if (64 < age && age <= 122)
                    {
                        price = 10;
                    }
                    break;
            }

            if (price > 0)
            {
                Console.WriteLine(price + "$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
