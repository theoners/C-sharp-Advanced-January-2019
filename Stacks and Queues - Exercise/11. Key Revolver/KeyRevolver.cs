namespace _11._Key_Revolver
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class KeyRevolver
    {
        public static void Main()
        {
            int bulletsPrice = int.Parse(Console.ReadLine());
            int sizeOfTheGunBarrel = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split().Select(int.Parse);
            var bullets = new Stack<int>(input);
            input = Console.ReadLine().Split().Select(int.Parse);
            var locks = new Queue<int>(input);
            int valueOfTheIntelligence = int.Parse(Console.ReadLine());
            var bulletCount = 0;

            while (bullets.Any()&& locks.Any())
            {
                var currentBullet = bullets.Pop();
                var currentLock = locks.Peek();
                if (currentBullet>currentLock)
                {
                    Console.WriteLine("Ping!");
                }
                else
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }

                bulletCount++;
                if (bulletCount%sizeOfTheGunBarrel==0 && bullets.Any())
                {
                    Console.WriteLine("Reloading!");
                }
            }

            if (!locks.Any())
            {
                var totalBulletsCost = bulletsPrice * bulletCount;
                var totalIncome = valueOfTheIntelligence - totalBulletsCost;

                Console.WriteLine($"{bullets.Count} bullets left. Earned ${totalIncome}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
