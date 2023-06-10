using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int presentAge = int.Parse(Console.ReadLine());
            double machinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int money = 0;
            
           

            for (int i=1;i<= presentAge;i++) 
            {
                if (i % 2 == 0)
                {
                    money += i*5-1;
                   
                }
                else
                {
                    money = money + toyPrice;
                }
            }
           
            
            double difference = Math.Abs((double)money - machinePrice);
            if (money >=machinePrice)
            {
                Console.WriteLine($"Yes! {money-machinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {machinePrice-money:f2}");
            }
        }
    }
}
