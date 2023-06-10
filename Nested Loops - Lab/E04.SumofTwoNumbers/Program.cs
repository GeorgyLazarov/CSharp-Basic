using System;

namespace E04.SumofTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start =  int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int comboCounter = 0;
            bool comboFound=false;
            int i, j = 0;
            for (i = start;i<=end;i++)
            {
                for(j= start;j<=end;j++)
                {
                    comboCounter++;
                    
                    if (i + j == magicNum)
                    {
                        comboFound= true;
                        break;
                    }
                   
                }
                if(comboFound)
                {
                    break;
                }

            }
            if (comboFound)
            {
                Console.WriteLine($"Combination N:{comboCounter} ({i} + {j} = {magicNum})");

            }
            else
            {
                Console.WriteLine($"{comboCounter} combinations - neither equals {magicNum}");
            }
        }
    }
}
