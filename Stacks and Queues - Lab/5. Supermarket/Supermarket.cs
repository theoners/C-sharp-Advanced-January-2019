namespace _5._Supermarket
{
    using System;
    using System.Collections.Generic;

    public class Supermarket
    {
       public static void Main()
       {
           var peoples = new Queue<string>();

           while (true)
           {
               var input = Console.ReadLine();
               if (input=="End")
               {
                   break;
               }

               if (input=="Paid")
               {
                   foreach (var people in peoples)
                   {
                       Console.WriteLine(people);
                   }
                   peoples.Clear();
               }
               else
               {
                   peoples.Enqueue(input);
               }
           }

           Console.WriteLine($"{peoples.Count} people remaining.");
       }
    }
}
