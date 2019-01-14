namespace _02._Basic_Queue_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class QueueOperations
    {
        public static void Main()
        {

            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = input[0];
            var s = input[1];
            var x = input[2];

            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                if (i < numbers.Length)
                {
                    queue.Enqueue(numbers[i]);
                }
                else
                {
                    break;
                }

            }

            for (int i = 0; i < s; i++)
            {
                if (queue.Count != 0)
                {
                    queue.Dequeue();
                }
                else
                {
                    break;
                }

            }

            if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count != 0)
            {
                int minValue = queue.Min();
                Console.WriteLine(minValue);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
