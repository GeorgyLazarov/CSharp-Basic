using System;

namespace _05.DailyEarnings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int workingDay = int.Parse(Console.ReadLine());
            double earningMoney = double.Parse(Console.ReadLine());
            double currencyRate = double.Parse(Console.ReadLine());

            double monthSalary = workingDay * earningMoney;
            double yearSalary = (monthSalary * 12) + (monthSalary * 2.5);
            double taxes = 0.25 * yearSalary;
            double netSalary = yearSalary - taxes;
            double selaryInLeva = netSalary *currencyRate;
            double average = selaryInLeva / 365;
            Console.WriteLine($"{average:f2}");

        }
    }
}
