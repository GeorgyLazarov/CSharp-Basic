using System;

namespace Fahreinheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var BGN = double.Parse(Console.ReadLine());
            var USD = BGN / 1.79549;
            var EUR = BGN / 1.95583;
            var GBP = BGN / 2.53405;;
            Console.WriteLine(Math.Round(BGN));
        }
    }
}