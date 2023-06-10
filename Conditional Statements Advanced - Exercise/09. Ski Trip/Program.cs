using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string opinion = Console.ReadLine();
            double price = 0;
            if (roomType == "room for one person")
            {
                price = 18;
            }
            else if (roomType == "apartment")
            {
                price = 25;
                if (days<10)
                {
                    price -= price * 0.3;
                }
                else if ((days>=10)&&(days<=15)) 
                {
                    price -= price * 0.35; 
                }
                else if(days > 15)
                {
                    price -= price * 0.5;
                }
            }
            else if (roomType == "president apartment")
            {
                price = 35;
                if (days <10)
                {
                    price -= price * 0.1;
                }
                else if ((days >= 10) && (days <= 15)) 
                {
                    price -= price * 0.15;
                }
                else if (days > 15)
                {
                    price -= price * 0.2; 
                } 
            }
            if (opinion =="positive")
            {
                price += price * 0.25;
            }
            else if (opinion =="negative")
            {
                price -= price * 0.1;
            }
            double total = (double)(days-1) * price;
            Console.WriteLine($"{total :f2}");
        }
    }
}
