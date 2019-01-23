namespace _01._Count_Same_Values_in_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountSameValue
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            var sameValue = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!sameValue.ContainsKey(input[i]))
                {
                    sameValue.Add(input[i], 0);
                }

                sameValue[input[i]]++;
            }

            foreach (var number in sameValue)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}