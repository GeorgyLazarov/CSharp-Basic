using System;

namespace _08.OnTimeforTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());

            int examTime = examHour * 60 + examMinutes;
            int arrivalTime = arriveHour* 60 + arriveMinutes;

            if (arrivalTime > examTime)
            {
                Console.WriteLine("Late");
                if (arrivalTime-examTime<60)
                {
                    Console.WriteLine($"{arrivalTime-examTime}minutes after the start.");
                }
                else 
                {
                    int hour = (arrivalTime - examTime) / 60;
                    int minutes = (arrivalTime - examTime) % 60;
                    Console.WriteLine($"{ hour} : {minutes:D2} hours after the start");
                }
            }
            else if (arrivalTime == examTime || examTime - arrivalTime <= 30)
            {
                Console.WriteLine("On time");
               
                if (examTime - arrivalTime != 0)
                {
                    int minutes = examTime - arrivalTime;
                    Console.WriteLine($"{minutes} minutes before the start");
                }
            }
            else if(examTime - arrivalTime>30) 
            {
                Console.WriteLine("Early");
                if ((examTime - arrivalTime) < 60)
                {
                    int minutes = examTime - arrivalTime;
                    Console.WriteLine($"{minutes} minutes before the start");
                }
                else
                {
                    int hour = (examTime - arrivalTime) / 60;
                    int minutes = (examTime - arrivalTime) % 60;
                    Console.WriteLine($"{hour}:{minutes:D2} hours before the start");
                }
             
            }
        }

    }
}
