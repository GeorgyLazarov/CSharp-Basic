using System;

namespace bitcoinEuro
{
    class Program

    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double JPN = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());
         // double sum = (bitcoin * 1168 + (JPN * 0.15) * 1.76) / 1.95;
            double usdToLeva = JPN * 0.15 * 1.76;
            double bitcoinToLeva = bitcoin * 1168;
            double euro = (usdToLeva + bitcoinToLeva) / 1.95;
         // double sum = euro -(commission/100)*euro;
         // euro -= (commission / 100) * euro;
            Console.WriteLine(euro -= (commission / 100) * euro);
        }
    }
}