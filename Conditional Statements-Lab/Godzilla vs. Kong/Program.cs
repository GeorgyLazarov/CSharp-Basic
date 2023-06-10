using System;

namespace Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double filmBudget = double.Parse(Console.ReadLine());
            double actor = double.Parse(Console.ReadLine());
            double actorSuitCost = double.Parse(Console.ReadLine());
            double decor = filmBudget * 0.1;
            double sumactorSuitCost = actor * actorSuitCost;
            
            if (actor > 150)
                sumactorSuitCost = sumactorSuitCost - sumactorSuitCost * 0.1;
            if ((decor + sumactorSuitCost) <= filmBudget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {Math.Abs((decor + sumactorSuitCost) - filmBudget):f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs((decor + sumactorSuitCost) - filmBudget):f2} leva more.");
            }
        }
    }
}
