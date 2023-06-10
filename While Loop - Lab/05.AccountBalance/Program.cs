using System;

namespace _05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalBalance = 0;
            string input;
            while ((input = Console.ReadLine()) != "NoMoreMoney")
            {
                double depositMoney = double.Parse(input);
                if (depositMoney < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                totalBalance+=depositMoney;
                Console.WriteLine($"Increase: {depositMoney:f2}");
            }
            Console.WriteLine($"Total:{totalBalance:f2}");
        }
    }
}
