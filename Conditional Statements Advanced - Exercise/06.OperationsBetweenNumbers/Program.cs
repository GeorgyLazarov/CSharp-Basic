using System;
using System.Dynamic;

namespace _06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            if ((operation == "+") || (operation == "-") || (operation == "*"))
            {
                int result = 0;
                string condition = "even";
                if (operation == "+")
                {
                    result = numberOne + numberTwo; 
                }
                else if (operation =="-")
                {
                    result = numberOne - numberTwo;
                }
                else if (operation == "*") 
                {
                    result = numberOne * numberTwo;
                }
                if (result % 2 != 0)
                {
                    condition = "odd";
                }
                Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result} - {condition}");
            }
            else 
            {
                if (numberTwo == 0)
                {
                    Console.WriteLine($"Cannot divide {numberOne} by zero");
                }
                else if (operation == "/")
                {
                    double result = (double)numberOne / numberTwo;
                    Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result:f2}");
                }
                else if (operation == "%")
                {
                    double result = (double)numberOne % numberTwo;
                    Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result}");
                }
                
            }
        }
    }
}
