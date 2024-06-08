using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.XPath;

namespace SimpleCalculator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Get User Input -- operation
            Console.WriteLine("Select 1 to ADD, 2 to SUBTRACT, 3 to MULTIPLY, 4 to DIVIDE");
            Console.Write("User input: ");

            int operation = Convert.ToInt16(Console.ReadLine());

            //Get user input -- 2 numbers
            Console.Write("Enter first number: ");
            int firstNumber = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter second number: ");
            int secondNumber = Convert.ToInt16(Console.ReadLine());

            string result = Calculate(operation, firstNumber, secondNumber);

            Console.WriteLine(result);
        }

        public static string Calculate(int operation, int firstNumber, int secondNumber)
        {
            string message = "";

            switch (operation)
            {
                case 1:
                    message = $"The result is {Add(firstNumber, secondNumber)}.";

                    break;
                case 2:

                    int result = Subtract(firstNumber, secondNumber);

                    message = result >= 0 ?
                                    $"SUBTRACT {secondNumber} from {firstNumber} the result is {result}"
                                    : "Invalid input";

                    break;
                case 3:
                    message = $"MULTIPLY {firstNumber} and {secondNumber} the result is {Multiply(firstNumber, secondNumber)}";
                    break;
                case 4:

                    //validation
                    if (secondNumber == 0)
                    {
                        message = "Second number cannot be 0";
                        break;
                    }

                    if (firstNumber > secondNumber)
                    {
                        int quotient = firstNumber / secondNumber;

                        message = $"DIVIDE {firstNumber} to {secondNumber} the result is {quotient}";

                    }
                    else
                    {
                        message = "Invalid input. First Number should be greater than Second Number";
                    }

                    break;
                default:
                    message = "Invalid input.";
                    break;
            }

            return message;
        }

        public static int Add(int num1, int num2) //method signature
        {
            int sum = num1 + num2;

            return sum;
        }

        public static int Subtract(int num1, int num2)
        {
            int difference = -1;
            
            if (num1 > num2)
            {
              difference = num1 - num2;
            }

            return difference;
        }

        public static int Multiply(int num1, int num2) //method signature
        {
            int product = num1 * num2;

            return product;
        }

    }
}