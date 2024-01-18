using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleLinqExample
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
            List<Person> persons = new List<Person>
            {
                new Person { Name = "Rahul", Age = 15 },
                new Person { Name = "Aanand", Age = 25 },
                new Person { Name = "Sk", Age = 30 },
                new Person { Name = "Light", Age = 20 },
                new Person { Name = "Kira", Age = 12 },
            };

            var Above18 = from person in persons
                              where person.Age > 18
                              select person;

            Console.WriteLine("Person's Age more than 18:");

            foreach (var person in Above18)
            {
                Console.WriteLine($"{person.Name},{person.Age}");
            }
        }
    }
}
