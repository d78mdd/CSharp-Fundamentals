using System;

namespace _01.Sort_Numbers_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int large;
            int mid;
            int small;

            large = Math.Max(Math.Max(n1, n2), n3);
            small = Math.Min(Math.Min(n1, n2), n3);

            mid = n1 + n2 + n3 - large - small;

            Console.WriteLine(large);
            Console.WriteLine(mid);
            Console.WriteLine(small);
        }
    }
}
