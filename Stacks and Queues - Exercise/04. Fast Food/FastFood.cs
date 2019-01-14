namespace _04._Fast_Food
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FastFood
    {
        public static void Main()
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split().Select(int.Parse);
            var ordersQuantities = new Queue<int>(input);
            var maxValue = ordersQuantities.Max();
            while (ordersQuantities.Any())
            {
                if (foodQuantity >= ordersQuantities.Peek())
                {
                    var currentOrder = ordersQuantities.Dequeue();
                    foodQuantity -= currentOrder;
                }
                else
                {
                    break;
                }
                
            }

            Console.WriteLine(maxValue);
            if (ordersQuantities.Any())
            {
                Console.WriteLine($"Orders left: {string.Join(" ", ordersQuantities)}");
            }
            else
            {
                Console.WriteLine($"Orders complete");
            }
        }
    }
}
