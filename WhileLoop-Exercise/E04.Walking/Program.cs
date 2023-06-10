using System;
using System.Security.Cryptography;

namespace E04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            string input=Console.ReadLine();
            while (input != "Going home") 
            {
                steps += int.Parse(input);
                if (steps >= 10000)
                {

                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{steps - 10000} steps over the goal!");
                    break;
                }
                input = Console.ReadLine();
            
            }
            
            
            if (input == "Going home")
            {
               
                int stepsToHome = int.Parse(Console.ReadLine());
                if (steps + stepsToHome > 10000)
                {
                    
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{steps + stepsToHome - 10000} steps over the goal!");
                }
                else if((steps + stepsToHome) < 10000)
                {
                    Console.WriteLine($"{10000 - (steps+ stepsToHome)} more steps to reach goal.");
                }
            }
            
            
        }
    }
}
