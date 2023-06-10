using System;
using System.Windows.Markup;

namespace Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine()); // Видео карти
            int M = int.Parse(Console.ReadLine()); // Процесори
            int P = int.Parse(Console.ReadLine()); // Памет
            double sumN = N * 250;
            double sumM = (double)M*(sumN * 0.35);
            double sumP = (double)P*(sumN * 0.1);
            double totalSum = sumN + sumM + sumP;
            if (N > M)
                totalSum -= totalSum * 0.15;
            if (budget > totalSum)
                Console.WriteLine($"You have {(budget - totalSum):f2} leva left!");
            else
                Console.WriteLine($"Not enough money! You need {(totalSum-budget):f2} leva more!");
        }
    }
}
