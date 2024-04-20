namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select 1 to ADD, 2 to SUBTRACT, 3 to MULPTIPLY, 4 to DIVIDE");
            Console.Write("User input: ");
            int operation = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter first number: ");
            int firstNumber = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter second number: ");
            int secondNumber = Convert.ToInt16(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    int sum = firstNumber + secondNumber;

                    Console.WriteLine($"ADD {firstNumber} and {secondNumber} the result is {sum}.");
                    break;
                case 2:

                    if (firstNumber > secondNumber)
                    {
                        int difference = firstNumber - secondNumber;

                        Console.WriteLine($"SUBTRACT {secondNumber} from {firstNumber} the result is {difference}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. First Number should be greater than Second Number");
                    }
                    break;
                case 3:
                    int product = firstNumber * secondNumber;

                    Console.WriteLine($"MULTIPLY {firstNumber} and {secondNumber} the result is {product}");
                    break;
                case 4:

                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Second number cannot be 0");
                        break;
                    }

                    if (firstNumber > secondNumber)
                    {
                        int quotient = firstNumber / secondNumber;

                        Console.WriteLine($"DIVIDE {firstNumber} to {secondNumber} the result is {quotient}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. First Number should be greater than Second Number");
                    }

                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }
    }
}