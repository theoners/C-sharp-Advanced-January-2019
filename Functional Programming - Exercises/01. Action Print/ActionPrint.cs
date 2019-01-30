namespace _01._Action_Print
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ActionPrint
    {
        public static void Main(string[] args)
        {
           var peoples = new Queue<string>(Console.ReadLine().Split());

            void PrintAction(string x) => Console.WriteLine(x);

            while (peoples.Any())
            {
                PrintAction(peoples.Dequeue());
            }

        }
    }
}
