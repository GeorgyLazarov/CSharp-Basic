using System;

namespace Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int packageForDogs = int.Parse(Console.ReadLine());
            int packageForCats = int.Parse(Console.ReadLine());
            double sumDogs = packageForDogs * 2.5;
            int sumCats = packageForCats * 4;
            double total = sumDogs+sumCats;
            Console.WriteLine(total + " lv.");
        }
    }
}
