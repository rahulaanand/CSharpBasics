using System;

namespace fundamentals
{
    class program
    {
        public static void Main(string[] args)
        {
            //using While statement
            int NumCounter = int.Parse(Console.ReadLine());
            while (NumCounter < 50)
            {
                NumCounter = NumCounter + 2;
                Console.WriteLine(NumCounter);
            }

            //Using if, while and do
            Console.WriteLine("Enter the Number btw 1 to 10:");

            int NumberCounter = int.Parse(Console.ReadLine());

            if (NumberCounter > 0 && NumberCounter < 10)
            {
                do
                {
                    Console.WriteLine(NumberCounter);
                    NumberCounter++;
                } while (NumberCounter < 10);
            }

            else
            {
                Console.WriteLine("Oops, you've entered the wrong number");
            }

            //for loop

            Console.WriteLine("Enter the digit of *'s to be displayed: ");
            int num = int.Parse(Console.ReadLine());
            for ( int i = 0; i < num; i++ )
            {
                for ( int j = 0; j < i; j++ )
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine("\n");
            }
        }
    }
}