using System;

namespace _05.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double instead = double.Parse(Console.ReadLine());
            double insteadInCoins = Math.Round(instead * 100);

            int coins = 0;
            while (insteadInCoins != 0)
            {

                if (insteadInCoins >= 200)
                {
                    insteadInCoins -= 200;
                    coins++;
                }
                else if (insteadInCoins >= 100)
                {
                    insteadInCoins -= 100;
                    coins++;
                }
                else if (insteadInCoins >= 50)
                {
                    insteadInCoins -= 50;
                    coins++;
                }
                else if (insteadInCoins >= 20)
                {
                    insteadInCoins -= 20;
                    coins++;
                }
                else if (insteadInCoins >= 10)
                {
                    insteadInCoins -= 10;
                    coins++;
                }
                else if (insteadInCoins >= 5)
                {
                    insteadInCoins -= 5;
                    coins++;
                }
                else if (insteadInCoins >= 2)
                {
                    insteadInCoins -= 2;
                    coins++;
                }
                else if (insteadInCoins >= 1)
                {
                    insteadInCoins -= 1;
                    coins++;
                }
            }
            Console.WriteLine(coins);
        }
    }
}
