namespace _04._Find_Evens_or_Odds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FindsEvensOrOdds
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var condition = Console.ReadLine();
            var listOfNumbers = new List<int>();
            Predicate<int> evenOrOdds;

            for (int i = input[0]; i <= input[1]; i++)
            {
                listOfNumbers.Add(i);
            }
            if (condition=="even")
            {
                evenOrOdds = x => x % 2 == 0;
            }
            else
            {
                evenOrOdds = x => x % 2 != 0;
            }

            Console.Write(string.Join(" ", listOfNumbers.Where(x=>evenOrOdds(x))));
        }
    }
}
