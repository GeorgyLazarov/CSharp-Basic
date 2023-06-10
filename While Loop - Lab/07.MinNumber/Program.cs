using System;

namespace _07.MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNum = int.MaxValue;
            string input;
            while ((input = Console.ReadLine()) != "Stop")
            {
                int num = int.Parse(input);
                if (num < minNum)
                {
                    minNum = num;
                }

            }
            Console.WriteLine(minNum);
        }
    }
}
