namespace _05._Fashion_Boutique
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FashionBoutique
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse);
            var clothes = new Stack<int>(input);
            var rackCapacity = int.Parse(Console.ReadLine());
            var currentRack = rackCapacity;
            var rackCount = 1;

            while (clothes.Any())
            {
                var currentClothes = clothes.Pop();
                if (currentRack>=currentClothes)
                {
                    currentRack -= currentClothes;
                }
                else
                {
                    currentRack = rackCapacity;
                    currentRack -= currentClothes;
                    rackCount++;
                }
            }

            Console.WriteLine(rackCount);
        }
    }
}
