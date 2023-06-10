using System;

namespace RadianConvartor
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());
            var deg = rad * 180 / Math.PI;
            Console.WriteLine(deg);
        }
    }
}