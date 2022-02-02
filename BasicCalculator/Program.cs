using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            string operation;

            Console.WriteLine("Please input operation type: +, -, /, *");
            operation = Console.ReadLine();

            Console.WriteLine("Please input first number");
            firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input second number");
            secondNumber = int.Parse(Console.ReadLine());

            var result = Calculate(firstNumber, secondNumber, operation);

            Console.WriteLine($"The answer is {result}");  
        }

        private static int Calculate(int firstNumber, int secondNumber, string operation)
        {
            if (operation == "+")
            {
                return Operations.Add(firstNumber, secondNumber);
            }
            else if (operation == "-")
            {
                return Operations.Subtract(firstNumber, secondNumber);
            }
            else if (operation == "/")
            {
                return Operations.Divide(firstNumber, secondNumber);
            }
            else if (operation == "*")
            {
                return Operations.Multiply(firstNumber, secondNumber);
            }
            else
            {
                ErrorHandling.HandleInvalidOperation(operation);
            }

            return 0;
        }
    }
}
