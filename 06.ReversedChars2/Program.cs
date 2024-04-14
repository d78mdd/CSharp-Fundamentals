using System;

namespace _06.ReversedChars2
{
    class Program
    {
        static void Main(string[] args)
        {
            string concatenated = "";

            string character = Console.ReadLine();
            concatenated = concatenated + character;

            character = Console.ReadLine();
            concatenated = concatenated + character;

            character = Console.ReadLine();
            concatenated = concatenated + character;

            Console.WriteLine($"{concatenated[2]} {concatenated[1]} {concatenated[0]}");
        }
    }
}
