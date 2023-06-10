using System;

namespace E10.RectanglewithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('%', num * 2));
            int numRows = num;
            if (numRows%2==0)
            {
                numRows--;
            }
            for (int i = 0;i < numRows; i++) 
            {
                Console.Write("%");
                if(i==numRows/2)
                {
                    Console.Write(new string(' ', num - 2));
                    Console.Write("**");
                    Console.Write(new string(' ', num - 2));
                }
                else
                {
                    Console.Write(new string(' ', num * 2 - 2));
                }
                Console.Write("%");
                Console.WriteLine();
            }
            Console.WriteLine(new string('%', num * 2));
        }
    }
}
