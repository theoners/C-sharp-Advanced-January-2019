namespace _03._Maximum_and_Minimum_Element
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaxANdMinElement
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var command = int.Parse(input[0]);

                if (command==1)
                {
                    var number = int.Parse(input[1]);
                    numbers.Push(number);
                }
                else if (command==2 && numbers.Any())
                {
                    numbers.Pop();
                }
                else if (command==3 && numbers.Any())
                {
                   int maxValue =  numbers.Max();
                    Console.WriteLine(maxValue);
                }
                else if (command==4 && numbers.Any())
                {
                    int minValue = numbers.Min();
                    Console.WriteLine(minValue);
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
