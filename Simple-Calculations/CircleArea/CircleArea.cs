using System;

namespace CircleArea
{
    class CircleArea
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var area = Math.PI * r * r;
            var perimeter = 2 * Math.PI * r;
            Console.WriteLine("Circle Area = " + area);
            Console.WriteLine("Circle Perimeter = " + perimeter);
        }
    }
}