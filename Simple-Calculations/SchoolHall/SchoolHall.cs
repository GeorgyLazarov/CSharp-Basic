using System;

namespace SchoolHall
{
    class SchoolHall
    {
        static void Main(string[] args)
        {
           double lenght = double.Parse(Console.ReadLine());
           double width = double.Parse(Console.ReadLine());
           double cols = Math.Truncate(lenght * 100  / 120);
           double rows = Math.Truncate((width * 100 - 100) / 70);
           //Console.WriteLine(rows);
           //Console.WriteLine(cols);
           double numWorkPlaces = cols * rows -3;
           Console.WriteLine(numWorkPlaces);
        }
    }
} 
