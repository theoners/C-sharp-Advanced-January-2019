namespace _13._TriFunction
{
    using System;
    using System.Linq;

    public class TriFunction
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(Console.ReadLine()
                .Split()
                .FirstOrDefault(x => x.ToCharArray().Select(y => (int) y).Sum() >= n));
        }
    }
}
