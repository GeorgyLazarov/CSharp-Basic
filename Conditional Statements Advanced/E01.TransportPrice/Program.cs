using System;

namespace E01.TransportPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string halfDay = Console.ReadLine();
            double sum = 0;
            double taxiRate = 0;
            if (halfDay == "day")
            {
                taxiRate = 0.79;
            } 
            else
            {
                taxiRate = 0.9;
            }
            if (distance <20)
            {
                sum = distance * taxiRate + 0.7; 
            }
            else if (distance <100)
            {
                sum = distance * 0.09;
                
            }
            else
            {
                sum = distance * 0.06;
            }
            Console.WriteLine($"{sum:f2}");
            
        }
    }
}
