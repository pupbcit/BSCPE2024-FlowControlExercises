using System;
using System.Diagnostics.SymbolStore;

namespace EvaluateGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get number of grades that the user wants to input
            Console.Write("Enter how many grades you want to input: ");
            int numberOfGrades = Convert.ToInt16(Console.ReadLine());//5

            double[] grades = new double[numberOfGrades];

            //gets user input in put those in the array
            for (int counter = 0; counter < numberOfGrades; counter++)
            {
                Console.Write("Input grade: ");
                double grade = Convert.ToInt16(Console.ReadLine());

                if (grade > 0 && grade < 100)
                {
                    grades[counter] = grade;
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                }
            }

            Console.WriteLine("END OF USER INPUT");

            Console.WriteLine("PROCESSING GRADES....");

            double sum = 0;

            //access the data in the array and get their sum
            for (int counter = 0; counter < numberOfGrades; counter++)
            {
                sum = sum + grades[counter];
            }

            double average = sum / numberOfGrades;

            Console.WriteLine("The average grade is " + average);

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

            //display all grades
            Console.WriteLine("here are the grades given by your professor:");

            for (int counter = 0; counter < numberOfGrades; counter++)
            {
                Console.Write(grades[counter] + "-");
            }
        }
    }
}