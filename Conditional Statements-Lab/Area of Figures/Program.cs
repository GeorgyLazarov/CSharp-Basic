using System;

namespace Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a * a:f3}");
            }
            else if (figure == "rectangle")
            {
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine($"{b * c:f3}");
            }
            else if (figure == "circle")
            {
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.PI * d * d:f3}");
            }
            else if (figure == "triangle")
            {
                double e = double.Parse(Console.ReadLine());
                double f = double.Parse(Console.ReadLine());
                Console.WriteLine($"{e * f / 2:f3}");
            }

        }
    }
}
