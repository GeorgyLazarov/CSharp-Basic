using System;

namespace E09.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            do
            {
                sum = sum+(n % 10);
                n= n / 10;
            }
            while (n > 0);
            Console.WriteLine($"Sum of digits: {sum}");
        }
    }
}
