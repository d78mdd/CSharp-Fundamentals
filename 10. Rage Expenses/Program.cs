using System;

namespace _10.Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double expenses;

            int trashedHeadsets = lostGamesCount / 2;
            int trashedMice = lostGamesCount / 3;
            int trashedKeyboards = lostGamesCount / 6;
            int trashedDisplays = trashedKeyboards / 2;

            double headsetExpenses = trashedHeadsets * headsetPrice;
            double mouseExpenses = trashedMice * mousePrice;
            double keyboardExpenses = trashedKeyboards * keyboardPrice;
            double displayExpenses = trashedDisplays * displayPrice;

            expenses = headsetExpenses + mouseExpenses + keyboardExpenses + displayExpenses;

            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
        }
    }
}
