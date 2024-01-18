using System;

namespace linq
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person { Name = "Rahul", Age = 21 },
                new Person { Name = "Aanand", Age = 22 },
                new Person { Name = "Sk", Age = 42 }
            };

            var namesAndAges = from person in people
                               select new { person.Name, person.Age };

            foreach (var item in namesAndAges)
            {
                Console.WriteLine($"Name: {item.Name}, Age: {item.Age}");
            }
        }
    }
}
