namespace _07._SoftUni_Party
{
    using System;
    using System.Collections.Generic;

    public class SoftUniParty
    {
        public static void Main()
        {
            var vip = new HashSet<string>();
            var regular = new HashSet<string>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "PARTY")
                {
                    break;
                }

                if (char.IsDigit(input[0]))
                {
                    vip.Add(input);
                }
                else
                {
                    regular.Add(input);
                }
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }
                if (char.IsDigit(input[0]))
                {
                    vip.Remove(input);
                }
                else
                {
                    regular.Remove(input);
                }
            }

            Console.WriteLine($"{vip.Count + regular.Count}");
            foreach (var guest in vip)
            {
                Console.WriteLine(guest);
            }

            foreach (var guest in regular)
            {
                Console.WriteLine(guest);
            }
        }
    }
}