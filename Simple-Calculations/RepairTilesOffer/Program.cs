namespace RepairTilesOffer
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            int areaLenght = int.Parse(Console.ReadLine());
            int widthtile = int.Parse(Console.ReadLine());
            int lenghtTile = int.Parse(Console.ReadLine());
            int widthBench = int.Parse(Console.ReadLine());
            int lenghtBench = int.Parse(Console.ReadLine());
            int tileArea = widthtile * lenghtTile;
            int benchArea = widthBench * lenghtBench;
            double numTile =(double)(areaLenght * areaLenght - benchArea) / tileArea;
            Console.WriteLine(numTile);
            Console.WriteLine(numTile * 0.2);
        }
    }
}