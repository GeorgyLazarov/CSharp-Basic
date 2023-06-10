using System;

namespace _10._Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;
            for (int i =0; i < Math.Floor(n/2); i++)
            {

                int even = int.Parse(Console.ReadLine());
                if (i%2==0)
                {
                 leftSum = leftSum + even;
                }
                else 
                    rightSum= rightSum + even;
            }

            for (int i = 1; i <= (n/2); i ++)
            {
                int even = int.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    rightSum = rightSum + even;
                }
                else 
                {
                    leftSum = leftSum + even;
                }

            }
           
            int difference = Math.Abs(leftSum - rightSum);
            if (difference == 0)
            {
                Console.WriteLine($"Yes, sum = {rightSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {difference}");
            }            
        }
    }
}
