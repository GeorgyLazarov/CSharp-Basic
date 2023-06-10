using System;

namespace E13.EnterEvenNumber_withTextInput_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (true)
            {
                try
                {
                    Console.Write("Enter even nuber: ");
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        break;
                    }
                    Console.WriteLine("The number is not even.");
                }
                catch 
                {
                    Console.WriteLine("Invalid nuber.");
                }
            }
            Console.WriteLine($"Even number entered: {n}");
        }
    }
}
