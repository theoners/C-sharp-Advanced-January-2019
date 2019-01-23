namespace _3._Simple_Calculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Calculator
    {
       public static void Main()
        {
            var input = Console.ReadLine().Split();
            var stack = new Stack<string>(input.Reverse());

            while (stack.Count > 1)
            {
                var firstNumber = int.Parse(stack.Pop());
                var operand = stack.Pop();
                var secondNumber = int.Parse(stack.Pop());

                if (operand == "+")
                {
                    var result = firstNumber + secondNumber;
                    stack.Push(result.ToString());
                }
                else
                {
                    var result = firstNumber - secondNumber;
                    stack.Push(result.ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
