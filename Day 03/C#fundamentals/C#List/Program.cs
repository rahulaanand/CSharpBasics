using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CSharpList
{
    class Clist
    {
        public static void Main(string[] args)
        {
            List<string> names = new List<string> { "Rahul", "Aanand", "Sk" };

            names.Sort();

            Console.WriteLine("Sorted Names:");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            List<int> numbers = new List<int>();

            Console.WriteLine("Enter 10 numbers: ");

            for (int i = 0; i < 10; i++)
            {
                int input = int.Parse(Console.ReadLine());

                //Remove and add item
                numbers.Add(input);
            }
            Console.WriteLine("Position: " + numbers[9]);

            numbers.Sort();

            Console.WriteLine("Sorted Numbers:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);

            }

            Console.WriteLine("Position: " + numbers[9]);
        }
    }
}
