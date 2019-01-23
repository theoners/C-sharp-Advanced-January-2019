namespace _04._Cities_by_Continent_and_Country
{
    using System;
    using System.Collections.Generic;

    public class ContinentCountryAndCity
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var continent = input[0];
                var country = input[1];
                var city = input[2];

                if (!dict.ContainsKey(continent))
                {
                    dict.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!dict[continent].ContainsKey(country))
                {
                    dict[continent].Add(country, new List<string>());
                }

                dict[continent][country].Add(city);
            }

            foreach (var keyValuePair in dict)
            {
                Console.WriteLine($"{keyValuePair.Key}:");
                foreach (var countryAndCity in keyValuePair.Value)
                {
                    Console.WriteLine($"{countryAndCity.Key} -> {string.Join(", ", countryAndCity.Value)}");
                }
            }
        }
    }
}