﻿using System;

namespace _12.Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            for(; ; )
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is: " + Math.Abs(number));
                    return;
                }

                Console.WriteLine("Please write an even number.");
            }
        }
    }
}
