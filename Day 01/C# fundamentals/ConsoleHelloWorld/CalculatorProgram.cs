using System;

namespace ConsoleHelloWorld
{
    public class CalculatorProgram
    {
        public static void StartCalculator()
        {
            while (true)
            {
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice (1-5): ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        Subtract();
                        break;
                    case 3:
                        Multiply();
                        break;
                    case 4:
                        Divide();
                        break;
                    case 5:
                        Console.WriteLine("Exiting calculator program");
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        private static void Add()
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 + num2;
            Console.WriteLine($"Result: {result}");
        }

        private static void Subtract()
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 - num2;
            Console.WriteLine($"Result: {result}");
        }

        private static void Multiply()
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 * num2;
            Console.WriteLine($"Result: {result}");
        }

        private static void Divide()
        {
            Console.Write("Enter numerator: ");
            int numerator = int.Parse(Console.ReadLine());

            Console.Write("Enter denominator: ");
            int denominator = int.Parse(Console.ReadLine());

            if (denominator != 0)
            {
                int result = numerator / denominator;
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
