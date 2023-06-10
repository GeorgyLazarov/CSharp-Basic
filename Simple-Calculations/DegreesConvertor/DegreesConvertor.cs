using System;

namespace Fahreinheit
{
    class DegreesConvertor
    {
        static void Main(string[] args)
        {
            var deg = double.Parse(Console.ReadLine());
            var rad = deg / 180 * Math.PI;
            Console.WriteLine(Math.Round(rad,4));
        }
    }
}