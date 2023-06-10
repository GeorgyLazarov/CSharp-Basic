using System;
using System.ComponentModel;

namespace E01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string surchBook = Console.ReadLine();
            int n = 0;
            string currentBook=string.Empty;
            while (currentBook != "No More Books") 
            {
                currentBook= Console.ReadLine();
                if (currentBook == surchBook)
                {
                    Console.WriteLine($"You checked {n} books and found it.");
                    break;
                }
                if (currentBook != "No More Books")
                {
                    n++;
                }
            }
            if (currentBook=="No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {n} books.");
            }
        }
    }
}
