using System;

namespace linq
{
    class Linq
    {
        public static void Main(string[] args)
        {
            List<int> scores = new List<int>() { 95, 80, 65, 100, 75 };

            var sortedScores = from score in scores
                               orderby score descending
                               select score;

            foreach (var score in sortedScores)
            {
                Console.WriteLine(score);
            }

        }
    }
}