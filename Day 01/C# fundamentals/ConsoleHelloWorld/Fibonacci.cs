using System;

class Fibonacci
{
    public static void FibonacciProgram()
    {
        Console.WriteLine("Fibonacci Program");

        int numberOfTerms;

        do
        {
            Console.Write("Enter the number of terms: ");
        } while (!int.TryParse(Console.ReadLine(), out numberOfTerms) || numberOfTerms <= 0);

        Console.WriteLine("Fibonacci Series:");

        int firstTerm = 0, secondTerm = 1;

        for (int i = 0; i < numberOfTerms; i++)
        {
            Console.Write($"{firstTerm} ");

            int nextTerm = firstTerm + secondTerm;
            firstTerm = secondTerm;
            secondTerm = nextTerm;
        }
    }
}
