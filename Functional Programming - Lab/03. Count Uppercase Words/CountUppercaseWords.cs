namespace _03._Count_Uppercase_Words
{
    using System;
    using System.Linq;

    public class CountUppercaseWords
    {
       public static void Main()
       {
           var input = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Where(x => char.IsUpper(x[0]))
               .ToList();

           foreach (var word in input)
           {
               Console.WriteLine(word);
           }
       }
    }
}
