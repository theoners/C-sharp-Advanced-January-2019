namespace _06._Reverse_And_Exclude
{
    using System;
    using System.Linq;

    public class ReverseAndExclude
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .Reverse()
                 .ToList();
            var n = int.Parse(Console.ReadLine());
            bool Filter(int x) => x % n != 0;
            //Predicate<int> filter = x => x % n != 0;
            Console.WriteLine(string.Join(" ", numbers.Where(Filter)));
        }
    }
}
