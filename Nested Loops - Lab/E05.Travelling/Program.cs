using System;

namespace E05.Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination=string.Empty;
            
            while ((destination = Console.ReadLine()) != "End") 
            {               
                int savedMoney = 0;
                int budget = int.Parse(Console.ReadLine());
                while (savedMoney< budget)
                {
                    savedMoney += int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");
                
            }           
        }
    }
}
