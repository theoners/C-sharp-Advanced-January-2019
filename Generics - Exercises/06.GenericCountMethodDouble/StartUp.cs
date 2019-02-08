namespace _06.GenericCountMethodDouble
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var box = new Box<double>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                box.Add(double.Parse(Console.ReadLine()));
            }

            var number = double.Parse(Console.ReadLine());
            Console.WriteLine(CompareElement(box.Data, number));
        }

        private static object CompareElement<T>(List<T> boxData, double number)
        {
            var count = 0;
            foreach (var item in boxData)
            {
                if (number.CompareTo(item) < 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
