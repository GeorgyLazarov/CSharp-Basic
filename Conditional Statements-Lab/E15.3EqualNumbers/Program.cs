﻿using System;

namespace E15._3EqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            if (firstNum == secondNum && secondNum == thirdNum) 
            {
                Console.WriteLine("yes");
            }
            else
            { 
                Console.WriteLine("no");
            }
        }
    }
}
