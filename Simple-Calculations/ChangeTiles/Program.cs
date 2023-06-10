using System;

namespace E03.ChangeTiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double areaLenght = double.Parse(Console.ReadLine());
            double widthtile = double.Parse(Console.ReadLine());
            double lenghtTile = double.Parse(Console.ReadLine());
            double widthBench = double.Parse(Console.ReadLine());
            double lenghtBench = double.Parse(Console.ReadLine());
            double tileArea = widthtile * lenghtTile;
            double benchArea = widthBench * lenghtBench;
            double numTile = (areaLenght * areaLenght - benchArea) / tileArea;
            Console.WriteLine(numTile);
            Console.WriteLine(numTile * 0.2);
        }
    }
}
