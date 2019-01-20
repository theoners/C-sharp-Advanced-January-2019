namespace _05._Count_Symbols
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountSymbol
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var charCount = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!charCount.ContainsKey(input[i]))
                {
                    charCount.Add(input[i], 0);
                }

                charCount[input[i]]++;
            }

            foreach (var symbol in charCount.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}