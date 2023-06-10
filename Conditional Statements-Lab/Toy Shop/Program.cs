using System;

namespace Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            double money = puzzles * 2.6 + dolls * 3 + bears * 4.1 + minions * 8.2 + trucks * 2;
            int toysQuantity = puzzles  + dolls + bears+ minions  + trucks;
            if (toysQuantity >= 50)
                money -= money * 0.25;
            money -= money * 0.1;
            if (money >= tripPrice)
                Console.WriteLine($"Yes! {Math.Abs(money - tripPrice):f2} lv left.");
            else
                Console.WriteLine($"Not enough money! {Math.Abs(money - tripPrice):f2} lv needed.");
        }
    }
}
