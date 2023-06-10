using System;

namespace Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int Serial = int.Parse(Console.ReadLine());
            int Brake = int.Parse(Console.ReadLine());
          
            double timeForSerial = (double)Brake *5/8;
            double difference=Math.Abs(timeForSerial - Serial);
            if (timeForSerial >= Serial)
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(difference)} minutes free time.");
            else
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(difference)} more minutes.");
        }
    }
}
