using System;

namespace E04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleInJury = int.Parse(Console.ReadLine());
            string nameOfPresenattion = Console.ReadLine();
            double allGradeSum = 0;
            int counter = 0;
            while (nameOfPresenattion != "Finish") 
            {
                double gradesSum = 0;
                for (int i = 0;i < peopleInJury; i++)
                {
                    double currentGrade = double.Parse(Console.ReadLine());
                    gradesSum+= currentGrade;
                    allGradeSum+= currentGrade;
                    counter++;
                }
                double averageGrade = gradesSum/peopleInJury;
                Console.WriteLine($"{nameOfPresenattion} - {averageGrade:f2}.");


                nameOfPresenattion = Console.ReadLine();
            }
            double assessment = allGradeSum / counter;
            Console.WriteLine($"Student's final assessment is {assessment:f2}.");
        }
    }
}
