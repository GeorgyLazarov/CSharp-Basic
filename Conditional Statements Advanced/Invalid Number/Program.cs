using System;

namespace Invalid_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num != 0)
            {
                if ((num < 100) || (num > 200))

                    Console.WriteLine("invalid");
            }           
        }
    }
}
