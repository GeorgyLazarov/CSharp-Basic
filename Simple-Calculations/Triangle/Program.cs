using System;
using System.Transactions;

class RectangleFormula
{
    static void Main(string[] args)
    {
        var a = double.Parse(Console.ReadLine());
        var h = double.Parse(Console.ReadLine());
        var area = a * h / 2;
        Console.WriteLine(" Triangle Area =" + Math.Round(area,2));
    }
}