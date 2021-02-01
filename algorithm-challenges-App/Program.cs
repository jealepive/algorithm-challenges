using System;
using algorithm_challenges_App.HackerRank;

namespace algorithm_challenges_App
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Action<int> print = (number) =>
            {
                Console.WriteLine($"El resultado es : {number}");
                Console.ReadLine();
            };

            int resultado = Solution_1.simpleArraySum(new int[] { 1, 2, 3 });

            print(resultado);
        }
    }
}