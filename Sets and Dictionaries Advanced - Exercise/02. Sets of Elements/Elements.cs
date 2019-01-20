namespace _02._Sets_of_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Elements
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var n = input[0];
            var m = input[1];
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                firstSet.Add(number);
            }

            for (int i = 0; i < m; i++)
            {
                var number = int.Parse(Console.ReadLine());
                secondSet.Add(number);
            }

            firstSet.IntersectWith(secondSet);

            Console.WriteLine(string.Join(" ", firstSet));
        }
    }
}
