namespace _01.GenericBoxOfString
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            {
                var line = new Box<string>(){Value = Console.ReadLine()};
                list.Add(line);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
