using System;

namespace SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int numPage = int.Parse(Console.ReadLine());
            int pages = int.Parse(Console.ReadLine());
            int daysToReadTheBook = int.Parse(Console.ReadLine());
            //calculations
            int hours = numPage / pages / daysToReadTheBook;
            Console.WriteLine(hours);


            //otput
        }
    }
}