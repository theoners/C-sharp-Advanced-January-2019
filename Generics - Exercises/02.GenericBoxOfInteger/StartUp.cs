namespace _02.GenericBoxOfInteger
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<Box<int>>();

            for (int i = 0; i < n; i++)
            {
                var line = new Box<int>() { Value = int.Parse(Console.ReadLine())};
                list.Add(line);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

