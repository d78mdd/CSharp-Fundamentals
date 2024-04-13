using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string usernameReversed = "";

            for (int i = username.Length - 1; i >= 0; i--)
            {
                usernameReversed += username[i];
            }

            for (int i = 0; i < 3; i++)
            {
                string password = Console.ReadLine();
                if (password == usernameReversed)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }

            Console.WriteLine($"User {username} blocked!");
        }
    }
}
