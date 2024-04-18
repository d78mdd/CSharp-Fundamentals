using System;

namespace _04.RefactoringPrimeChecker
{
    class ProgramRefactored
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int number = 2; number <= N; number++)
            {
                bool isPrime = true;

                for (int divider = 2; divider < number; divider++)
                {
                    if (number % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine("{0} -> {1}", number, "true");
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", number, "false");
                }
            }

        }
    }
}
