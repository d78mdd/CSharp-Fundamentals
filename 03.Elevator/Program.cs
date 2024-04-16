using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int fullCourses = people / capacity;

            if (fullCourses < 2)
            {
                Console.WriteLine("All the persons fit inside in the elevator.");
                Console.WriteLine("Only one course is needed.");
            }
            else
            {
                Console.WriteLine($"{fullCourses} courses * {capacity} people");
                int remainderPeople = people - fullCourses * capacity;
                if (remainderPeople > 0)
                {
                    Console.WriteLine($"+ 1 course * {remainderPeople} persons");
                }
            }
        }
    }
}
