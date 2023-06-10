using System;

namespace E06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string movie=string.Empty;
            int placeInCinema = 0;
            int totallTickets = 0;
            int student = 0;
            int standart = 0;
            int kid = 0;
            string ticketType = string.Empty;

            while ((movie = Console.ReadLine()) != "Finish")
            {
                placeInCinema = int.Parse(Console.ReadLine());
                int ticketsForMovie = 0;
                
                while((ticketType = Console.ReadLine()) != "End") 
                {
                    if (ticketType == "student")
                    {
                        student++;
                        totallTickets++;
                        ticketsForMovie++;

                    }
                    else if (ticketType == "standard")
                    {
                        standart++;
                        totallTickets++;
                        ticketsForMovie++;
                    }
                    else if (ticketType == "kid")
                    {
                        kid++;
                        totallTickets++;
                        ticketsForMovie++;
                    }
                    if (ticketsForMovie == placeInCinema)
                    {
                        Console.WriteLine($"{movie} - 100.00% full.");
                        break;
                    }
                    

                    
                }
                if (ticketType == "End")
                {
                    Console.WriteLine($"{movie} - {((double) ticketsForMovie/placeInCinema) * 100:f2}% full.");
                }

            }
            if (movie == "Finish")
            {
                Console.WriteLine($"Total tickets: {totallTickets}");
                Console.WriteLine($"{((double)student/totallTickets) * 100:f2}% student tickets.");
                Console.WriteLine($"{((double)standart/ totallTickets) * 100:f2}% standard tickets.");
                Console.WriteLine($"{((double) kid/ totallTickets) * 100:f2}% kids tickets.");
            }

        }
    }
}
