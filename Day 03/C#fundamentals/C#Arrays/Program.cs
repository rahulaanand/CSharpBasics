using System;
using System.Collections.Generic;

namespace CSharpArrays
{
    class Arrays
    {
        public static void Main()
        {
            List<string> Courses = new List<string>();

            Console.WriteLine("Enter courses to be added (type 'done' when finished):");
            string course;
            while ((course = Console.ReadLine()) != "done")
            {
                Courses.Add(course);
            }

            int n = Courses.Count;

            Console.WriteLine($"Total courses: {n}");

            Courses.Sort();
            Console.WriteLine("\nSorted Courses:");
            foreach (string c in Courses)
            {
                Console.WriteLine(c);
            }

            Courses.Reverse();
            Console.WriteLine("\nReverse Sorted Courses:");
            foreach (string c in Courses)
            {
                Console.WriteLine(c);
            }
        }
    }
}
