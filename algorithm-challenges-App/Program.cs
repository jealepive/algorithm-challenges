using algorithm_challenges_App.HackerRank;
using System;
using System.Collections.Generic;
using System.Linq;

namespace algorithm_challenges_App
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = _03_diagonal_difference.diagonalDifference(arr);

            print(result);
        }

        public static Action<int> print = (number) =>
         {
             Console.WriteLine($"El resultado es : {number}");
             Console.ReadLine();
         };

        //int resultado = Solution_1.simpleArraySum(new int[] { 1, 2, 3 });

        //print(resultado);
    }
}