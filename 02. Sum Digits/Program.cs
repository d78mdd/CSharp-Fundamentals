﻿using System;

namespace _02.Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            while (n!=0)
            {
                sum += n % 10;
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
