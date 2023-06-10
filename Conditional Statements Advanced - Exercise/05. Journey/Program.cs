using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
           
            string destination = string.Empty;
            string tipHoliday = string.Empty;
            double total = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    tipHoliday = "Camp";
                    total = budget * 0.3;
                }
                else if (season == "winter")
                {
                    tipHoliday = "Hotel";
                    total = budget * 0.7;
                }
            }
            else if ((budget > 100) && (budget <= 1000))
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    tipHoliday = "Camp";
                    total = budget * 0.4;
                }
                else if (season == "winter")
                {
                    tipHoliday = "Hotel";
                    total = budget * 0.8;
                }
            }
            else if ((budget > 1000))
            {
                destination = "Europe";
                tipHoliday = "Hotel";
                total = budget * 0.9;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{tipHoliday} - {total:f2}");
        }
    }
}
