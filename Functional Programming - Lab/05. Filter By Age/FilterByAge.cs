namespace _05._Filter_By_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class FilterByAge
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var listOfPeople = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                var person = new Person()
                {
                    Name = line[0],
                    Age = int.Parse(line[1])
                };
                listOfPeople.Add(person);
            }

            var condition = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            Func<Person,bool> filterByAge;

            if (condition=="older")
            {
                filterByAge = p => p.Age >= age;
            }
            else
            {
                filterByAge = p => p.Age < age;
            }

            var format = Console.ReadLine();

            Func<Person,string> printFormat;

            switch (format)
            {
                case "name age":
                    printFormat = p => $"{p.Name} - {p.Age}";
                    break;
                case "name":
                    printFormat = p => $"{p.Name}";
                    break;
                default:
                    printFormat = p => $"{p.Age}";
                    break;
            }

            foreach (var people in listOfPeople.Where(filterByAge).Select(printFormat))
            {
                Console.WriteLine(people);
            }
        }
    }
}
