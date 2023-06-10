using System;

namespace E01.TrainingLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double workPlaceL = 120;
            double workPlaceW = 70;
          
            double cows = Math.Floor(l  * 100 / workPlaceL);
           
            double rows = Math.Floor((w-1) * 100 / workPlaceW);
            
            Console.WriteLine(rows*cows-3);


        }
    }
}
