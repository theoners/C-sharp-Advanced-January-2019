namespace _13.FamilyTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using _13.FamilyTree.Classes;

    public class StartUp
    {
        public static void Main()
        {
            var nameBirthday = new List<string>();
            var parentChild = new List<string>();
            var peopleBirthday = string.Empty;
            var peopleName = string.Empty;
            var person = new Person();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                if (input.Contains("-"))
                {
                    parentChild.Add(input);
                }
                else
                {
                    nameBirthday.Add(input);
                }
            }

            if (nameBirthday[0].Contains('/'))
            {
                peopleBirthday = nameBirthday[0];
                peopleName = nameBirthday
                   .FirstOrDefault(x => x.Contains(peopleBirthday) && x.Length>peopleBirthday.Length)
                   .Replace(peopleBirthday, "").Trim();
            }
            else
            {
                peopleName = nameBirthday[0];
                peopleBirthday = nameBirthday.FirstOrDefault(x => x.Contains(peopleName) && x.Contains("/"))
                    .Replace(peopleName, "").Trim();
            }
            person = new Person()
            {
                Name = peopleName,
                Birthday = peopleBirthday
            };

            foreach (var line in parentChild)
            {
                if (line.Contains(peopleName) || line.Contains(peopleBirthday))
                {
                    var currentLine = line.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                    var currentBirthday = string.Empty;
                    var currentName = string.Empty;
                    if (currentLine[0] == peopleBirthday || currentLine[0]==peopleName)
                    {
                        var child = new Child();
                        if (currentLine[1].Contains("/"))
                        {
                            var childBirthday = currentLine[1];
                            var childName = nameBirthday.FirstOrDefault(x => x.Contains(childBirthday))
                                .Replace(childBirthday, "").Trim();
                             child = new Child(){ChildBirthday = childBirthday,ChildName = childName};
                            
                        }
                        else
                        {
                            var childName = currentLine[1];
                            var childBirthday = nameBirthday.FirstOrDefault(x => x.Contains(childName))
                                .Replace(childName,"").Trim();
                             child = new Child() { ChildBirthday = childBirthday, ChildName = childName };
                        }
                        person.Children.Add(child);
                    }

                    else
                    {
                        var parent= new Parent();
                        if (currentLine[0].Contains("/"))
                        {
                            var parentBirthday = currentLine[0].Trim();
                            var ParentName = nameBirthday.FirstOrDefault(x => x.Contains(parentBirthday))
                                .Replace(parentBirthday, "").Trim();
                             parent = new Parent() { ParentBirthDay = parentBirthday, ParentName = ParentName };
                        }
                        else
                        {
                            var parentName = currentLine[0].Trim();
                            var ParentBirthday = nameBirthday.FirstOrDefault(x => x.Contains(parentName))
                                .Replace(parentName, "").Trim();
                            parent = new Parent() { ParentBirthDay = ParentBirthday, ParentName = parentName };
                        }

                        person.Parent.Add(parent);
                    }
                }
            }

            Console.WriteLine($"{person.Name} {person.Birthday}");
            Console.WriteLine("Parents:");
            foreach (var parent in person.Parent)
            {
                Console.WriteLine($"{parent.ParentName} {parent.ParentBirthDay}");
            }
            Console.WriteLine("Children:");
            foreach (var child in person.Children)
            {
                Console.WriteLine($"{child.ChildName} {child.ChildBirthday}");
            }
        }
    }
}
