namespace _03._Custom_Min_Function
{
    using System;
    using System.Linq;

    public class CustomMinFunc
    {
        public static void Main()
            => Console.WriteLine(Console.ReadLine().Split().Select(int.Parse).Min());
    }
}
