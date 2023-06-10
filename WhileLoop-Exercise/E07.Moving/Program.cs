using System;

namespace E07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int box = 0;
         
            int space = width * height * length;
            while (input != "Done")
            {
                box = int.Parse(input);
                space -= box;
                if (space < 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(space)} Cubic meters more.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "Done")
            {
                Console.WriteLine($"{space} Cubic meters left.");
            }
        }
    }
}
