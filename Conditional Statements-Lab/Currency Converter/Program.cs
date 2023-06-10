using System;

namespace Currency_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            string currency1 = Console.ReadLine();
            string currency2 = Console.ReadLine();

            if (currency1 == "USD")
            {
                if (currency2 == "BGN")
                    Console.WriteLine($"{sum * 1.79549:f2}");
                else if (currency2 == "EUR")
                    Console.WriteLine($"{(sum * 1.79549) / 1.95583:f2}");
                else if (currency2 == "GBP")
                    Console.WriteLine($"{(sum * 1.79549) / 2.53405:f2}");
                else
                    Console.WriteLine("Error");
            }
            else if (currency1 == "BGN")
            {
                if (currency2 == "USD")
                    Console.WriteLine($"{sum / 1.79549:f2}");
                else if (currency2 == "EUR")
                    Console.WriteLine($"{sum / 1.95583:f2}");
                else if (currency2 == "GBP")
                    Console.WriteLine($"{sum / 2.53405}");
                else
                    Console.WriteLine("Error");
            }
            else if (currency1 == "EUR")
            {
                if (currency2 == "BGN")
                    Console.WriteLine($"{sum / 1.95583:f2}");
                else if (currency2 == "USD")
                    Console.WriteLine($"{(sum / 1.95583) * 1.79549:f2}");
                else if (currency2 == "GBP")
                    Console.WriteLine($"{(sum * 1.95583) / 2.53405:f2}");
                else
                    Console.WriteLine("Error");
            }
            else if (currency1 == "GBP")
            {
                if (currency2 == "BGN")
                    Console.WriteLine($"{sum / 2.53405:f2}");
                else if (currency2 == "EUR")
                    Console.WriteLine($"{(sum / 2.53405) * 1.95583:f2}");
                else if (currency2 == "USD")
                    Console.WriteLine($"{(sum / 2.53405) * 1.79549:f2}");
                else
                    Console.WriteLine("Error");
            }
            else
                Console.WriteLine("Error");
        }
    }
}
