using System;

namespace E02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int unsetisGrades = int.Parse(Console.ReadLine());
           
            int totalExercises = 0;
            int totalGrades = 0;
            int repeats = 0;
            string currentExercise=string.Empty;
            string input = Console.ReadLine();
            int grade;
            while (input != "Enough")
            {
                currentExercise = input;
                grade = int.Parse(Console.ReadLine());
                totalExercises++;
                totalGrades += grade;
                

                if (grade <= 4)
                {
                    repeats++;
                    if (repeats >= unsetisGrades)
                    {
                        Console.WriteLine($"You need a break, {repeats} poor grades.");
                        break;
                    }
                }
                input = Console.ReadLine();
            }
            
            if (input =="Enough")

            {
                Console.WriteLine($"Average score: {(double)totalGrades / totalExercises:f2}");
                Console.WriteLine($"Number of problems: {totalExercises}");
                Console.WriteLine($"Last problem: {currentExercise}");
            }

        }
    }
}
