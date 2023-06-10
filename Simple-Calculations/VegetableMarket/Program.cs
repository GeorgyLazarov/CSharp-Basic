using System;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVeg = double.Parse(Console.ReadLine());
            double priceFruits = double.Parse(Console.ReadLine());
            int weightVeg = int.Parse(Console.ReadLine());
            int weightFruits = int.Parse(Console.ReadLine());
            double vegWin = priceVeg * weightVeg;
            double fruitsWin = priceFruits * weightFruits;
            Console.WriteLine((vegWin + fruitsWin) / 1.94); //in Euro            
        }
    }
}