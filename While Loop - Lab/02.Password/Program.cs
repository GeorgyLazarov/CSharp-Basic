﻿using System;

namespace _02.Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = Console.ReadLine();

            string input = Console.ReadLine();
            while (input != password) 
            {
               input = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {userName}!");
        }
    }
}
