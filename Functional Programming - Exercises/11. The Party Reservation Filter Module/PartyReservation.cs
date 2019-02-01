namespace _11._The_Party_Reservation_Filter_Module
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PartyReservation
    {
        public static void Main()
        {
            var peoples = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var filters = new Dictionary<string, List<string>>();
            while (true)
            {
                var commands = Console.ReadLine()
                    .Split(";", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (commands[0] == "Print")
                {
                    break;
                }

                var addOrRemove = commands[0];
                var filter = commands[1];
                var condition = commands[2];
                if (addOrRemove == "Add filter")
                {
                    if (!filters.ContainsKey(filter))
                    {
                        filters.Add(filter, new List<string>());
                    }

                    if (!filters[filter].Contains(condition))
                    {
                        filters[filter].Add(condition);
                    }
                }
                else
                {
                    if (filters.ContainsKey(filter))
                    {
                        filters[filter].Remove(condition);
                    }
                }
            }

            foreach (var filter in filters)
            {
                if (filter.Key== "Starts with")
                {
                    foreach (var condition in filter.Value)
                    {
                        peoples = peoples.Where(x => !x.StartsWith(condition)).ToList();
                    }
                    
                }
                else if (filter.Key=="Ends with")
                {
                    foreach (var condition in filter.Value)
                    {
                        peoples = peoples.Where(x => !x.EndsWith(condition)).ToList();
                    }
                }
                else if(filter.Key== "Length")
                {
                    foreach (var condition in filter.Value)
                    {
                        peoples = peoples.Where(x => x.Length!=int.Parse(condition)).ToList();
                    }
                }
                else
                {
                    foreach (var condition in filter.Value)
                    {
                        peoples = peoples.Where(x => !x.Contains(condition)).ToList();
                    }
                }
            }

            Console.WriteLine(string.Join(" ", peoples));
        }
    }
}
