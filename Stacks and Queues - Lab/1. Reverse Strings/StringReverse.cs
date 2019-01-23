namespace _1._Reverse_Strings
{
    using System;
    using System.Collections.Generic;

    public class StringReverse
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                result.Push(input[i]);
            }

            while (result.Count != 0)
            {
                Console.Write(result.Pop());
            }

            Console.WriteLine();
        }
    }
}
