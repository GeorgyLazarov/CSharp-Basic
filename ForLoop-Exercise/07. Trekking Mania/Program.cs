using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grupNum = int.Parse(Console.ReadLine());
            int parMusala = 0;
            int parMonblan = 0; 
            int parKilimanjaro = 0; 
            int parK2 = 0; 
            int parEverest = 0;
            int totalPeople = 0;

            for (int i = 1; i <= grupNum; i++)
            {
                int peopleTrekking = int.Parse(Console.ReadLine());
                totalPeople+= peopleTrekking;
                if (peopleTrekking > 0 && peopleTrekking <= 5)
                {
                    parMusala+=peopleTrekking;
                }
                else if(peopleTrekking > 5 && peopleTrekking <= 12)
                {
                    parMonblan+=peopleTrekking;
                }
                else if (peopleTrekking > 12 && peopleTrekking <= 25)
                {
                    parKilimanjaro += peopleTrekking;
                }
                else if (peopleTrekking > 25 && peopleTrekking <= 40)
                {
                    parK2 += peopleTrekking;
                }
                else if (peopleTrekking > 40 )
                {
                    parEverest += peopleTrekking;
                }
            }
            Console.WriteLine($"{(double)parMusala / totalPeople * 100:f2}%");
            Console.WriteLine($"{(double)parMonblan / totalPeople * 100:f2}%");
            Console.WriteLine($"{(double)parKilimanjaro / totalPeople * 100:f2}%");
            Console.WriteLine($"{(double)parK2 / totalPeople * 100:f2}%");
            Console.WriteLine($"{(double)parEverest / totalPeople * 100:f2}%");
        }
    }
}
