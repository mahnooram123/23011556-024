using System;

namespace mahnoorconsoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            string opInput;
            char operation;

            Console.WriteLine("===== Simple Calculator =====\n");

            // Input first number
            Console.Write("Enter first number: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Invalid input! Enter a valid number: ");
            }

            // Input operator
            Console.Write("Enter an operator (+, -, *, /): ");
            opInput = Console.ReadLine();

            if (string.IsNullOrEmpty(opInput))
            {
                Console.WriteLine("No operator entered!");
                return;
            }

            operation = opInput[0]; // Take the first character

            // Input second number
            Console.Write("Enter second number: ");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Invalid input! Enter a valid number: ");
            }

            // Switch case based on operator
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine($"\nResult: {num1} + {num2} = {result}");
                    break;

                case '-':
                    result = num1 - num2;
                    Console.WriteLine($"\nResult: {num1} - {num2} = {result}");
                    break;

                case '*':
                    result = num1 * num2;
                    Console.WriteLine($"\nResult: {num1} * {num2} = {result}");
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"\nResult: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("\nError: Division by zero is not allowed!");
                    }
                    break;

                default:
                    Console.WriteLine("\nInvalid operator! Please use +, -, * or /");
                    break;
            }

            Console.WriteLine("\nThank you for using the calculator!");
        }
    }
}
