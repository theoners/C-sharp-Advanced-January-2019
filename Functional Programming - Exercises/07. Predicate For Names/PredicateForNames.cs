namespace _07._Predicate_For_Names
{
    using System;
    using System.Linq;

    public class PredicateForNames
    {
        public static void Main()
        {
            var nameLength = int.Parse(Console.ReadLine());
            Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Where(x => x.Length <= nameLength)
                 .ToList()
                 .ForEach(Console.WriteLine);
        }
    }
}
