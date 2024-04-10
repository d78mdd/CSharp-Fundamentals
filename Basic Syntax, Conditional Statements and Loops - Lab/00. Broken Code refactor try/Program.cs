﻿using System;
using System.Globalization;

namespace _00.Broken_Code_refactor_try
{
    class Program  // HolidaysBetweenTwoDates
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(), "dd.M.yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "dd.M.yyyy", CultureInfo.InvariantCulture);

            var holidaysCount = 0;

            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }
            }

            Console.WriteLine(holidaysCount);
        }
    }
}