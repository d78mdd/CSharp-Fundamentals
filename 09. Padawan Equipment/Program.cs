using System;

namespace _09.Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double totalPrice = 0.0;

            int lightsaberCount = studentCount + (int)Math.Ceiling(studentCount * 0.10);
            int robeCount = studentCount;
            int beltCount = studentCount - studentCount / 6;

            double totallightsaberPrice = lightsaberCount * lightsaberPrice;
            double totalRobePrice = robeCount * robePrice;
            double totalBeltPrice = beltCount * beltPrice;

            totalPrice = totallightsaberPrice + totalRobePrice + totalBeltPrice;

            if (totalPrice <= money)
            { 
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                double neededMoney = totalPrice - money;
                Console.WriteLine($"John will need {neededMoney:F2}lv more.");
            }
        }
    }
}
