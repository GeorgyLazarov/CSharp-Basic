using System;
using System.Xml.Schema;

namespace Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chicken = double.Parse(Console.ReadLine());
            double fish = double.Parse(Console.ReadLine());
            double vegetarian = double.Parse(Console.ReadLine());
            double sumChicken = chicken * 10.35;
            double sumFish = fish * 12.4;
            double sumVegetarian = vegetarian * 8.15;

            double priceMenu = sumChicken+sumFish+sumVegetarian;
            
            double dessert = priceMenu*0.2;
            double delivery = 2.5;
            double total = priceMenu + dessert + delivery;
            Console.WriteLine(total);
        }
    }
}
