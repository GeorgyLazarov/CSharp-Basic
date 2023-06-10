using System;

namespace E06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width=int.Parse(Console.ReadLine());
            int length=int.Parse(Console.ReadLine());
           
            int cakeDimensions = width * length;
            
            int cakePieces = 1 * 1;

            while(cakeDimensions>0)
            {
                
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    Console.WriteLine($"{cakeDimensions / cakePieces} pieces are left.");
                    break;
                }
                int eat = int.Parse(input);
                cakeDimensions -= eat;

            }
           
            if (cakeDimensions < 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakeDimensions)} pieces more.");

              
            }


        }
    }
}
