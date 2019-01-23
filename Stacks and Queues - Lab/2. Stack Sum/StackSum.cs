namespace _2._Stack_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StackSum
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numbers = new Stack<int>(input);

            while (true)
            {
                var line = Console.ReadLine().ToLower();

                if (line=="end")
                {
                    break;
                }

                var lineParts = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var command = lineParts[0];
                int firstNumber = int.Parse(lineParts[1]);
                if (command=="add")
                {
                    
                    int secondNumber = int.Parse(lineParts[2]);
                    numbers.Push(firstNumber);
                    numbers.Push(secondNumber);
                }
                else
                {
                    if (numbers.Count<firstNumber)
                    {
                        continue;
                    }

                    for (int i = 0; i < firstNumber; i++)
                    {
                        numbers.Pop();
                    }
                }
            }

            Console.WriteLine($"Sum: {numbers.Sum()}");
        }
    }
}
