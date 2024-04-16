using System;

namespace _03.ElevatorFixOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int fullCourses = people / capacity;

            int totalCourses;

            if (fullCourses < 2)
            {
                totalCourses = fullCourses;
            }
            else
            {
                totalCourses = fullCourses;

                int remainderPeople = people - fullCourses * capacity;
                if (remainderPeople > 0)
                {
                    totalCourses += 1;
                }
            }
            Console.WriteLine(totalCourses);
        }
    }
}