using System;

namespace EvaluateGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get number of grades that the user wants to input
            Console.Write("Enter how many grades you want to input: ");
            int numberOfGrades = Convert.ToInt16(Console.ReadLine()); //5

            double sum = 0;

            for (int counter = 0; counter < numberOfGrades; counter++)
            {
                Console.Write("Input grade: ");
                double grade = Convert.ToInt16(Console.ReadLine());

                if (grade > 0 && grade < 100)
                {
                    sum = sum + grade;
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                }

            }

            double average = sum / numberOfGrades;

            Console.WriteLine("Your average is " + average);

            if (average <= 50)
            {
                Console.WriteLine("FAILED");
            }
            else if (average > 50 && average <= 70)
            {
                Console.WriteLine("FAIR");
            }
            else if (average > 70 && average <= 80)
            {
                Console.WriteLine("GOOD");
            }
            else if (average > 80 && average <= 90)
            {
                Console.WriteLine("VERY GOOD");
            }
            else if (average > 90 && average <= 100)
            {
                Console.WriteLine("EXCELLENT");
            }
        }
    }
}