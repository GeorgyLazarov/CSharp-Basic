using System;

namespace E05.Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstNum = n/100;
            int secondNum =n%100/10;
            int thirdNum = n%10;
            int currentNum = n;
            int N = firstNum + secondNum;
            int M = firstNum + thirdNum;
            for (int i =n;i>0;i--) 
            {
                M--;
                
                if (currentNum%5==0)
                {
                    currentNum -= firstNum;
                   
                }
                else if (currentNum%3==0) 
                {
                    currentNum -= secondNum;
                }
                else
                {
                    currentNum+=thirdNum;
                }
                Console.Write($"{currentNum} ");
                if(M==0)
                {
                    Console.WriteLine();
                    N--;
                    M= firstNum + thirdNum;
                }
                if(N==0)
                {
                    break;
                }
            }
        }
    }
}
