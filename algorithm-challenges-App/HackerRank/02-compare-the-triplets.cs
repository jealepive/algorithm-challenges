using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace algorithm_challenges_App.HackerRank
{
    public class Solution_2
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
