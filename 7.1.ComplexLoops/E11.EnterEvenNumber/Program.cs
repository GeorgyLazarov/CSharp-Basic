using System;

namespace E11.EnterEvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while(true)
            {
                Console.Write("Enter even nuber: ");
                n = int.Parse(Console.ReadLine());
                if(n%2==0)
                {
                    break;
                }
                Console.WriteLine("The number is not even.");
            }
            Console.WriteLine($"Even number entered: {n}");
        }
    }
}
