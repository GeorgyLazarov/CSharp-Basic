using System;

namespace E03.PowersofTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            for (int i = 0; i <= n; i++) 
            {
                Console.WriteLine(num);
                num = num * 2;                
            }
        }
    }
}
