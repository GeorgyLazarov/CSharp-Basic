using System;

namespace E06.Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            int maxFloor = floor;

            for(int f = floor;f>=1;f--) 
            {
                for (int a = 0; a <rooms;a++)
                {
                    if (floor == maxFloor)
                    {
                        Console.Write("L");
                        Console.Write($"{floor}{a} ");
                    }

                    else if (floor % 2 == 0)
                    {
                        Console.Write("O");
                        Console.Write($"{floor}{a} ");
                    }
                    else
                    {
                        Console.Write("A");
                        Console.Write($"{floor}{a} ");
                    }
                }
                floor--;
                Console.WriteLine();
            }
        }
    }
}
