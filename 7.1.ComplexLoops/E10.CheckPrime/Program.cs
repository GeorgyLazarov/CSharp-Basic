using System;

namespace E10.CheckPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =0;
            bool prime = true;
            try
            {
                n = int.Parse(Console.ReadLine());
                if (n > 1)
                {
                    for (int i = 2; i <= n - 1; i++)
                    {
                        if (n % i == 0)
                        {
                            prime = false;
                            break;
                        }

                    }
                }
                else
                {
                    prime = false;
                }
                if (prime)
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not prime");
                }
            }
            catch
            {
                Console.WriteLine("Invalid number");
            }
           
        }
    }
}
