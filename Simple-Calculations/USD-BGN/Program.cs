using System;

namespace Fahreinheit
{
    class Program
    {
        static void Main(string[] args)
        {
           double USD = double.Parse(Console.ReadLine());
           double BGN = USD * 1.7956;
           Console.WriteLine(Math.Round(BGN,2));
        }
    }
}