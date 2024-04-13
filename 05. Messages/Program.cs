using System;

namespace _05.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                string input = Console.ReadLine();

                char c;

                switch (input)
                {
                    case "2":
                        c = 'a';
                        break;
                    case "22":
                        c = 'b';
                         break;
                    case "222":
                        c = 'c';
                         break;
                    case "3":
                        c = 'd';
                         break;
                    case "33":
                        c = 'e';
                         break;
                    case "333":
                        c = 'f';
                         break;
                    case "4":
                        c = 'g';
                         break;
                    case "44":
                        c = 'h';
                         break;
                    case "444":
                        c = 'i';
                         break;
                    case "5":
                        c = 'j';
                         break;
                    case "55":
                        c = 'k';
                         break;
                    case "555":
                        c = 'l';
                         break;
                    case "6":
                        c = 'm';
                         break;
                    case "66":
                        c = 'n';
                         break;
                    case "666":
                        c = 'o';
                         break;
                    case "7":
                        c = 'p';
                         break;
                    case "77":
                        c = 'q';
                         break;
                    case "777":
                        c = 'r';
                         break;
                    case "7777":
                        c = 's';
                         break;
                    case "8":
                        c = 't';
                         break;
                    case "88":
                        c = 'u';
                         break;
                    case "888":
                        c = 'v';
                         break;
                    case "9":
                        c = 'w';
                         break;
                    case "99":
                        c = 'x';
                         break;
                    case "999":
                        c = 'y';
                         break;
                    case "9999":
                        c = 'z';
                         break;
                    case "0":
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
