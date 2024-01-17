using System;

namespace csharpstrings
{
    class MultiplesFinder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to find its multiples: ");

            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine($"Multiples of {num}:");

                for (int i = 1; i <= 100; i++)
                {
                    if (i % num == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
