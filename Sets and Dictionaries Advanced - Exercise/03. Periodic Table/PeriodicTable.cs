namespace _03._Periodic_Table
{
    using System;
    using System.Collections.Generic;

    public class PeriodicTable
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            SortedSet<string> chemicalCompounds = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ');

                for (int j = 0; j < input.Length; j++)
                {
                    chemicalCompounds.Add(input[j]);
                }
            }
            Console.WriteLine(string.Join(" ", chemicalCompounds));
        }
    }
}
