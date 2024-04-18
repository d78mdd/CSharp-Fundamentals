using System;

namespace _05.DecryptingMessage2
{
    class Program
    {
        static void Main(string[] args)
        {

            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string message = "";

            for (int i = 0; i < n; i++)
            {
                char c = char.Parse(Console.ReadLine());

                char decryptedC = (char)(c + key);

                bool lowerCase = c >= 'a' && c <= 'z';
                bool upperCase = c >= 'A' && c <= 'Z';

                if (lowerCase)
                {
                    if (decryptedC > 'z')
                    {
                        decryptedC = (char)(decryptedC - 26);
                    }
                }
                else if (upperCase)
                {
                    if (decryptedC > 'Z')
                    {
                        decryptedC = (char)(decryptedC - 26);
                    }
                }

                message += decryptedC.ToString();
            }

            Console.WriteLine(message);

        }
    }
}
