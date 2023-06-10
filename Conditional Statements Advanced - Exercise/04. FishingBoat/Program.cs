using System;

namespace _04._FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double rent = 0;

            if (season == "Spring")
            {
                rent = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                rent = 4200;
            }
            else if (season == "Winter")
            {
                rent = 2600;
            }
            if (fishermen <= 6)
            {
                rent -= rent * 0.1;
            }
            else if (fishermen >= 7 && fishermen < 12)
            {
                rent -= rent * 0.15;
            }
            else if (fishermen >= 12)
            {
                rent -= rent * 0.25;
            }
            if ((fishermen % 2 == 0) && ((season == "Spring") || (season == "Summer") || (season == "Winter")))
            {
                rent -= rent * 0.05;
            }
            double difference = Math.Abs(budget - rent);
            if ((budget - rent) >= 0)
            {
                Console.WriteLine($"Yes! You have {difference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {difference:f2} leva.");
            }
        }
    }
}
