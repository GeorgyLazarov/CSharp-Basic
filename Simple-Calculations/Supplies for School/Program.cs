using System;
using System.Dynamic;

namespace Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pricePen =double.Parse(Console.ReadLine());
            double priceMarker =double.Parse(Console.ReadLine());
            double priceDetergent = double.Parse(Console.ReadLine());
            double percentDiscount = double.Parse(Console.ReadLine());

            double sumPen = pricePen * 5.8;
            double sumMarker = priceMarker * 7.2;
            double sumDetergent = priceDetergent * 1.2;
            double sumMaterials = sumPen+sumMarker+sumDetergent;
            double sumMaterialsWithDiscount = sumMaterials - (sumMaterials * (percentDiscount/100));
            Console.WriteLine(sumMaterialsWithDiscount);
        }
    }
}
