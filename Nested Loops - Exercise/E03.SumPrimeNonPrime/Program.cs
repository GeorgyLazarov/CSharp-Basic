using System;

namespace E03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int primeSum = 0;
            int nonPrimeSum = 0;
            while (input != "stop") 
            {
                int num = int.Parse(input);
                int counter = 0;
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }
                if (num == 0) 
                {
                    input = Console.ReadLine();
                    continue;
                }
                for (int i = 1; i <= num;i++) 
                {
                    if (num % i == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 2) 
                {
                    primeSum += num;
                }
                else
                {
                    nonPrimeSum += num;
                }
               

                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
