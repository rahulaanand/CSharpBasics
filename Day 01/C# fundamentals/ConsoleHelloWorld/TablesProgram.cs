using System;

namespace ConsoleHelloWorld
{
    public class TablesProgram
    {
        public static void MultipleProgram()
        {
            Console.WriteLine("Welcome to Tables Program..!");

            Console.Write("\nEnter the Number for the table: ");

            int number = int.Parse(Console.ReadLine());
            
            if(number > 0) {
                Console.WriteLine("\n\nWait for second!");
                if (number > 0)
                {
                    Console.WriteLine($"Multiplication Table for {number}:");
                    for (int i = 1; i <= 10; i++)
                    {
                        int result = number * i;
                        Console.WriteLine($"{number} x {i} = {result}");
                    }
                }
                else
                {
                    Console.WriteLine("\nPlease enter a positive integer");
                }
            }
            else
            {
                Console.WriteLine("\nPlease enter a valid integer.");
            }
        }
    }
}
