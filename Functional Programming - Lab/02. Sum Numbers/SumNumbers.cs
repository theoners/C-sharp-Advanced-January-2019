using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    public class SumNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToList();
            Console.WriteLine(input.Count);
            Console.WriteLine(input.Sum());
        }
    }
}
