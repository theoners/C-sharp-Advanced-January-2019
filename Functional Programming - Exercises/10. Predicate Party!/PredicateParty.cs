namespace _10._Predicate_Party_
{
    using System;
    using System.Linq;

    public class PredicateParty
    {
        public static void Main()
        {
            var listOfGuest = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                var command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "Party!")
                {
                    break;
                }

                var condition = command[2];
                Func<string, bool> filter;
                switch (command[0])
                {
                    case "Remove" when command[1] == "StartsWith":
                        filter = x => !x.StartsWith(condition);
                        break;
                    case "Remove" when command[1] == "EndsWith":
                        filter = x => !x.EndsWith(condition);
                        break;
                    case "Remove":
                        filter = x => x.Length != int.Parse(condition);
                        break;
                    case "Double" when command[1] == "StartsWith":
                        filter = x => x.StartsWith(condition);
                        break;
                    case "Double" when command[1] == "EndsWith":
                        filter = x => x.EndsWith(condition);
                        break;
                    default:
                        filter = x => x.Length == int.Parse(condition);
                        break;
                }

                if (command[0] == "Remove")
                {
                    listOfGuest = listOfGuest.Where(filter).ToList();
                }
                else
                {
                    var tempList = listOfGuest.Where(filter).ToList();
                    foreach (var name in tempList)
                    {
                        var index = listOfGuest.IndexOf(name);
                        listOfGuest.Insert(index,name);
                    }
                }
            }

            Console.WriteLine(listOfGuest.Any()
                ? $"{string.Join(", ", listOfGuest)} are going to the party!"
                : "Nobody is going to the party!");
        }
    }
}
