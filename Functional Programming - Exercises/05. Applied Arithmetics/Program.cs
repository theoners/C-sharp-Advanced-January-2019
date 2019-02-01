namespace _05._Applied_Arithmetics
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var listOfNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                var command = Console.ReadLine();
                if (command=="end")
                {
                    break;
                }

                Func<int, int> manipulateList;

                switch (command)
                {
                    case "add":
                        manipulateList = x => x + 1;
                        break;
                    case "subtract":
                        manipulateList = x => x - 1;
                        break;
                    case "multiply":
                        manipulateList = x => x * 2;
                        break;
                    default:
                        manipulateList = x => x;
                        break;
                }

              listOfNumbers= listOfNumbers.Select(manipulateList).ToList();

                if (command=="print")
                {
                    Console.WriteLine(string.Join(" ", listOfNumbers));
                }
            }
        }
    }
}
