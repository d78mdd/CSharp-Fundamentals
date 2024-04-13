using System;

namespace _05.Messages_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            for (int i = 1; i <= length; i++)
            {
                string input = Console.ReadLine();

                int usedDigit = int.Parse(input) % 10;
                int count = input.Length;

                char c = '_';

                switch (usedDigit)
                {
                    case 1:
                        break;
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                        c = (char)( 3 * (usedDigit-2) + 97 + (count-1) );
                        break;
                    case 8:
                    case 9:
                        c = (char)(3 * (usedDigit - 2) + 97 + (count - 1) + 1);
                        break;
                    case 0:
                        c = ' ';
                        break;
                    default:
                        return;
                }

                Console.Write(c);
            }
        }
    }
}
