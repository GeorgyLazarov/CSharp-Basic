using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceOfRoses = 5;
            double priceOfDahlias = 3.8;
            double priceOfTulips = 2.8;
            double priceOfNarcissus = 3;
            double priceOfGladiolus = 2.5;

            string flowers = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double finalPrice = 0;
            if (flowers == "Roses")
            {
                if (num > 80)
                {
                    priceOfRoses *= 0.9;
                }
                finalPrice = priceOfRoses * num;
            }
            else if (flowers == "Dahlias")
            {
                if (num > 90)
                {
                    priceOfDahlias *= 0.85;
                }
                finalPrice = priceOfDahlias * num;
            }
            else if (flowers == "Tulips")
            {
                if (num > 80)
                {
                    priceOfTulips *= 0.85;
                }
                finalPrice = priceOfTulips * num;
            }
            else if (flowers == "Narcissus")
            {
                if (num < 120)
                {
                    priceOfNarcissus *= 1.15;
                }
                finalPrice = priceOfNarcissus * num;
            }
            else if (flowers == "Gladiolus")
            {
                if (num < 80)
                {
                    priceOfGladiolus *= 1.2;
                }
                finalPrice = priceOfGladiolus * num;
            }
            double moneyLeft = budget - finalPrice;
            double moneyNeeded = finalPrice - budget;
            if (budget >= finalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {num} {flowers} and {moneyLeft:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");

            }
        }
    }
}
