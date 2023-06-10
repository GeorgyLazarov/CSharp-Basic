using System;

namespace E03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double capital =double.Parse(Console.ReadLine());
            
            int daysCounter = 0;
            int spendindCounter= 0;
            
            string command;
            double money;
            
            while (capital<neededMoney) 
            { 
                command = Console.ReadLine();
                money = double.Parse(Console.ReadLine());
                daysCounter++;
                if (command == "spend")
                {
                    spendindCounter++;
                    if(spendindCounter == 5) 
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{daysCounter} ");
                        break;
                    }
                    capital -= money;
                    if (capital < 0)
                    {
                        capital = 0;
                    }
                }
                else
                {
                    capital += money;
                    spendindCounter = 0;
                }
            }
            if (capital>=neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}
