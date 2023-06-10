using System;

namespace Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstname = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());

            int hours = projects * 3;
            Console.WriteLine("The architect {0} will need {2} hours to complete {1} project/s.",firstname, projects,hours);
        }
    }
}
