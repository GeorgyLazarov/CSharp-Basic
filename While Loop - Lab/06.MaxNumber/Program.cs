using System;

namespace _06.MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNum = int.MinValue;
            string input;
            while ((input = Console.ReadLine()) != "Stop") 
            {
                int num =int.Parse(input);
                if (num > maxNum)
                {
                    maxNum = num;
                }

            }
            Console.WriteLine(maxNum);
        }
    }
}
