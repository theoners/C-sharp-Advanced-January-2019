namespace _04._Add_VAT
{
    using System;
    using System.Linq;

    public class AddVAT
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x=>double.Parse(x)*1.2)
                .ToList();
            foreach (var price in input)
            {
                Console.WriteLine($"{price:F2}");
            }
        }
    }
}
