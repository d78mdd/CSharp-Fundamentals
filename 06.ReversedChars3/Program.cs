using System;

namespace _06.ReversedChars3
{
    class Program
    {
        static void Main(string[] args)
        {
            string concatenated = "";

            for (int i = 0; i < 3; i++)
            {
                string character = Console.ReadLine();
                concatenated = concatenated + character;
            }

            Console.WriteLine($"{concatenated[2]} {concatenated[1]} {concatenated[0]}");
        }
    }
}
