using System;

namespace E12.BreakSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // int firstNum = int.Parse(Console.ReadLine());
            //int secondNum = int.Parse(Console.ReadLine());
            bool hasToEnd = false;
            for (int i = 1;i<=3;i++) 
            {
                if (hasToEnd==false) 
                {
                    for (int j=3;j>=1;j--)
                    {
                        if (i+j==2)
                        {
                            hasToEnd = true;
                            break;
                        }
                        Console.WriteLine(i+" "+j);
                    }
                }
            }
        }
    }
}
