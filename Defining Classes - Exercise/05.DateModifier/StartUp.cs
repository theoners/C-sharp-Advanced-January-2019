namespace _05.DateModifier
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var twoDates = new DateModifier(DateTime.Parse(Console.ReadLine()), DateTime.Parse(Console.ReadLine()));
            var differenceInDays = twoDates.DateDifferenceInDays();
            Console.WriteLine(differenceInDays);
        }
    }
}
