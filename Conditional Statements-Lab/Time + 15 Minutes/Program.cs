using System;

namespace Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            min = min + hours * 60;
            min = min + 15;
            hours = min / 60;
            min = min % 60;
            if (hours == 24)
            {
                Console.WriteLine($"0:{min:D2}");
            }
            else
            {
                Console.WriteLine($"{hours}:{min:D2}");
            }
        }
    }
}
