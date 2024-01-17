using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Fibonacci
    {
        public static void Main(string[] args)
        {
            var num = new List<int> { 1, 1 };

           while(num.Count < 20)
            {
                var previous = num[num.Count - 1];
                var previous2 = num[num.Count - 2];

                num.Add(previous+ previous2);
            }

           foreach(int i in num)
            {
                Console.WriteLine(i);
            }
        }
    }
}
