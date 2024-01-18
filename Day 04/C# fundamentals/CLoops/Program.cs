using System;

namespace Cloops
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number to sum all the Integers: ");
            int value = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < value; i++)
            {
                if (i % 2 == 0 || i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }

            Console.WriteLine($"Sum of numbers divisible by 2, 3, or 5 up to {value} is: {sum}");
        }
    }
}
