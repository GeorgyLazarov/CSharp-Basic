using System;

namespace E02.Bricks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int bricksInOneCourse = w * m;
            double totalCourses = Math.Ceiling((double)x/ bricksInOneCourse);
            Console.WriteLine(totalCourses);
        }
    }
}
