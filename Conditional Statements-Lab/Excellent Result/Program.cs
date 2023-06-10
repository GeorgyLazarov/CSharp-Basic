using System;

namespace Excellent_Result
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());

            if (num1 >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
