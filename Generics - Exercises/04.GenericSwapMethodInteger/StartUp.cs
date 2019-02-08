namespace _04.GenericSwapMethodInteger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var list = new Box<int>();

            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var firstIndex = input[0];
            var secondIndex = input[1];

            Swap(list.Data, firstIndex, secondIndex);

            list.Data.ForEach(x => Console.WriteLine($"{x.GetType()}: {x}"));
        }

        private static void Swap<T>(List<T> list, int firstIndex, int secondIndex)
        {
            var temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }
    }
}

