using System;
using System.Dynamic;

namespace E06.NumberinRange_1to100_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            while (num<1||num>100)
            {
                Console.WriteLine("Invalid number!");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is {num}");
        }
    }
}
