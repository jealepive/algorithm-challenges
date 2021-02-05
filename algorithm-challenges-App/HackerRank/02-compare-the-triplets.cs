using System.Collections.Generic;
using System.Linq;

namespace algorithm_challenges_App.HackerRank
{
    public class _02_compare_the_triplets
    {
        // Complete the compareTriplets function below.
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> scores = new List<int>() { 0, 0 };
            for (int i = 0; i < a.Count(); i++)
            {
                if (a[i] > b[i])
                {
                    scores[0] += 1;
                }
                else if (a[i] < b[i])
                {
                    scores[1] += 1;
                }
            }

            return scores;
        }
    }
}