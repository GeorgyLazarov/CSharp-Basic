using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartmentPrice = 0;
            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                apartmentPrice = 65;
                if (nights > 7 && nights < 14)
                {
                    studioPrice -= studioPrice * 0.05;
                }
                else if (nights > 14)
                {
                    studioPrice -= studioPrice * 0.3;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.2;
                apartmentPrice = 68.7;
                if (nights > 14)
                {
                    studioPrice -= studioPrice * 0.2;
                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76;
                apartmentPrice = 77;
            }
            if (nights > 14)
            {
                apartmentPrice -= apartmentPrice * 0.1;
            }
            double totalApartmentPrice = (double)nights * apartmentPrice;
            double totalStudioPrice = (double)nights * studioPrice;
            Console.WriteLine($"Apartment: {totalApartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
        }
    }
}
