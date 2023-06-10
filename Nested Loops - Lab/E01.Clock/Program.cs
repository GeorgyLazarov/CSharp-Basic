using System;
using System.Threading;

namespace E01.Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           
            for (int h=0;h<24;h++) 
            {
                for (int m=0;m<60;m++)
                {

                    for (int s = 0; s < 60; s++)
                    {
                        Console.Write($"{h:D2}:{m:D2}:{s:D2}");
                        Thread.Sleep(900);
                        Console.Clear();
                    }
                }
            }
            
        }
    }
}
