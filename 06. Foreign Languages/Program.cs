using System;

namespace _06.Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string lang = Console.ReadLine();
            switch (lang)
            {
                case "England":
                case "USA":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
