using System;

namespace E08.IncreasingElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countCurrentLongest = 0;
            int counterLongest = 0;
            int a= 0;
            int aPrev = 0;
            for (int i =0; i < n; i++) 
            {
                a = int.Parse(Console.ReadLine());
                if (a>aPrev)
                {
                    countCurrentLongest++;
                }
                else
                {
                    countCurrentLongest=1;
                }
                if (countCurrentLongest>counterLongest)
                {
                    counterLongest = countCurrentLongest;
                }
                aPrev = a;
            }
            Console.WriteLine(counterLongest);
        }
    }
}
