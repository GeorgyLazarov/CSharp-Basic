using System;

namespace E05.DateAfter5Days
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int dayInMonth = 31;
            if (m==2)
            {
                dayInMonth= 28;
            }
            else if (m==4||m==6||m==9||m==11)
            {
                dayInMonth= 30;
            }
           
            d += 5;
            if (d>dayInMonth)
            {
                d-=dayInMonth;
                m++;
                if (m>12) 
                {
                    m = 1;
                }
            }
            Console.WriteLine($"{d}.{m:D2}");
        }
    }
}
