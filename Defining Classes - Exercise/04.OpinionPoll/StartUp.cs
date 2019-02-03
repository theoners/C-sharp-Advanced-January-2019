using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            var membersCount = int.Parse(Console.ReadLine());
            var members = new Family();
            for (int i = 0; i < membersCount; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var name = input[0];
                var age = int.Parse(input[1]);
                var person = new Person(name, age);
                members.AddMember(person);
            }

            var personThanMore30Year = members.GetMemberMoreThan30();

            foreach (var person in personThanMore30Year)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
            
        }
    }
}
