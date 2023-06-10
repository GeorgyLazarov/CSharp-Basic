using System;

namespace E03.StopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());
           // if (N>=0 && N <= S && N<M && S <= M && M<=10000)
          //  {
                for (int i =M;i>=N;i--) 
                {
                    if (i % 2 == 0 && i % 3 == 0)
                    {
                        if (i==S)
                        {
                            break;
                        }
                        Console.Write($"{i} ");
                    }
                }
          //  }

        }
    }
}
