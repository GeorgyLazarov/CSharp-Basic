using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNum = int.MinValue; ;
            int sum = 0;
            int num;
            for (int i = 1; i <= n; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > maxNum)
                {
                    maxNum = num;
                }
               
            }
            sum -= maxNum;
            if (maxNum == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum-maxNum)}");
            }
        }
    }
}
