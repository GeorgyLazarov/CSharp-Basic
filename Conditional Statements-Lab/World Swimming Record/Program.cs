using System;

namespace World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recInSec = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());
           
            double delay = Math.Floor(distanceInMeters / 15) * 12.5;
            double totalTime = distanceInMeters*timePerMeter +delay;
            if (totalTime < recInSec)
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            else
                Console.WriteLine($"No, he failed! He was {Math.Abs(recInSec - totalTime):f2} seconds slower.");
            
            
        }
    }
}
