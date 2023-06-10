using System;

namespace E03.PointonSegment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first=int.Parse(Console.ReadLine());
            int second=int.Parse(Console.ReadLine());
            int point=int.Parse(Console.ReadLine());
            int left=Math.Min(first,second);
            int right=Math.Max(first,second);
            int leftDistance =Math.Abs(left-point);
            int rightDistance =Math.Abs(right-point);
            int minDistance = Math.Min(leftDistance,rightDistance);
            if(left<=point&&point<=right) 
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
            Console.WriteLine(minDistance);
        }
    }
}
