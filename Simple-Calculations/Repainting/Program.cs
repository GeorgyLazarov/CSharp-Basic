using System;

namespace Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double protectivNylon = double.Parse(Console.ReadLine());
            double paint = double.Parse(Console.ReadLine());
            double paintThinner = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double sumNylon = (protectivNylon + 2) * 1.5;
            double sumPaint = (paint + paint * 0.1) * 14.5;
            double sumThinner = paintThinner * 5;
            double bag = 0.4;
            double sumMaterials = sumNylon+sumPaint+sumThinner+bag;
            double sumWorker = (sumMaterials * 0.3) * hours;
            double total = sumMaterials + sumWorker;
            Console.WriteLine(total);
        }
    }
}
