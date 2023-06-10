using System;

namespace DepositCalculatins
{
    class DepositCalculations
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int depositInMonths = int.Parse(Console.ReadLine());
            double yearlyInterestPercentage = double.Parse(Console.ReadLine());
            double yearlyAcumulatedInterest = depositSum * yearlyInterestPercentage / 100;
            //Console.WriteLine(yearlyAcumulatedInterest);
            double monthlyAcumulatedInterest = yearlyAcumulatedInterest / 12;
            double totalsum = depositSum + depositInMonths * monthlyAcumulatedInterest;
            //double totalsum = depositSum + depositInMonths * ((depositSum*yearlyInterestPercentage/100)/12)
            Console.WriteLine(totalsum);
        }
    }
}