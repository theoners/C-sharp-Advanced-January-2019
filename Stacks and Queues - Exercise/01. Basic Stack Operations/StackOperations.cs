namespace _01._Basic_Stack_Operations
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StackOperations
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = input[0];
            var s = input[1];
            var x = input[2];

            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                if (i < numbers.Length)
                {
                    stack.Push(numbers[i]);
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < s; i++)
            {
                if (stack.Count != 0)
                {
                    stack.Pop();
                }
                else
                {
                    break;
                }

            }

            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count != 0)
            {
                int minValue = stack.Min();
                Console.WriteLine(minValue);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
