namespace _06._Wardrobe
{
    using System;
    using System.Collections.Generic;

    public class Wardrobe
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new string[] { ",", " -> " }, StringSplitOptions.RemoveEmptyEntries);

                var color = input[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                for (int j = 1; j < input.Length; j++)
                {
                    if (!wardrobe[color].ContainsKey(input[j]))
                    {
                        wardrobe[color].Add(input[j], 0);
                    }

                    wardrobe[color][input[j]]++;
                }
            }

            var searchClothes = Console.ReadLine()
                .Split(' ');

            var dressColor = searchClothes[0];
            var searchDress = searchClothes[1];

            foreach (var dress in wardrobe)
            {
                Console.WriteLine($"{dress.Key} clothes:");

                foreach (var kvp in dress.Value)
                {
                    Console.Write($"* {kvp.Key} - {kvp.Value}");

                    if (dressColor == dress.Key && searchDress == kvp.Key)
                    {
                        Console.WriteLine($" (found!)");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}