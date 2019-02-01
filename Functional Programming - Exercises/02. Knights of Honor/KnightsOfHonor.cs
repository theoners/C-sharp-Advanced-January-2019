namespace _02._Knights_of_Honor
{
    using System.Linq;

    using System;

    public class KnightsOfHonor
    {
        public static void Main()
        {
            var peoples = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            void Print(string x) => Console.WriteLine("Sir " + x);

            foreach (var people in peoples)
            {
                Print(people);
            }
        }
    }
}
