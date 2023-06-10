using System;
using System.Data.Common;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            double total = 0;
            if (projection == "Normal")
            { 
                total = rows * colums * 7.5;
            }
            else if (projection == "Premiere")
            {
                total = rows * colums * 12;
            }
            else if (projection == "Discount")
            { 
                total = rows * colums * 5;
            }
            Console.WriteLine($"{total :f2} leva");
        }
    }
}
