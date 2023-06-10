using System;

namespace Fahreinheit
{
    class Fahrenheit
    {
        static void Main(string[] args)
        {
            var tempC = double.Parse(Console.ReadLine());
            var tempF = tempC * 1.8 + 32;
            Console.WriteLine("Fahrenheit = " + Math.Round(tempF,2));
        }
    }
}