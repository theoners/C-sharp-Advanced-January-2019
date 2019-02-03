namespace _12.Google
{
    using System;
    using System.Collections.Generic;
    using _12.Google.Classes;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var peoples = new List<People>();
            while (true)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "End")
                {
                    break;
                }

                var peopleName = input[0];
                if (!peoples.Exists(x => x.Name == peopleName))
                {
                    var people = new People { Name = peopleName };
                    peoples.Add(people);
                }
                switch (input[1])
                {
                    case "company":
                        {
                            var companyName = input[2];
                            var department = input[3];
                            var salary = double.Parse(input[4]);
                            var company = new Company(companyName, department, salary);
                            var currentPeopleIndex = peoples.FindIndex(x => x.Name == peopleName);
                            peoples[currentPeopleIndex].Company = company;
                            break;
                        }
                    case "pokemon":
                        {
                            var pokemonName = input[2];
                            var pokemonType = input[3];
                            var pokemon = new Pokemon(pokemonName, pokemonType);
                            var currentPeopleIndex = peoples.FindIndex(x => x.Name == peopleName);
                            peoples[currentPeopleIndex].Pokemons.Add(pokemon);
                            break;
                        }
                    case "parents":
                        {
                            var parentName = input[2];
                            var parentBirthday = input[3];
                            var parent = new Parent(parentName, parentBirthday);
                            var currentPeopleIndex = peoples.FindIndex(x => x.Name == peopleName);
                            peoples[currentPeopleIndex].Parents.Add(parent);
                            break;
                        }
                    case "children":
                        {
                            var childName = input[2];
                            var childBirthday = input[3];
                            var child = new Child(childName, childBirthday);
                            var currentPeopleIndex = peoples.FindIndex(x => x.Name == peopleName);
                            peoples[currentPeopleIndex].Children.Add(child);
                            break;
                        }
                    default:
                        {
                            var carModel = input[2];
                            var carSpeed = double.Parse(input[3]);
                            var car = new Car(carModel, carSpeed);
                            var currentPeopleIndex = peoples.FindIndex(x => x.Name == peopleName);
                            peoples[currentPeopleIndex].Car=car;
                            break;
                        }
                }
            }

            var name = Console.ReadLine();
            Console.WriteLine(peoples.FirstOrDefault(x => x.Name == name).ToString());
        }
    }
}
