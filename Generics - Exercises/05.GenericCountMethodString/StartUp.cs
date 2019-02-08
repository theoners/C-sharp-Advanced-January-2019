namespace _05.GenericCountMethodString
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var box = new Box<string>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                box.Add(Console.ReadLine());
            }

            var element = Console.ReadLine();
            Console.WriteLine(CompareElement(box.Data, element));
        }

        private static object CompareElement<T>(List<T> boxData, string element)
        {
            var count = 0;
            foreach (var item in boxData)
            {
                if (element.CompareTo(item)<0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
