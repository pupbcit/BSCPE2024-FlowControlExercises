namespace EvaluateGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstGrade, secondGrade;

            Console.Write("Input First Grade: ");
            firstGrade = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input Second Grade: ");
            secondGrade = Convert.ToDouble(Console.ReadLine());

            //ADD LOOP AND INTRODUCE METHODS

            if ((firstGrade > 0 && firstGrade < 100) && (secondGrade > 0 && secondGrade < 100))
            {
                double average = (firstGrade + secondGrade) / 2;

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
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}