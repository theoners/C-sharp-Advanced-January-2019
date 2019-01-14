namespace _12._Cups_and_Bottles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CupsAndBottles
    {
        public static void Main()
        {
            var firstLine = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var secondLine = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> bottles = new Stack<int>();
            Stack<int> cups = new Stack<int>();
            var wastedWater = 0;
            for (int i = firstLine.Length - 1; i >= 0; i--)
            {
                cups.Push(firstLine[i]);
            }

            for (int i = 0; i < secondLine.Length; i++)
            {
                bottles.Push(secondLine[i]);
            }

            while (cups.Count != 0 && bottles.Count != 0)
            {
                var currentCup = cups.Pop();
                var currentBottle = bottles.Pop();
                if (currentBottle >= currentCup)
                {
                    wastedWater += currentBottle - currentCup;
                }
                else
                {
                    currentCup -= currentBottle;
                    cups.Push(currentCup);
                }
            }

            Console.WriteLine(cups.Count == 0
                ? $"Bottles: {string.Join(" ", bottles)}"
                : $"Cups: {string.Join(" ", cups)}");
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
