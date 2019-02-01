namespace _12._Inferno_III
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Inferno
    {
        public static void Main()
        {
            var gems = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var listOfCommands = new List<string>();
            var gemsForRemove = new HashSet<int>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Forge")
                {
                    break;
                }

                if (input.Contains("Exclude"))
                {
                    listOfCommands.Add(input.Substring(8, input.Length - 8));
                }
                else
                {
                    while (listOfCommands.Contains(input.Substring(8, input.Length - 8)))
                    {
                        listOfCommands.Remove(input.Substring(8, input.Length - 8));
                    }
                }
            }

            foreach (var command in listOfCommands)
            {
                var condition = command.Split(";", StringSplitOptions.RemoveEmptyEntries)[0];
                var value = int.Parse(command.Split(";")[1]);

                for (int i = 0; i < gems.Count; i++)
                {
                    if (GetSum(gems, condition, value)(i))
                    {
                        gemsForRemove.Add(i);
                       
                    }
                }
            }

            foreach (var index in gemsForRemove.OrderByDescending(x => x))
            {
                gems.RemoveAt(index);
            }

            Console.WriteLine(string.Join(" ", gems));
        }

        public static Predicate<int> GetSum(List<int> gems, string condition, int value)
        {
            switch (condition)
            {
                case "Sum Left":
                    return i => (i != 0 ? gems[i - 1] : 0) + gems[i] == value;

                case "Sum Right":
                    return i => gems[i] + (i != gems.Count - 1 ? gems[i + 1] : 0) == value;
                case "Sum Left Right":
                    return i => (i != 0 ? gems[i - 1] : 0) + gems[i] + (i != gems.Count - 1 ? gems[i + 1] : 0) == value;
                default:
                    return null;
            }
        }
    }
}
