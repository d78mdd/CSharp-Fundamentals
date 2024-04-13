using System;

namespace _01.Sort_Numbers
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

            if (n1 >= n2 && n1 >= n3)
            {
                large = n1;

                if (n2 > n3)
                {
                    mid = n2;
                    small = n3;
                }
                else
                {
                    mid = n3;
                    small = n2;
                }
            }
            else if (n2 >= n1 && n2 >= n3)
            {
                large = n2;

                if (n1 > n3)
                {
                    mid = n1;
                    small = n3;
                }
                else
                {
                    mid = n3;
                    small = n1;
                }
            }
            else
            {
                large = n3;

                if (n1 > n2)
                {
                    mid = n1;
                    small = n2;
                }
                else
                {
                    mid = n2;
                    small = n1;
                }
            }

            Console.WriteLine(large);
            Console.WriteLine(mid);
            Console.WriteLine(small);
        }
    }
}
