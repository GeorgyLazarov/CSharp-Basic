using System;

namespace Number_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            if (num < -100 || num == 0 || num > 100)
                Console.WriteLine("No");
            else
                Console.WriteLine("Yes");
        }
    }
}
