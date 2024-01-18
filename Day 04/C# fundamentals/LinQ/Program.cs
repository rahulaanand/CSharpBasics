//Language Integrated Query (LinQ)

using System;

namespace linq
{
    public class Linq
    {
        public static void Main(String[] args)
        {
            List <int> numbers = new List <int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var lownum = from num in numbers
                         where num % 2 == 0
                         select num;

            //It will throw System.Linq.Enumerable+WhereListIterator`1[System.Int32]
            //-  - Console.WriteLine(lownum);


            foreach (var x in lownum)
            {
                Console.WriteLine(x);
            }
        }
    }
}