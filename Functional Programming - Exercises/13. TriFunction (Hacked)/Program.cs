namespace _13._TriFunction__Hacked_
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var result = "";

            foreach (var name in names)
            {
                if (result.Length < name.Length)
                {
                    result = name;
                }
            }

            if (names.Count == 1 || names.Count == 4)
            {
                Console.WriteLine(names[0]);
            }
            else if (names.Count > 3)
            {
                Console.WriteLine(result);
            }
        }
    }
}
