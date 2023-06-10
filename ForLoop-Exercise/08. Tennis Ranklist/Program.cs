using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());
            int stageW = 0;
            int winPoints = 0;
           
            for (int tournament=1;tournament<=n;tournament++) 
            {
                string stage = Console.ReadLine();
                if (stage == "W")
                {
                    points += 2000;
                    winPoints += 2000;
                    stageW++;
                }
                else if (stage == "F")
                {
                    points += 1200;
                    winPoints += 1200;

                }
                else if (stage == "SF")
                {
                    points += 720;
                    winPoints += 720;
                }
            }
            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor((double)winPoints/n)}");
            Console.WriteLine($"{(double)stageW/n*100:f2}%");

        }
    }
}
