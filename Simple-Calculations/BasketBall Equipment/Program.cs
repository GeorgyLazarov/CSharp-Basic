using System;

namespace BasketBall_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double annualFee = double.Parse(Console.ReadLine());
            double sneakers = annualFee - annualFee * 0.4;
            double equipment = sneakers - sneakers * 0.2;
            double ball = equipment / 4;
            double accessories = ball / 5;
            double total = annualFee + sneakers + equipment + ball + accessories;
            Console.WriteLine(total);
        }
    }
}
